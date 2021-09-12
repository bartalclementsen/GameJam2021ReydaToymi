using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuHandlerScript : MonoBehaviour {
    
    [SerializeField] GameObject PauseMenu;

    private void Update() {
        if (Input.GetKeyDown(KeyCode.Escape)) {
            if (PauseMenu.gameObject.activeSelf) {
                ReturnToGame();
            } else {
                PauseMenu.gameObject.SetActive(true);
                Time.timeScale = 1;
                Cursor.lockState = CursorLockMode.Locked;
            }
        }
    }

    public void ReturnToGame() {
        Time.timeScale = 1;
        PauseMenu.gameObject.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
    }

    public void ExitGame() {
        Time.timeScale = 1;
        SceneManager.LoadSceneAsync(1);
        Cursor.lockState = CursorLockMode.None;
    }

}
