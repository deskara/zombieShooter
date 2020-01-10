using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class shopScript : MonoBehaviour
{
    public UnityEvent playerCollided;
    //This script works alongside the playerCollisions script to have an event occur when the player collides with a shopkeeper.
    //This event is used to make the shop menus open.
    public void showShopDialogue()
    {
        playerCollided.Invoke();
    }
}
