using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class tutorialEvents : MonoBehaviour
{
    public UnityEvent playerMoved;
    public UnityEvent playerShot;
    GameObject player = GameObject.FindWithTag("Player");
    Transform initialPosition;
    private void Start()
    {
        initialPosition = player.transform;

    }

    // Update is called once per frame
    void Update()
    {
        
        if(Input.GetMouseButton(0) | Input.GetMouseButton(1))
        {
            playerShot.Invoke();
        }

        if (initialPosition != player.transform)
        {
            playerMoved.Invoke();
        }
        
    }
}
