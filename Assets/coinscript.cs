using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinscript : MonoBehaviour
{
    public GameObject coinAudio;
    void OnTriggerEnter2D(Collider2D collision)
    {
        ScoreTextScript.coinAmount += 3;
        Destroy(gameObject);
        Instantiate(coinAudio, transform.position, Quaternion.identity);
    }
}
