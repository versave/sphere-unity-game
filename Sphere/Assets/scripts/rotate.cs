using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour
{
    public float xVelocity;
    public float yVelocity;
    public float zVelocity;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(xVelocity * Time.deltaTime, yVelocity * Time.deltaTime, zVelocity * Time.deltaTime); 
    }
}
