﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    void Start() {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
    public void loadScene(int index) {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + index);
    }
}
