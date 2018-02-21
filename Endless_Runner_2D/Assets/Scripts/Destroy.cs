using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour {

    
	public GameObject block;


    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {

            Destroy(other);
        }
    }


}
