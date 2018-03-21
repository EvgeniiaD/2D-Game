﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour {

    
    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.tag == "Obstacle")
        {
            Destroy(other.gameObject);
        }

        if(other.tag == "Coin")
        {
            Destroy(other.gameObject);
        }

    }


}
