using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class coinScript : MonoBehaviour
{
    public int coins = 0;
    public UnityEvent coinPickedUp;
    public void pickUp()
    {
        coins += 1;
        coinPickedUp.Invoke();


        Destroy(gameObject);
    }
}
