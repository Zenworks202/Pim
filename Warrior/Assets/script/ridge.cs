using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class ridge: MonoBehaviour
{
    private float coins = 0;
    public TMP_Text coinsText;
    public TMP_Text coinsTextPP;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Ridge")
        {
            coins++;
            coinsText.text = coins.ToString();
            coinsTextPP.text = coins.ToString();
            Destroy(collision.gameObject);
        }
    }
}
