using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class tutorialEvents : MonoBehaviour
{
    public UnityEvent playerMoved;
    public UnityEvent playerShot;
    public UnityEvent FirstStepsCompleted;
    GameObject player; 
    Vector3 initialPosition;
    bool shotCheck = false, movedCheck = false;
    private void Start()
    {
        player = GameObject.FindWithTag("Player");
        initialPosition = player.transform.localPosition;


    }

    // Update is called once per frame
    void Update()
    {
        
        if(Input.GetMouseButton(0) | Input.GetMouseButton(1) && shotCheck == false)
        {
            playerShot.Invoke();
            shotCheck = true;
        }

        if (initialPosition != player.transform.localPosition && movedCheck == false)
        {
            playerMoved.Invoke();
            movedCheck = true;
        }

        if (movedCheck == true && shotCheck == true)
        {
            FirstStepsCompleted.Invoke();

        }
        
    }
}
