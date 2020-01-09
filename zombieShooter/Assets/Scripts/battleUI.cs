using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//This script handles the UI during Battles
public class battleUI : MonoBehaviour
{
    public Slider healthBar;
    public Text scoreText;
    public int playerScore = 0;
    public int playerCoins = 0;
    public Text coinText;
    private void OnEnable()
    {
        playerCoins = PlayerPrefs.GetInt("Coins");
        playerScore = PlayerPrefs.GetInt("Score");
        coinText.text = "Coins: " + playerCoins.ToString();
        scoreText.text = "SCORE: " + playerScore.ToString();
        playerHealth.OnUpdateHealth += UpdateHealthBar;
        addScore.OnSendScore += UpdateScore;
    }
    private void OnDisable()
    {
        playerHealth.OnUpdateHealth -= UpdateHealthBar;
        addScore.OnSendScore -= UpdateScore;
        PlayerPrefs.SetInt("Score", playerScore);
        PlayerPrefs.SetInt("Coins", playerCoins);
    }

    private void UpdateHealthBar(int health)
    {
        healthBar.value = health;
    }
    private void UpdateScore(int theScore)
    {
        playerScore += theScore;
        scoreText.text = "SCORE: " + playerScore.ToString();
    }
    public void UpdateCoins(int AdditionalCoins)
    {
        playerCoins += AdditionalCoins;
        coinText.text = "Coins: " + playerCoins.ToString();

        
    }
}