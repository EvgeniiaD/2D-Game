using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointsCounter : MonoBehaviour
{
    public float points;
    private Text scoreText;
    float currentTime;
    

	// Use this for initialization
	void Start ()
    {
        currentTime = 0;
        points = 0;
        scoreText = GetComponent<Text>();
        scoreText.text = "";

    }
	
	// Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime;
        AddScore();
    }
	public void AddScore()
    {
        points = currentTime;
        scoreText.text = points.ToString();

		
	}
}
