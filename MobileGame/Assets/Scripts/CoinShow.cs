using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinShow : MonoBehaviour
{
    public Text coin;
    // Start is called before the first frame update
    void Start()
    {
        coin.text = "  " + PlayerPrefs.GetInt("Coin", 0).ToString();
    }


}
