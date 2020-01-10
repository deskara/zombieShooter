using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class topDownCharacterController2D : MonoBehaviour
{
    public float speed = 5.0f;
    Rigidbody2D rigidbody2D;
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        //This makes the player move upon pressing the arrow keys or WASD.
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        //Speed is influenced by how high speed is set.
        rigidbody2D.velocity = new Vector2(x, y) * speed;
        rigidbody2D.angularVelocity = 0.0f;
    }
}
