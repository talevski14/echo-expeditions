using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScript : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene(1);
        Lives.lives = 3;
        ScoreTextScript.coinAmount = 0;
        Lives.lastScore = 0;
        StoreScript.alreadyBoughtBullets = false;
        Weapon.IncreaseDamageOnBullet(false);
        Weapon2.IncreaseDamageOnBullet(false);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
