using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class tutorialEvents : MonoBehaviour
{
    public Slider healthBar;
    public UnityEvent playerMoved;
    public UnityEvent playerShot;
    public UnityEvent FirstStepsCompleted;
    public UnityEvent TutorialComplete;
    bool zombieDefeated = false;
    GameObject player; 
    Vector3 initialPosition;
    bool shotCheck = false, movedCheck = false;
    private void Start()
    {
        player = GameObject.FindWithTag("Player");
        initialPosition = player.transform.localPosition;
        playerHealth.OnUpdateHealth += UpdateHealthBar;


    }
    private void UpdateHealthBar(int health)
    {
        healthBar.value = health;
    }

 
    void FixedUpdate()
    {
        
        if(Input.GetMouseButton(0) | Input.GetMouseButton(1) && shotCheck == false)
        {
            playerShot.Invoke();
            shotCheck = true;
        }

        if (initialPosition != player.transform.localPosition && movedCheck == false)
        {
            playerMoved.Invoke();
            movedCheck = true;
        }

        if (movedCheck == true && shotCheck == true && zombieDefeated == false)
        {
            FirstStepsCompleted.Invoke();

        }
        if (zombieDefeated == true)
        {
            TutorialComplete.Invoke();
        }
        
    }
    public void setZombieDefeated()
    {
        zombieDefeated = true;
    }
}
