using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class topDownCharacterController2D : MonoBehaviour
{
    public float speed = 5.0f;
    Rigidbody2D rigidbody2D;
    //public GameObject playerBullet;
    //public float bulletSpeed = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        rigidbody2D.velocity = new Vector2(x, y) * speed;
        rigidbody2D.angularVelocity = 0.0f;
        //This is the old bullet shooting code.
        //if (Input.GetButtonDown("Fire1"))
        //{
         //   
          //  GameObject bullet = Instantiate(playerBullet, transform.position, transform.rotation);
           // bullet.transform.Rotate(0, 0, 180);
           // bullet.GetComponent<Rigidbody2D>().AddForce(transform.up * bulletSpeed);
           // 
           // Destroy(bullet, 3);
        //}
    }
}
