using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool isGameFinish = false;
    [SerializeField]
    float DelayForNextScence = 1.0f;

    public void EndGame()
    {
        if (isGameFinish == false)
        {
            Debug.Log("GameOver");
            isGameFinish = true;
            Invoke("moveToGameOverScence", DelayForNextScence);
        }
    }

    void moveToGameOverScence()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
