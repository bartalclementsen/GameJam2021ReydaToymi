using UnityEngine;
using UnityEngine.SceneManagement;

public class WinScreneHandler : MonoBehaviour
{
    public void BackToMainMenu()
    {
        SceneManager.LoadScene(0);
    }
}
