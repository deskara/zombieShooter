using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class escapeMenu : MonoBehaviour
{
    public UnityEvent addMenu,removeMenu;
    bool currentMenuStatus = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("escape"))
        {
            if (currentMenuStatus == false){
                addMenu.Invoke();
                currentMenuStatus = true;
            }
            else
            {
                removeMenu.Invoke();
                currentMenuStatus = false;
            }

        }
        
    }
}
