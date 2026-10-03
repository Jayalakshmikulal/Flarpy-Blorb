using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class LogicScript : MonoBehaviour
{
   public int playerScore;
   public Text scoreText;
   public GameObject gameOverScreen;
   private bool isGameOver;

   [ContextMenu("Increase Score")]
   public void addScore(int scoreToAdd)
    {
        if (isGameOver)
        {
            return;
        }

        playerScore = playerScore + scoreToAdd;
        scoreText.text =  playerScore.ToString();
    }  
     public void restartGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
     public void gameOver()
    {
        if (isGameOver)
        {
            return;
        }

        isGameOver = true;
        Time.timeScale = 0f;
        gameOverScreen.SetActive(true);
    }
}
