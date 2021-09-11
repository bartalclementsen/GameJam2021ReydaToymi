using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSceneHandler : MonoBehaviour {

    private Core.Mediators.IMessenger messenger;

    private void Start() {
        messenger = Game.Container.Resolve<Core.Mediators.IMessenger>();

        messenger.Subscribe<PlayerWonMessage>(m => {
            WinGame();

            // DO STUFF WHEN PLAYER WON!!
        });
    }

    public void WinGame()
    {
        SceneManager.LoadSceneAsync(2);
    }

    public void LooseGame()
    {
        SceneManager.LoadSceneAsync(3);
    }
}
