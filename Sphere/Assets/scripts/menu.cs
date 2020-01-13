using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
    public int sceneToOpenIndex;

    public void restartGame() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + sceneToOpenIndex);
    }

    public void quitGame() {
        Application.Quit();
    }
}
