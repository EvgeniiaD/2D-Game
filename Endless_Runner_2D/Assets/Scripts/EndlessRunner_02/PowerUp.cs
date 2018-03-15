using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    public bool invincibleMode;
    public float powerUpLength;
    public PlayerBehaviour thePlayer;

	// Use this for initialization
	void Start ()
    {
        thePlayer = FindObjectOfType<PlayerBehaviour>();
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    void OnTriggerEnter2D(Collider2D other)
    {

        if(other.tag == "Player")
        {
            thePlayer.ActivatePowerUp(invincibleMode, powerUpLength); 
        }
        invincibleMode = true;
        gameObject.SetActive(false);

    }
}
