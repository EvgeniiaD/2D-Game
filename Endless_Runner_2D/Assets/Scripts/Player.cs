using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Vector2 speed;
    private Vector2 axis;
    private Vector2 currentVelocity;

    public Vector3 iniValue;
    public Vector3 finalValue;
    Vector3 deltaValue;
    public float currentTime;
    public float timeDuration;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //currentVelocity = new Vector2(axis.x * speed.x, axis.y * speed.y);
        HorizontalMovement();
        VerticalMovement();

        transform.Translate(currentVelocity * Time.deltaTime);
    }
    public void SetAxis(Vector2 inputAxis)
    {
        axis = inputAxis;
    }
    void HorizontalMovement()
    {
        if ((axis.x < 0 && transform.position.x < -2.1f) || (axis.x > 0 && transform.position.x > 2.3f))
        {
            currentVelocity.x = 0;

            Easing.ExpoEaseInOut(currentTime, iniValue.x, deltaValue.x, timeDuration);

            return;
        }
        currentVelocity.x = speed.x * axis.x;

    }
    void VerticalMovement()
    {
        if ((axis.y < 0 && transform.position.y < -4.4f) || (axis.y > 0 && transform.position.y > 4.4f))
        {
            currentVelocity.y = 0;
            return;
        }
        currentVelocity.y = speed.y * axis.y;

    }
    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Ha entrao");
        if (other.tag == "Player")
        {
            Destroy(other.gameObject);
        }


    }
}