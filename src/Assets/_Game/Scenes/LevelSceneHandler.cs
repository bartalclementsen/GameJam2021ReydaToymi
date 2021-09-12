using Core.Mediators;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.XR;
using UnityEngine.XR.Management;

public class LevelSceneHandler : MonoBehaviour {

    private Core.Mediators.IMessenger messenger;
    [SerializeField] GameObject Player, PlayerVR;

    private ISubscriptionToken playerDeathMessageToken;
    private ISubscriptionToken playerWonMessageToke;

    private void Start() {
        StartCoroutine(StartXR());

        messenger = Game.Container.Resolve<Core.Mediators.IMessenger>();

        playerWonMessageToke = messenger.Subscribe<PlayerWonMessage>(m => {
            Cursor.lockState = CursorLockMode.None;
            WinGame();
        });

        playerDeathMessageToken = messenger.Subscribe<PlayerDeathMessage>(m => {
            Cursor.lockState = CursorLockMode.None;
            LoseGame();
        });
    }

    private void OnDestroy()
    {
        playerDeathMessageToken?.Dispose();
        playerWonMessageToke?.Dispose();
    }

    public void WinGame()
    {
        SceneManager.LoadScene(2);
    }

    public void LoseGame()
    {
        SceneManager.LoadScene(3);
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
