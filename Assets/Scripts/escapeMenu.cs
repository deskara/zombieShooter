using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class escapeMenu : MonoBehaviour
{
    //This script is used for menus during gameplay.
    public UnityEvent addMenu,removeMenu;
    bool currentMenuStatus = false;
    float baseTime;
    void Start()
    {
        baseTime = Time.timeScale;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("escape"))
        {
            if (currentMenuStatus == false){
                addMenu.Invoke();
                currentMenuStatus = true;
                pause();
            }
            else
            {
                removeMenu.Invoke();
                currentMenuStatus = false;
                unpause();
            }

        }
        
    }
    public void pause()
    {
        Time.timeScale = 0;
    }
    public void unpause()
    {
        Time.timeScale = baseTime;
    }
}
