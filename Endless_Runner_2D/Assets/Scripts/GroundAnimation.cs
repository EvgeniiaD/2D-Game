using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundAnimation : MonoBehaviour
{
    public Transform playerTransform;
    private Vector2 groundPos;

    private Material mat;
    public float speed;

    private float previousY;
    private float currentY;
    private float diffY;
    Vector2 offset;
    // Use this for initialization
    void Start ()
    {
        mat = GetComponent<SpriteRenderer>().material;
        groundPos = playerTransform.position;
        previousY = playerTransform.position.y;

        offset = Vector2.zero;
    }
	
	// Update is called once per frame
	void Update ()
    { 
        currentY = playerTransform.position.y;
        diffY = currentY - previousY;
        previousY = currentY;

        offset.y += diffY * speed * Time.deltaTime;

        mat.SetTextureOffset("_MainTex", offset);      
	}

    private void LateUpdate()
    {
        groundPos.y = playerTransform.position.y;
        transform.position = groundPos;
    }
}
