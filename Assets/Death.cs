using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Death : MonoBehaviour
{
    public int health = 100;
    public GameObject deathEffect;
    // private static int _deadPlayers = 0;

    public void TakeDamage(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Instantiate(deathEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
        ScoreTextScript.coinAmount -= 15;
        FindObjectOfType<Lives>().LoseLife();
        // _deadPlayers++;
        // if (_deadPlayers == 2)
        // {
        // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        //     _deadPlayers = 0;
        // }
    }
}