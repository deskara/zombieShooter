using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class enterBase : MonoBehaviour
{
    public UnityEvent playerInBase;
    private bool recentlyEntered = false;
    private float resetTime = 5.0f;
    public void baseEntered()
    {
        if(recentlyEntered == false)
        {
            recentlyEntered = true;
            playerInBase.Invoke();
            Invoke("resetCollider", resetTime);

        }


    }
    private void resetCollider()
    {
        recentlyEntered = false;
    }
}
