using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StoreScript : MonoBehaviour
{
    public GameObject storePanel;
    public GameObject message;
    public Button openStoreButton;
    public Button closeButton;
    public Button buyBulletsButton;
    public int bulletPrice = 20;
    public int damage = 20;

    void Start() {
        storePanel.SetActive(false);
        message.SetActive(false);
        openStoreButton.onClick.AddListener(OpenStore);
        closeButton.onClick.AddListener(CloseStore);
        buyBulletsButton.onClick.AddListener(BuyBullets);
    }

    void OpenStore()
    {
        message.SetActive(false);
        storePanel.SetActive(true);
        PlayerMovement.SetMovement(false);
        PlayerMovement2.SetMovement(false);
        Weapon.SetShooting(false);
        Weapon2.SetShooting(false);
    }

    void CloseStore()
    {
        storePanel.SetActive(false);
        PlayerMovement.SetMovement(true);
        PlayerMovement2.SetMovement(true);
        Weapon.SetShooting(true);
        Weapon2.SetShooting(true);
    }

    void BuyBullets()
    {
        if (ScoreTextScript.coinAmount >= bulletPrice)
        {
            ScoreTextScript.coinAmount -= bulletPrice;
            Bullet.IncreaseDamage(damage);
            Weapon.IncreaseDamageOnBullet(true);
            Weapon2.IncreaseDamageOnBullet(true);
        }
        else
        {
            message.SetActive(true);
        }
    }
}
