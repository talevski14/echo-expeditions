using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GivesDamage : MonoBehaviour
{
    public int damage = 100;
    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        Death enemy = hitInfo.GetComponent<Death>();
        if (enemy != null)
        {
            enemy.TakeDamage(damage);
        }
    }
}
