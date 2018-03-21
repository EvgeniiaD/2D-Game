using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamingManager : MonoBehaviour
{

    public GameObject theplayer;
    public GameObject deadMenu;
    public MenuButtons options;

    private ScoreManager theScoreManager;

    private void Start()
    {
        theScoreManager = FindObjectOfType<ScoreManager>();
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.P))
        {
            options.PauseGame();
        }

    }

    public void Dead()
    {
        theScoreManager.scoreIncreasing = false;
        theplayer.gameObject.SetActive(false);
    }

    public void RestartGame()
    {
        StartCoroutine("RestartGameCo");
    }

    public IEnumerator RestartGameCo()
    {
        yield return new WaitForSeconds(0.5f);
        theplayer.gameObject.SetActive(true);
        deadMenu.gameObject.SetActive(false);

        theScoreManager.scoreCount = 0;
        theScoreManager.scoreIncreasing = true;
    }

}

