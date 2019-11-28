using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinScript : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        collision.transform.SendMessage("pickupCoin", SendMessageOptions.DontRequireReceiver);
        Destroy(gameObject);

    }
}
