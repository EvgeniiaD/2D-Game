using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawn : MonoBehaviour
{
    public GameObject coin;

    public float minX, maxX;
    public float minTime, maxTime;
    private float spawnTime;
    private float timeCounter = 0;

    public bool coinDisable;

    public void Start()
    {
        spawnTime = minTime;
        timeCounter = 0;
    }

    private void Update()
    {
        if(coinDisable) return;

        if(timeCounter >= spawnTime)
        {
            Spawn();
        }
        else timeCounter += Time.deltaTime;
    }

    void Spawn()
    {
        timeCounter = 0;
        spawnTime = Random.Range(minTime, maxTime);

        float xPos = Random.Range(minX, maxX);

        Vector2 pos = transform.position;
        pos.x = xPos;

        Instantiate(coin, pos, Quaternion.identity);
    }
}
