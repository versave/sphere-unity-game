using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeMaterial : MonoBehaviour {
    public Material[] material;
    public float speed;
    private float size;
    private float value = 0f;
    private int dice;
    private int randomStart = 0;
    private int randomEnd = 100;

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
        if(value >= 1) {
            Application.Quit();
        }

        if (Input.GetButton("Scale")) {
            dice = randomNumber(randomStart, randomEnd);

            if (dice == 6) {
                rend.sharedMaterial = material[1];
                rend.material.Lerp(material[0], material[1], incTransition(ref value, speed));

                randomStart = 6;
                randomEnd = 6;
            }
        } else if (transform.localScale.x > size) {
            rend.material.Lerp(material[0], material[1], decTransition(ref value, speed));

            randomStart = 0;
            randomEnd = randomEnd >= 20 ? randomEnd -= 1 : 20;
        }
    }
}
