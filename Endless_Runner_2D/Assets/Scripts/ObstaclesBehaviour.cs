using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstaclesBehaviour : MonoBehaviour
{
    float maxSpeed = 2f;
    ObjectsSpawnerScript objScript;

    // Use this for initialization
    void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        Vector3 pos = transform.position;
        pos.y +=  maxSpeed * Time.deltaTime;
        transform.position = pos;
	}

    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.tag == "Player")
        {

                Destroy(this.gameObject);
        }


    }
} 
