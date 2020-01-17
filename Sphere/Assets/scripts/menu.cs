using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
    public int sceneToOpenIndex;
    private bool allowRestart = false;

    public void restartGame() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + sceneToOpenIndex);
    }

    public void quitGame() {
        Application.Quit();
    }

    private void Start() {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    void Update() {
        if (Input.GetKeyUp("space")) {
            allowRestart = true;
        }

        if (Input.GetKeyDown("space") && allowRestart) {
            restartGame();
        }

        if (Input.GetKeyDown("escape")) {
            quitGame();
        }
    }
}
