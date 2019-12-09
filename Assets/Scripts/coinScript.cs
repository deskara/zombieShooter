using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class coinScript : MonoBehaviour
{

    public UnityEvent coinPickedUp;
    GameObject Canvas;
    private void Start()
    {
        Canvas = GameObject.FindWithTag("Canvas");
        
    }
    public void pickUp()
    {
        Canvas.GetComponent<battleUI>().UpdateCoins(1);
        Destroy(gameObject);
    }
}
