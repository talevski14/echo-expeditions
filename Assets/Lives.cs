using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Lives : MonoBehaviour
{
    public static int lives = 3;
    public Image[] heartImages;
    public string gameOverScene = "GameOver";
    public static int lastScore = 0;
    
    void Start()
    {
        UpdateHearts();
    }

    void Update()
    {
        UpdateHearts();
        lastScore = ScoreTextScript.coinAmount;
    }

    public void LoseLife()
    {
        lives--;

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

    public static void BuyLife()
    {
        lives++;
        if (lives >= 3)
        {
            lives = 3;
        }
    }
}
