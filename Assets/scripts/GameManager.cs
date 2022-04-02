using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public float delaytime = 1f;
    bool GameRun = true;
    public GameObject LevelComplete;
    public void GameOver()
    {
        if (GameRun)
        {
            //Debug.Log("Khatam,Finish");
            GameRun = false;
            Invoke("Restart", delaytime);

        }
    }
    public void end()
    {

        
    }
    public void Ui()
    {

        LevelComplete.SetActive(true);
    }
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
   
}
