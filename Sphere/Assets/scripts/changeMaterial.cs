using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class changeMaterial : MonoBehaviour {
    public Material[] material;
    public float speed;
    public float value = 0f;
    public int diceSize;
    public int minDiceSize;
    private float size;
    private int dice;
    private int randomStart = 0;

    Renderer rend;

    int randomNumber(int min, int max) {
        System.Random random = new System.Random();
        return random.Next(min, max);
    }

    float incTransition(ref float value, float speed) {
        return value >= 1 ? 1 : value = value + speed;
    }

    float decTransition(ref float value, float speed) {
        return value <= 0 ? 0 : value = value - speed;
    }

    void Start() {
        rend = GetComponent<Renderer>();
        rend.enabled = true;

        scale scale = gameObject.GetComponent <scale>();

        size = scale.defaultSize;
    }

    // Update is called once per frame
    void Update() {

        // End game
        if(value >= 1) {
            FindObjectOfType<GameManager>().loadScene(+1);
        }

        if (Input.GetButton("Scale")) {
            dice = randomNumber(randomStart, diceSize);

            if (dice == 6) {
                rend.sharedMaterial = material[1];
                rend.material.Lerp(material[0], material[1], incTransition(ref value, speed));

                randomStart = 6;
                diceSize = 6;
            }
        } else if (transform.localScale.x > size) {
            rend.material.Lerp(material[0], material[1], decTransition(ref value, speed));

            randomStart = 0;
            diceSize = diceSize >= minDiceSize ? diceSize -= 1 : minDiceSize;
        }
    }
}
