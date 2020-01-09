using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hurtTrigger : MonoBehaviour
{
    //Damage determines how much damage the player takes per hit
    public int damage;
    //resetTime determines how long it takes before the player can get hit again.
    public float resetTime = 0.25f;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //When a collision occurs the player takes damage and the collider is disabled to prevent further collisions for a time
        collision.transform.SendMessage("TakeDamage", damage, SendMessageOptions.DontRequireReceiver);
        GetComponent<Collider2D>().enabled = false;
        Invoke("ResetTrigger", resetTime);
    }
    private void ResetTrigger()
    {
        //After the resetTime window is up the player can get hit again by the same collider.
        GetComponent<Collider2D>().enabled = true;
    }
}
