using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWonMessage : Core.Mediators.Message {

}

public class VictoryAreaScript : MonoBehaviour {

    private Core.Mediators.IMessenger messenger;

    private void Start() {
        messenger = Game.Container.Resolve<Core.Mediators.IMessenger>();
    }

    private void OnTriggerEnter(Collider collision) {
        Debug.Log("here " + collision.tag + " " + collision.gameObject.tag);
        if (collision.CompareTag("Player")) {
            messenger.Publish(new PlayerWonMessage());
        }
    }

}
