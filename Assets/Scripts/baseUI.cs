using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class baseUI : MonoBehaviour
{
    public int playerCoins = 0;
    public Text coinText;
    private void OnEnable()
    {
        playerCoins = PlayerPrefs.GetInt("Coins");
        coinText.text = "Coins: " + playerCoins.ToString();
    }
    public void UpdateCoins(int AdditionalCoins)
    {
        playerCoins += AdditionalCoins;
        coinText.text = "Coins: " + playerCoins.ToString();
        PlayerPrefs.SetInt("Coins", playerCoins);

    }
}
