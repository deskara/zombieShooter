using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//This script handles purchasing upgrades
public class upgradeScript : MonoBehaviour
{
    public Text damageUpgradeCost;
    public Text coinText;
    public Text vendorDialogue;
    void Start()
    {
        //This sets the text to have the current cost of the upgrade.
        damageUpgradeCost.text = string.Format("Costs: {0}", (PlayerPrefs.GetInt("damage") * 5));
    }
    //This is called by a button.
    public void purchaseDamageUpgrade()
    {
        //If the player has enough money
        if(PlayerPrefs.GetInt("Coins") >= PlayerPrefs.GetInt("damage") * 5)
        {
            PlayerPrefs.SetInt("Coins",PlayerPrefs.GetInt("Coins") - (PlayerPrefs.GetInt("damage") * 5));
            PlayerPrefs.SetInt("damage", PlayerPrefs.GetInt("damage") + 1);
            coinText.text = string.Format("Coins: {0}",PlayerPrefs.GetInt("Coins"));
            damageUpgradeCost.text = string.Format("Costs: {0}", (PlayerPrefs.GetInt("damage") * 5));
            GetComponent<AudioSource>().Play();
            vendorDialogue.text = "Thanks for your purchase.";
        }
        //Otherwise
        else
        {
            //No purchase is made
            damageUpgradeCost.text = string.Format("Costs: {0}", (PlayerPrefs.GetInt("damage") * 5));
            //And the player is notified that they lack the money needed.
            vendorDialogue.text = "You don't have enough money for that.";


        }
    }
}
