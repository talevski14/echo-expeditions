using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StoreScript : MonoBehaviour
{
    public GameObject storePanel; // Assign in Inspector
    public Button openStoreButton;
    public Button closeButton;

    void Start() {
        storePanel.SetActive(false); // Hide store initially
        openStoreButton.onClick.AddListener(OpenStore);
        closeButton.onClick.AddListener(CloseStore);
    }

    void OpenStore()
    {
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
}
