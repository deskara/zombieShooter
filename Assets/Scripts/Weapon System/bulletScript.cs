using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletScript : MonoBehaviour
{
    //These provide base values for the speed and damage of bullets.
    public float moveSpeed = 250.0f;
    public float damage = 1;
    public string bulletType = "standard";
    private void Start()
    {
        //damage = PlayerPrefs.GetInt("damage");
        //This gets the rigidbody component and adds force to it
        GetComponent<Rigidbody2D>().AddForce(transform.up * moveSpeed);
    }
    public void setDamage(float newDamage)
    {
        damage = newDamage;
    }
    public void setMoveSpeed(float newMoveSpeed)
    {
        moveSpeed = newMoveSpeed;
    }
    public void setType(string newType)
    {
        bulletType = newType;
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        //This makes the other entity run the "take damage" method
        other.transform.SendMessage("TakeDamage", damage, SendMessageOptions.DontRequireReceiver);
        if (bulletType != "piercing"){
            Debug.Log(bulletType + " shot destroyed");
            //Afterwards the bullet will be destroyed
            //If it is not a piercing shot
            Die();


        }

    }
    //This destroys the game object when it is off-screen
    private void OnBecameInvisible()
    {
        Die();
    }
    private void Die()
    {
        //The die method destroys the gameObject. In this case it will destroy the bullet.
        Destroy(gameObject);
    }
}
