using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text scoreText;
    public Text hiScoreText;
    public Text coinsText;

    public Transform playerTransform;

    public float scoreCount;
    public float hiScoreCount;
    public int coinsCount;

    public float pointPerSecond;

    public bool scoreIncreasing;


    private float previousScore;
    private float currentScore;
    private float diffScore;

    // Use this for initialization
    void Start()
    {
        if(PlayerPrefs.HasKey("HighScore"))
        {
            hiScoreCount = PlayerPrefs.GetFloat("HighScore");
        }
        scoreIncreasing = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(scoreIncreasing)
        {
            scoreCount = coinsCount + ((playerTransform.position.y - 4.78f) * -1);
        }


        if(scoreCount > hiScoreCount)
        {
            hiScoreCount = scoreCount;
            PlayerPrefs.SetFloat("HighScore", hiScoreCount);
        }

        scoreText.text = "Score: " + Mathf.Round(scoreCount);
        hiScoreText.text = "High Score: " + Mathf.Round(hiScoreCount);
    }

    public void AddScore(int pointsToAdd)
    {
        coinsText.text = "x " + coinsCount;
        scoreCount += pointsToAdd;

    }
}
