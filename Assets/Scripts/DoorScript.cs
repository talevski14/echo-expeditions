using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class DoorScript : MonoBehaviour
{
    public int index;
    private int _playersInTrigger = 0;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            _playersInTrigger++;

            if (_playersInTrigger == 2)
            {
                SceneManager.LoadScene(index);
            }
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            _playersInTrigger--;

            if (_playersInTrigger < 0)
            {
                _playersInTrigger = 0;
            }
        }
    }
}
