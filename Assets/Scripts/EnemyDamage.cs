using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    public int health = 100;
    public GameObject deathEffect;
    public void Damaged(int damage)
    {
        health -= damage;
        if (health <= null)
        {
            Instantiate(deathEffect, transform.position, Quaternion.identity);
        }

    }
}
