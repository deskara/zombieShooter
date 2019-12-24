﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletScript : MonoBehaviour
{
    //These provide base values for the speed and damage of bullets.
    public float moveSpeed = 250.0f;
    public float damage = 1;
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
    private void OnTriggerEnter2D(Collider2D other)
    {
        //This makes the other entity run the "take damage" method
        other.transform.SendMessage("TakeDamage", damage, SendMessageOptions.DontRequireReceiver);
        //Afterwards the bullet will be destroyed
        Die();
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