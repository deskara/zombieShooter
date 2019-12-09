using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//This script handles changing the scenes or exiting the game.
public class gameManager : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("ZombieShooterLevel1");
    }
    public void EndGame()
    {
        PlayerPrefs.SetInt("Coins", 0);
        SceneManager.LoadScene("GameOver");
    }
    public void StartTutorial()
    {
        SceneManager.LoadScene("Tutorial");
    }
    public void BackToMainMenu()
    {
        PlayerPrefs.SetInt("Coins", 0);
        PlayerPrefs.SetInt("Score", 0);
        Time.timeScale = 1;
        SceneManager.LoadScene("MainMenu");
    }
    public void goToHomeBase()
    {
        SceneManager.LoadScene("homeBase");
    }
    public void QuitGame()
    {
        PlayerPrefs.SetInt("Coins", 0);
        PlayerPrefs.SetInt("Score", 0);
        Application.Quit();  
    }
}
