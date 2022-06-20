using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carController : MonoBehaviour
{
    
    public float carSpeed; //Car'smovement speed.
    Vector3 position; //Position of the car.

    public float maxPos = 1.947581f; //The maximum x position that the player car can move.

    void Start()
    {
        position = transform.position;
    }


    void Update()
    {
        position.x += Input.GetAxis("Horizontal") * carSpeed * Time.deltaTime; //Change position of the car based on speed and user input from the left and right keys.

        position.x = Mathf.Clamp(position.x, -1.947581f, 1.947581f); //Set the left and right boundaries for the player.


        transform.position = position;
    }

    void OnCollisionEnter2D(Collision2D col) //This function is called on collision with 2D colliders.
    {
        if(col.gameObject.tag == "Enemy")
        {
            Destroy(gameObject);
        }
    }
}
