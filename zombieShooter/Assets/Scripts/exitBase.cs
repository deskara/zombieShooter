using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class exitBase : MonoBehaviour
{
    public UnityEvent baseExited;
    public void baseExitTouched()
    {
        baseExited.Invoke();
    }
}
