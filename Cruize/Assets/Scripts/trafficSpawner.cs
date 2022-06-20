using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trafficSpawner : MonoBehaviour
{
    public GameObject [] cars;
	int carNumber;
    public float maxPos = 1.947581f;
    float timer;
    public float spawnDelayTimer = 1f;

    void Start()
    {
        timer = spawnDelayTimer;
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if(timer <= 0) //Only instantiate new cars when the timer hits zero to avoid spawning a million.
        {
            Vector3 carPos = new Vector3(Random.Range(-1.947581f, 1.947581f), transform.position.y, transform.position.z);
            carNumber = Random.Range (0,3); //Randomly select one of the cars to instantiate.
			Instantiate(cars[carNumber], carPos, transform.rotation); //Instantiate the traffic car.
            timer = spawnDelayTimer;
        }
    }
}
