using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class battleUI : MonoBehaviour
{
    public Slider healthBar;
    public Text scoreText;
    public int playerScore = 0;
    private void OnEnable()
    {
        playerHealth.OnUpdateHealth += UpdateHealthBar;
        addScore.OnSendScore += UpdateScore;
    }
    private void OnDisable()
    {
        playerHealth.OnUpdateHealth -= UpdateHealthBar;
        addScore.OnSendScore -= UpdateScore;
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
}