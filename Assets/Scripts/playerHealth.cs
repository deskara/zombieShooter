using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
//This script handles outputting the player's health to the UI
//and also handles having the player take damage
[System.Serializable]
public class OnPlayerDamagedEvent : UnityEvent<int> { }

public class playerHealth : MonoBehaviour
{
    public OnPlayerDamagedEvent onDamaged;
    public UnityEvent onDie;

    public delegate void UpdateHealth(int newHealth);
    public static event UpdateHealth OnUpdateHealth;
    public int health = 10;
    public void TakeDamage(int damage)
    {
        Debug.Log("An attempt to make the player take damage was made");
        onDamaged.Invoke(health);
        health -= damage;
        if (health <= 0)
        {
            onDie.Invoke();
            //Debug.Log("Guess you're undead...");
        }
    }
    public void SendHealthData(int health)
    {
        if (OnUpdateHealth != null)
        {
            OnUpdateHealth(health);
        }
    }

}
