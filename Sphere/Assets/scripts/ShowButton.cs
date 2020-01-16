using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowButton : MonoBehaviour
{
    GameObject button;

    private void Start() {
        button = GameObject.FindGameObjectWithTag("button");
    }
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("space")) {
            Debug.Log(1);

            button.SetActive(false);
        } else if(Input.GetKeyUp("space")) {
            Debug.Log(2);

            button.SetActive(true);
        }    
    }
}
