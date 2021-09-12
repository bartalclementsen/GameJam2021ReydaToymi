using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnablePlayerScript : MonoBehaviour
{

    public PlayerMode mode;
    public GameObject WithVR, WithoutVR;

    // Start is called before the first frame update
    void Awake() {
        WithoutVR.SetActive(mode == PlayerMode.NORMAL || mode == PlayerMode.BOTH);
        WithVR.SetActive(mode == PlayerMode.VR || mode == PlayerMode.BOTH);
    }

}

public enum PlayerMode {
    NORMAL, VR, BOTH
}