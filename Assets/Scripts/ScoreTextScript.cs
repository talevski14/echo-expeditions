using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreTextScript : MonoBehaviour
{
    TextMesh text;
    public static int coinAmount;
    
    // Start is called before the first frame update
    void Start()
    {
        coinAmount = Lives.lastScore;
        text = GetComponent<TextMesh>();
    }

    // Update is called once per frame
    void Update()
    {
        if (coinAmount < 0)
        {
            coinAmount = 0;
        }
        text.text = coinAmount.ToString();
    }
}
