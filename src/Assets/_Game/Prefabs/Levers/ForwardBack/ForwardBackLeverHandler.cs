using UnityEngine;

public interface IMouseClickable
{
    void MouseDown();

    void MouseUp();

    void SetGrabber(Grabber g);

    bool GetIsDragging();
}

public class ForwardBackLeverHandler : MonoBehaviour, IMouseClickable {
    
    public TestViveControllerScript viveControllerScript;

    [SerializeField]
    private GameObject handle;

    [SerializeField]
    private AudioClip[] audioClips;

    [SerializeField]
    private AudioSource audioSource;

    private float min = -60;

    private float max = 60;

    private float current = 0;

    private float speed = 50;

    private bool isDragging = false;
    
    private Core.Mediators.IMessenger messenger;

    private Grabber grabber = Grabber.NONE;

    private void Start()
    {
        messenger = Game.Container.Resolve<Core.Mediators.IMessenger>();
    }

    private void Update()
    {

        if (isDragging)
        {
            float velocity = 
                grabber == Grabber.MOUSE 
                    ? Input.GetAxis("Mouse Y")
                    : grabber == Grabber.RIGHT_VIVE
                        ? viveControllerScript.getRightHandVelocity().z
                        : viveControllerScript.getLeftHandVelocity().z;
            float speedMultiplier = grabber == Grabber.RIGHT_VIVE || grabber == Grabber.LEFT_VIVE ? 4 : 1;

            float increment = velocity * speed * speedMultiplier * Time.deltaTime;
            current = Mathf.Max(min, Mathf.Min(max, current + increment));
            handle.transform.localRotation = Quaternion.Euler(current, 0, 0);
            
            PlaySound();
        }
        else
        {
            if (audioSource.isPlaying)
                audioSource.Stop();
        }

        if (current > 0.1 || current < - 0.1)
        {
            float movementValue = current / 60.0f;
            messenger.Publish(new AccelerateZMessage(movementValue));
        }
    }

    public void MouseDown() {
        if (grabber == Grabber.NONE) isDragging = true;
    }

    public void MouseUp() {
        isDragging = false;
        grabber = Grabber.NONE;
    }

    public void SetGrabber(Grabber g) {
        grabber = g;
    }

    public bool GetIsDragging() => isDragging;

    private void PlaySound()
    {
        if (audioSource == null)
            return;

        if (audioClips == null)
            return;

        int index = Random.Range(0, audioClips.Length - 1);
        AudioClip collisionAudioClip = audioClips[index];

        if (audioSource.isPlaying == false)
        {
            audioSource.clip = collisionAudioClip;
            audioSource.Play();
        }
    }

}

public enum Grabber {
    MOUSE, LEFT_VIVE, RIGHT_VIVE, NONE
}