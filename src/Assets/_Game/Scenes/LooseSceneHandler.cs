using UnityEngine;
using UnityEngine.SceneManagement;

public class LooseSceneHandler : MonoBehaviour
{
    public void RetryGame()
    {
        SceneManager.LoadScene(1);
    }

    public void BackToMainMenu()
    {
        SceneManager.LoadScene(0);
    }
}
