using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerCollisions : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //This makes the other entity run the "pickUp" method if it has it
        collision.transform.SendMessage("pickUp", SendMessageOptions.DontRequireReceiver);
        //This makes the other entity run the "enterBase method if it has it
        collision.transform.SendMessage("baseEntered", SendMessageOptions.DontRequireReceiver);

        collision.transform.SendMessage("baseExitTouched", SendMessageOptions.DontRequireReceiver);

        collision.transform.SendMessage("showShopDialogue", SendMessageOptions.DontRequireReceiver);

    }
}
