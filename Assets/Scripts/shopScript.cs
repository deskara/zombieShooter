using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class shopScript : MonoBehaviour
{
    public UnityEvent playerCollided;
    public void showShopDialogue()
    {
        playerCollided.Invoke();
    }
}
