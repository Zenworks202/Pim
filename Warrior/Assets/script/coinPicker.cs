using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class coinPicker : MonoBehaviour
{
    private float coins = 0;
    public TMP_Text coinsText;
    public TMP_Text coinsTextHH;

    
   
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Coin")
        {
            coins ++;
            coinsText.text = coins.ToString();
            coinsTextHH.text = coins.ToString();
            Destroy(collision.gameObject);
        }
    }
}
