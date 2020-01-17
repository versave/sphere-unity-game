using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour
{
    Text field;
    public float highScore = 0;
    
    GameObject cam;

    public float camZ;
    public float ogCamZ;

    GameObject ball;
    public float ballSize;

    private void incScore() {
        highScore += 0.05f;
    }

    void Start() {
        field = GetComponent<Text>();

        cam = GameObject.FindGameObjectWithTag("ballCamera");
        camZ = cam.transform.position.z;
        ogCamZ = cam.transform.position.z;

        ball = GameObject.FindGameObjectWithTag("shell");
    }

    // Update is called once per frame
    void Update()
    {
        scale scale = ball.GetComponent<scale>();
        ballSize = scale.size;

        if (Input.GetButton("Scale")) {
            incScore();

            if ((camZ <= ogCamZ || camZ >= ogCamZ) && ballSize >= 120) {
                camZ -= 0.1f;   
                cam.transform.position = new Vector3(cam.transform.position.x, cam.transform.position.y, camZ);
            }

            field.text = Mathf.Floor(highScore).ToString();
        } else {
            if(camZ <= ogCamZ) {
                camZ += 0.1f;
                cam.transform.position = new Vector3(cam.transform.position.x, cam.transform.position.y, camZ);
            }
        }
    }
}
