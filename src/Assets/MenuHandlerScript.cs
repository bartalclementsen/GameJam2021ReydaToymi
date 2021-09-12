using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuHandlerScript : MonoBehaviour {
    
    [SerializeField] GameObject PauseMenu;

    private void Update() 
    {
        if (Input.GetKeyDown(KeyCode.Escape)) 
        {
            if (PauseMenu.gameObject.activeSelf) 
            {
                ReturnToGame();
            } 
            else 
            {
                ShowMenu();
            }
        }
    }

    private void ShowMenu()
    {
        PauseMenu.gameObject.SetActive(true);
        Time.timeScale = 0;
        Cursor.lockState = CursorLockMode.None;
    }


    public void ReturnToGame() 
    {
        Time.timeScale = 1;
        PauseMenu.gameObject.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
    }

    public void BackToMainMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadSceneAsync(0);
        Cursor.lockState = CursorLockMode.None;
    }

    public void ExitGame() {
        Time.timeScale = 1;
        Application.Quit();
        Cursor.lockState = CursorLockMode.None;
    }

}
