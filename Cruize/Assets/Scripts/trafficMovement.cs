using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trafficMovement : MonoBehaviour
{
    public float speed = 8f;


    void Start()
    {
        
    }

    
    void Update()
    {
        transform.Translate(new Vector3(0, 1, 0) * speed * Time.deltaTime); //Only allow traffic cars to move in the Y direction and not left/right.
    }
}
