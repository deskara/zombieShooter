using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//This script handles changing the scenes or exiting the game.
public class gameManager : MonoBehaviour
{
    public void StartGame()
    {
        resetStoredValues();
        unpauseGame();
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
        unpauseGame();
        SceneManager.LoadScene("Tutorial");
    }
    public void BackToMainMenu()
    {
        unpauseGame();
        SceneManager.LoadScene("MainMenu");
    }
    public void BackToMainMenuDeath()
    {
        resetStoredValues();
        unpauseGame();
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
    public void pauseGame()
    {
        Time.timeScale = 0;
    }
    public void unpauseGame()
    {
        Time.timeScale = 1;

    }
    public void resetStoredValues()
    {
        PlayerPrefs.SetInt("damage", 1);
        PlayerPrefs.SetInt("Coins", 0);
        PlayerPrefs.SetInt("Score", 0);
        PlayerPrefs.SetInt("daysSurvived", 0);
        PlayerPrefs.SetInt("numOfPiercingRifles", 0);

    }
}
