using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class inventoryScript : MonoBehaviour
{
    public UnityEvent showInventory;
    public UnityEvent hideInventory;
    private bool inventoryShown = false;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("i"))
        {
            if(inventoryShown == false)
            {
                showInventory.Invoke();
                inventoryShown = true;

            }
            else
            {
                hideInventory.Invoke();
                inventoryShown = false;
            }

        }
    }
}
