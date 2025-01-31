using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Transform FirePoint1;
    public GameObject BulletPrefab;
    public static bool canShoot = true;

    // Update is called once per frame
    void Update()
    {
        if (!canShoot) return;
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        Instantiate(BulletPrefab, FirePoint1.position, FirePoint1.rotation);
    }
    
    public static void SetShooting(bool value)
    {
        canShoot = value;
    }
}
