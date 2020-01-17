using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour
{
    Text field;
    public float highScore = 0;

    private void incScore() {
        highScore += 0.05f;
    }

    void Start() {
        field = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButton("Scale")) {
            incScore();

            field.text = Mathf.Floor(highScore).ToString();
        }       
    }
}
