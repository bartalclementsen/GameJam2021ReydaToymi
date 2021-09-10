using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartSceneHandler : MonoBehaviour
{
    [SerializeField]
    private Text _versionText;

    private void Start()
    {
        _versionText.text = $"{Application.companyName} - {Application.productName} - version: {Application.version}";
    }

    public void StartGame()
    {
        SceneManager.LoadSceneAsync(1);
    }

    public void Exit()
    {
        Application.Quit();
    }
}
