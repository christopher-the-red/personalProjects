using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class roadMove : MonoBehaviour
{
    
    public float speed; //How fast the road is moving.
    Vector2 offset; //Offset for road texture wrapping.

    void Start()
    {
        
    }

    
    void Update()
    {
        offset = new Vector2(0, Time.time * speed);
        GetComponent<Renderer>().material.mainTextureOffset = offset; //Allows road texture to keep moving downwards.
    }
}
