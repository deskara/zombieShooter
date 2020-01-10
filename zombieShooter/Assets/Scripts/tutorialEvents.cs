using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
//This script handles the messages during the tutorial
public class tutorialEvents : MonoBehaviour
{
    public Slider healthBar;
    public UnityEvent FirstStepsCompleted;
    public UnityEvent SecondStepsComplete;
    public Text tutorialText;
    bool zombieDefeated = false;
    bool baseEntered = false;
    bool zombieDamaged = false;
    bool playerHit = false, playerLethalDamage = false;
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
        //Once the player shoots
        if(Input.GetMouseButton(0) | Input.GetMouseButton(1) && shotCheck == false)
        {
            shotCheck = true;
            //The notification to shoot is removed
            tutorialText.text = "Use the arrow keys to move";
        }
        //Once the player moves
        else if (initialPosition != player.transform.localPosition && movedCheck == false)
        {
            movedCheck = true;
            //The notification to move is removed.
            tutorialText.text = "Use the mouse to shoot.";
        }
        //Once the player has both moved and shot
        else if (movedCheck == true && shotCheck == true && zombieDefeated == false && playerHit == false && zombieDamaged == false)
        {
            //A zombie is enabled through the event
            FirstStepsCompleted.Invoke();
            //And new instructions are given
            tutorialText.text = "To damage zombies aim using the mouse and click to fire." + System.Environment.NewLine +
                "If a zombie gets too close you will get damaged. So try to move away if they get too close." + System.Environment.NewLine +
                "Zombies will spawn at graves";

        }
        else if(playerHit == true && zombieDefeated == false && playerLethalDamage == false)
        {
            tutorialText.text = "You got hit!" + System.Environment.NewLine +
"Try to keep your distance while firing.";
        }
        else if(playerLethalDamage == true && zombieDefeated == false)
        {
            tutorialText.text = "If this weren't the tutorial your character would be dead." + System.Environment.NewLine +
"Try to keep your distance while shooting.";
        }
        else if(zombieDamaged == true && zombieDefeated == false && playerHit == false)
        {
            tutorialText.text = "Nice, continue firing until the zombie is defeated";

        }
        else if (zombieDefeated == true && baseEntered == false)
        {
            tutorialText.text = "When playing you can heal by entering the base" + System.Environment.NewLine +
                "You can also get upgrades and equipment there.";
            SecondStepsComplete.Invoke();
        }
        else if (zombieDefeated == true && baseEntered == true)
        {
            tutorialText.text = "You've completed the tutorial." + System.Environment.NewLine +
"Press escape when you wish to exit.";
        }
        
    }
    public void setZombieDamaged()
    {
        zombieDamaged = true;
    }
    public void setZombieDefeated()
    {
        zombieDefeated = true;
    }
    public void setBaseEntered()
    {
        baseEntered = true;
    }
    public void setPlayerHit()
    {
        playerHit = true;
    }
    public void setPlayerLethalDamage()
    {
        playerLethalDamage = true;
    }
}
