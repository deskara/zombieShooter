using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class inventoryScript : MonoBehaviour
{
    public UnityEvent showInventory;
    public UnityEvent hideInventory;
    public Text actionUndertaken;
    public Text weaponName;
    public Text numOfWeapon;
    private bool inventoryShown = false;
    private string currentWeapon = "defaultGun";
    // Update is called once per frame
    void Start()
    {
        displayNumOfWeapons();
        displayWeaponName();

    }
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
    private void displayNumOfWeapons()
    {
        if(currentWeapon == "defaultGun")
        {
            numOfWeapon.text = string.Format("You have {0} of these",PlayerPrefs.GetInt("numOfDefaultGuns"));
        }
        else if (currentWeapon == "piercingRifle")
        {
            numOfWeapon.text = string.Format("You have {0} of these", PlayerPrefs.GetInt("numOfPiercingRifles"));
        }
    }
    private int getCurrentNumOfWeapons()
    {
        if (currentWeapon == "defaultGun")
        {
            return PlayerPrefs.GetInt("numOfDefaultGuns");
        }
        else if (currentWeapon == "piercingRifle")
        {
            return PlayerPrefs.GetInt("numOfPiercingRifles");
        }
        else
        {
            return 0;
        }

    }
    private void displayWeaponName()
    {
        if (currentWeapon == "defaultGun")
        {
            weaponName.text = "defaultWeapon";
        }
        else if (currentWeapon == "piercingRifle")
        {
            weaponName.text = "Piercing Rifle";
        }

    }
    public void nextWeapon()
    {
        if(currentWeapon == "defaultGun")
        {
            if(PlayerPrefs.GetInt("numOfPiercingRifles") > 0)
            {
                currentWeapon = "piercingRifle";
                displayNumOfWeapons();
                displayWeaponName();
            }
            else
            {
                actionUndertaken.text = "You don't have any other weapons";
            }
        }
        else if (currentWeapon == "piercingRifle")
        {
            currentWeapon = "defaultGun";
            displayNumOfWeapons();
            displayWeaponName();
        }
        else
        {
            actionUndertaken.text = "An invalid weapon error occurred, please report this.";

        }

    }
    public void equipLeft()
    {
        if(getCurrentNumOfWeapons() > 1)
        {
            PlayerPrefs.SetString("equippedLeftWeapon", currentWeapon);
            actionUndertaken.text = string.Format("You have equipped your {0} into your left hand",currentWeapon);
        }
        else
        {
            if( PlayerPrefs.GetString("equippedRightWeapon") == currentWeapon)
            {
                PlayerPrefs.SetString("equippedLeftWeapon", currentWeapon);
                PlayerPrefs.SetString("equippedRightWeapon", "defaultGun");
                actionUndertaken.text = string.Format("You have moved your {0} into your left hand putting a defaultgun into your right hand.", currentWeapon);

            }
            else
            {
                PlayerPrefs.SetString("equippedLeftWeapon", currentWeapon);
                actionUndertaken.text = string.Format("You have equipped your {0} into your left hand", currentWeapon);

            }
        }


    }
    public void equipRight()
    {
        if (getCurrentNumOfWeapons() > 1)
        {
            PlayerPrefs.SetString("equippedRightWeapon", currentWeapon);
            actionUndertaken.text = string.Format("You have equipped your {0} into your right hand", currentWeapon);
        }
        else
        {
            if (PlayerPrefs.GetString("equippedLeftWeapon") == currentWeapon)
            {
                PlayerPrefs.SetString("equippedRightWeapon", currentWeapon);
                PlayerPrefs.SetString("equippedLeftWeapon", "defaultGun");
                actionUndertaken.text = string.Format("You have moved your {0} into your right hand putting a defaultgun into your left hand.", currentWeapon);

            }
            else
            {
                PlayerPrefs.SetString("equippedRightWeapon", currentWeapon);
                actionUndertaken.text = string.Format("You have equipped your {0} into your right hand", currentWeapon);

            }
        }

    }
}
