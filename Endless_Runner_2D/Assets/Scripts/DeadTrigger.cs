﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadTrigger : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Obstacle")
        {
            Debug.Log("KillPlayer");
            Application.LoadLevel(Application.loadedLevelName);
        }
    }
}
