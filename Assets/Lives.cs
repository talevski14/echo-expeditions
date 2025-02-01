using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Lives : MonoBehaviour
{
    public static int lives = 3; // Number of lives
    public Image[] heartImages; // UI heart images
    public string gameOverScene = "GameOver"; // Scene to load on game over
    public static int lastScore = 0;
    
    void Start()
    {
        UpdateHearts();
    }

    public void LoseLife()
    {
        lives--;
        lastScore = ScoreTextScript.coinAmount;

        if (lives <= 0)
        {
            SceneManager.LoadScene(gameOverScene);
        }
        else
        {
            UpdateHearts();
            Invoke(nameof(RestartLevel), 1f);
        }
    }

    void UpdateHearts()
    {
        for (int i = 0; i < heartImages.Length; i++)
        {
            heartImages[i].enabled = i < lives;
        }
    }

    void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
