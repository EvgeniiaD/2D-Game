using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButtons : MonoBehaviour {

    public void LoadScene(string nameScene)
    {
        SceneManager.LoadScene(nameScene);
        Debug.Log("Load");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
