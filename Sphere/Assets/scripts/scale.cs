using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scale : MonoBehaviour {
    private float size;
    private float multiplier;
    public float defaultSize;
    public float defaultMultiplier;
    public float maxSize;
    private bool cooldown = false;

    void resetCooldown() {
        cooldown = false;
    }
    
    // Start is called before the first frame update
    void Start() {
        size = defaultSize;
        multiplier = defaultMultiplier;
    }

    // Update is called once per frame
    void Update() {

        // Show success screen
        if(size >= maxSize && this.gameObject.tag == "shell") {
            FindObjectOfType<GameManager>().loadScene(+2);
        }

        if(Input.GetButton("Scale") && cooldown == false) {
            size += multiplier;

            transform.localScale = new Vector3(size, size, size);
        } else if (size > defaultSize) {
            size -= multiplier;

            transform.localScale = new Vector3(size, size, size);

            cooldown = true;
            Invoke("resetCooldown", 0.3f);
        }
    }
}
