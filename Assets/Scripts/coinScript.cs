using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class coinScript : MonoBehaviour
{

    public UnityEvent coinPickedUp;
    public void pickUp()
    {
        coinPickedUp.Invoke();
        Destroy(gameObject);
    }
}
