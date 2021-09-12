using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.XR;
using UnityEngine.XR.Management;

public class LevelSceneHandler : MonoBehaviour {

    private Core.Mediators.IMessenger messenger;

    [SerializeField] GameObject Player, PlayerVR;

    private void Start() {
        StartCoroutine(StartXR());

        messenger = Game.Container.Resolve<Core.Mediators.IMessenger>();

        messenger.Subscribe<PlayerWonMessage>(m => {
            Cursor.lockState = CursorLockMode.None;
            WinGame();
        });

        messenger.Subscribe<PlayerDeathMessage>(m => {
            Cursor.lockState = CursorLockMode.None;
            LoseGame();
        });
    }

    public void WinGame()
    {
        SceneManager.LoadSceneAsync(2);
    }

    public void LoseGame()
    {
        SceneManager.LoadSceneAsync(3);
    }

    public IEnumerator StartXR() {
        yield return new WaitForSeconds(1); 
        var inputDevices = new List<InputDevice>();
        InputDevices.GetDevices(inputDevices);
        foreach (var device in inputDevices) {
            if (device.name.ToLowerInvariant() == "head tracking - openxr".ToLowerInvariant()) {
                Player.SetActive(false);
                yield break;
            }
        }
        PlayerVR.SetActive(false);
    }

}
