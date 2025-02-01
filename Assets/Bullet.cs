using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 7f;
    public static int damage = 20;
    public Rigidbody2D rb;
    public GameObject audioEffect;
    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.right * speed;
    }

    public static void IncreaseDamage(int delta)
    {
        damage += delta;
    }

    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        Enemy enemy = hitInfo.GetComponent<Enemy>();
        if (enemy != null)
        {
            enemy.TakeDamage(damage);
        }
        Destroy(gameObject);
        Instantiate(audioEffect, transform.position, Quaternion.identity);
    }
}
