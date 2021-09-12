using UnityEngine;

public interface IMouseClickable
{
    void MouseDown();

    void MouseUp();
}

public class ForwardBackLeverHandler : MonoBehaviour, IMouseClickable
{
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

    private void Start()
    {
        messenger = Game.Container.Resolve<Core.Mediators.IMessenger>();
    }

    private void Update()
    {
        float mouseVelocity = Input.GetAxis("Mouse Y");
        //float rightHandVelocity = TestViveControllerScript.GetRightHandAxisRawZ();
        //float leftHandVelocity = TestViveControllerScript.GetLeftHandAxisRawZ();
        //Debug.Log(mouseVelocity + " " + rightHandVelocity + " " + leftHandVelocity);

        if (isDragging)
        {
            float increment = mouseVelocity * speed * Time.deltaTime;
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

    public void MouseDown()
    {
        isDragging = true;
    }

    public void MouseUp()
    {
        isDragging = false;
    }

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

