using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class MainMenu : MonoBehaviour
{    
    private ScoreManager scoreManager;

    private void Awake()
    {
        GameLoader.CallOnComplete(Initialize);
    }

    private void Initialize()
    {
        scoreManager = FindObjectOfType<ScoreManager>();        
    }

    public void PlayWorkingLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void PlayControlLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }

    public void PlayEngineLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);
    }

    public void PracticeMode()
    {
        if (!scoreManager.PracticeMode)
            scoreManager.PracticeMode = true;
        else
            scoreManager.PracticeMode = false;
    }
    

    public void QuitGame()
    {
        Debug.Log("QUIT");
        Application.Quit();
    }
}
