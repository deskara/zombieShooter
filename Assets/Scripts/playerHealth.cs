using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
[System.Serializable]
public class OnPlayerDamagedEvent : UnityEvent<int> { }

public class playerHealth : MonoBehaviour
{
    public OnPlayerDamagedEvent onDamaged;
    public UnityEvent onDie;

    public delegate void UpdateHealth(int newHealth);
    public static event UpdateHealth OnUpdateHealth;
    public int health = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void TakeDamage(int damage)
    {
        Debug.Log("An attempt to make the player take damage was made");
        onDamaged.Invoke(health);
        health -= damage;
        if (health <= 0)
        {
            onDie.Invoke();
            Debug.Log("Guess you're undead...");
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
