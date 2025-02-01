using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon2 : MonoBehaviour
{
    public Transform FirePoint2;
    public GameObject BulletPrefab;
    public GameObject IncreasedDamageBulletPrefab;
    public static bool canShoot = true;
    public static bool increasedDamageBullet = false;


    // Update is called once per frame
    void Update()
    {
        if (!canShoot) return;
        if (Input.GetButtonDown("Fire2"))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        if (increasedDamageBullet)
        {
            Instantiate(IncreasedDamageBulletPrefab, FirePoint2.position, FirePoint2.rotation);
        }
        else
        {
            Instantiate(BulletPrefab, FirePoint2.position, FirePoint2.rotation);
        }    }

    public static void SetShooting(bool value)
    {
        canShoot = value;
    }

    public static void IncreaseDamageOnBullet(bool value)
    {
        increasedDamageBullet = value;
    }
}
