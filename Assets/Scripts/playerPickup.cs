using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerPickup : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //This makes the other entity run the "pickUp" method
        collision.transform.SendMessage("pickUp", SendMessageOptions.DontRequireReceiver);

    }
}
