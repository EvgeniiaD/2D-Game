﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerBehaviour : MonoBehaviour
{

    private float score;
    public float movementSpeed;

    private bool movingLeft;
    private float rotationSpeed;

    public Text scoreText;

    // Use this for initialization
    void Start ()
    {
        score = 0;
        movingLeft = true;

	}
	
	// Update is called once per frame
	void Update ()
    {
        score += Time.deltaTime;
        transform.Translate(Vector3.down * Time.deltaTime * movementSpeed);


        if(Input.GetKeyDown(KeyCode.Space))
        {
            rotationSpeed = .5f;
            movingLeft = !movingLeft;
        }
        if(Input.GetKey(KeyCode.Space))
        {
            rotationSpeed += 1.5f * Time.deltaTime;
        }

        if (movingLeft) transform.Rotate(0, 0, rotationSpeed);
        else transform.Rotate(0, 0, -rotationSpeed);
	}

    void FixedUpdate()
    {
        scoreText.GetComponent<Text>().text = "Score: " + score;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Obstacle")
        {
            Die();
        }
    }

    void Die()
    {
        print("Player dead");
        Destroy(this.gameObject);
    }
}
