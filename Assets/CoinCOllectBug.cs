using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CoinCOllectBug : MonoBehaviour
{
    private int coin;

    private TextMeshProUGUI scoreText;
    void Start()
    {
        //coin = 0;
    }

    private void OnTriggerEnter2D(Collider2D collision) 
    {
        
        if(collision.gameObject.tag =="CoinCollectedBug")
        {
            print(coin);
            coin++;
            scoreText.text = "Coin =" + coin;
            print(coin);
        }
    }
}
