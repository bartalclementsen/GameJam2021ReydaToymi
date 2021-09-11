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
        if (isDragging)
        {
            float increment = Input.GetAxis("Mouse Y") * speed * Time.deltaTime;
            Debug.Log(increment);
            current = Mathf.Max(min, Mathf.Min(max, current + increment));
            handle.transform.localRotation = Quaternion.Euler(current, 0, 0);
        }

        if(current > 0.1 || current < - 0.1)
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
}

