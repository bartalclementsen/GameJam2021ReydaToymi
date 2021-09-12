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
    // https://forum.unity.com/threads/how-to-detect-if-headset-is-available-and-initialize-xr-only-if-true.927134/#post-6600589
    public IEnumerator StartXR() {
        yield return XRGeneralSettings.Instance.Manager.InitializeLoader();
        if (XRGeneralSettings.Instance.Manager.activeLoader != null) {
            bool loaderSuccess = XRGeneralSettings.Instance.Manager.activeLoader.Start();
            if (loaderSuccess) {
                PlayerVR.SetActive(true);
                yield break;
            }
        }
        Player.SetActive(true);
    }

}
