using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
//This script handles ensuring that the coins can be picked up and the changes are displayed to the user.
public class coinScript : MonoBehaviour
{

    public UnityEvent coinPickedUp;
    GameObject Canvas;
    GameObject coinSoundObject;
    private void Start()
    {
        Canvas = GameObject.FindWithTag("Canvas");
        coinSoundObject = GameObject.FindWithTag("coinSound");

    }
    public void pickUp()
    {
        Canvas.GetComponent<battleUI>().UpdateCoins(1);
        coinSoundObject.GetComponent<AudioSource>().Play();
        Destroy(gameObject);
    }
}
