using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//This script handles changing the scenes or exiting the game.
public class gameManager : MonoBehaviour
{
    public void StartGame()
    {
        PlayerPrefs.SetInt("damage", 1);
        PlayerPrefs.SetInt("Coins", 0);
        PlayerPrefs.SetInt("Score", 0);
        PlayerPrefs.SetInt("daysSurvived",0);
        Time.timeScale = 1;
        SceneManager.LoadScene("ZombieShooterLevel1");
    }
    public void resumeGame()
    {
        SceneManager.LoadScene("homeBase");

    }
    public void backToCombat()
    {
        SceneManager.LoadScene("ZombieShooterLevel1");

    }
    public void EndGame()
    {
        SceneManager.LoadScene("GameOver");
    }
    public void StartTutorial()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Tutorial");
    }
    public void BackToMainMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("MainMenu");
    }
    public void BackToMainMenuDeath()
    {
        PlayerPrefs.SetInt("damage", 1);
        PlayerPrefs.SetInt("Coins", 0);
        PlayerPrefs.SetInt("Score", 0);
        PlayerPrefs.SetInt("daysSurvived", 0);
        Time.timeScale = 1;
        SceneManager.LoadScene("MainMenu");
    }
    public void goToHomeBase()
    {
        PlayerPrefs.SetInt("daysSurvived", PlayerPrefs.GetInt("daysSurvived")+1);
        SceneManager.LoadScene("homeBase");
    }
    public void QuitGame()
    {
        Application.Quit();  
    }
}
