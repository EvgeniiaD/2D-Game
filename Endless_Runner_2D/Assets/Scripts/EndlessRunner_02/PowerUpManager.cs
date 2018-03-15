using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpManager : MonoBehaviour
{
    private bool invincibleMode;
    private bool isPowerUpActive;
    private float powerUpLengthCounter;

	// Use this for initialization
	void Start ()
    {

		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if(isPowerUpActive)
        {
            powerUpLengthCounter -= Time.deltaTime;

            if(powerUpLengthCounter <= 0)
            {
                isPowerUpActive = false;
            }
        }
		
	}

    public void ActivePowerUp(bool mode, float time)
    {
        invincibleMode = mode;
        powerUpLengthCounter = time;

    }
}
