using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class playerDeathHandler : MonoBehaviour
{
    public UnityEvent mousePressed;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) | Input.GetMouseButtonDown(1))
        {
            Time.timeScale = 1;
            mousePressed.Invoke();


        }
        
    }
}
