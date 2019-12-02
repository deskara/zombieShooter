using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class enterBase : MonoBehaviour
{
    public UnityEvent playerInBase;
    public void baseEntered()
    {
        playerInBase.Invoke();

    }
}
