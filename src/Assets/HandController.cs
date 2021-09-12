using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandController : MonoBehaviour {

    public Grabber grabber;

    private void OnTriggerEnter(Collider other) {
        Debug.Log("OnTriggerEnter");
        Debug.Log(other.gameObject);
        IMouseClickable script = other.GetComponentInParent<IMouseClickable>();
        if (script != null) {
            script.MouseDown();
            script.SetGrabber(grabber);
            Debug.Log(script);
            Debug.Log(grabber);
        }
    }

    private void OnTriggerExit(Collider other) {
        Debug.Log("OnTriggerExit");
        Debug.Log(other.gameObject);
        IMouseClickable script = other.GetComponentInParent<IMouseClickable>();
        if (script != null) {
            script.MouseUp();
        }
    }

}
