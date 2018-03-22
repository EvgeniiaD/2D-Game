using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class treespawner : MonoBehaviour
	{
		public GameObject obstacle_02;


		public Transform playerTransform;

		public float minX, maxX;
		public float minTime, maxTime;
		private float spawnTime;
		private float timeCounter = 0;

		public bool disable;

		public void Start()
		{
			spawnTime = minTime;
			timeCounter = 0;
		}

		private void Update()
		{
			if(disable) return;

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

			Vector3 pos = transform.position;
			pos.x = xPos;

			Instantiate(obstacle_02, pos, Quaternion.identity);


		}
	}