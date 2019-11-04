using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class gameManager : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("ZombieShooterLevel1");
    }
    public void EndGame()
    {
        //SceneManager.LoadScene("Game Over");
    }
    public void BackToMainMenu()
    {
        //SceneManager.LoadScene("Main Menu");
    }
    public void QuitGame()
    {
        Application.Quit();  
    }
}