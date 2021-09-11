using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSceneHandler : MonoBehaviour {

    private Core.Mediators.IMessenger messenger;

    private void Start() {
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
}
