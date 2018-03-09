using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectsSpawnerScript : MonoBehaviour
{

    public GameObject obstacles;
    float rendX;
    Vector2 whereToSpawn;
    public float spawnRate = 1f;
    float nextSpawn = 0.0f;

    


    // Use this for initialization
    void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if(Time.time > nextSpawn)
        {
            nextSpawn = Time.time + spawnRate;
            rendX = Random.Range(-2.2f, 2.2f);
            whereToSpawn = new Vector2(rendX, transform.position.y);
            Instantiate(obstacles, whereToSpawn, Quaternion.identity);
        }
		
	}


}
