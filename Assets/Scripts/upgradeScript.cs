using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class upgradeScript : MonoBehaviour
{
    public Text damageUpgradeCost;
    public Text coinText;
    public Text vendorDialogue;
    // Start is called before the first frame update
    void Start()
    {

        damageUpgradeCost.text = string.Format("Costs: {0}", (PlayerPrefs.GetInt("damage") * 5));



    }

    public void purchaseDamageUpgrade()
    {
        if(PlayerPrefs.GetInt("Coins") >= PlayerPrefs.GetInt("damage") * 5)
        {
            PlayerPrefs.SetInt("Coins",PlayerPrefs.GetInt("Coins") - (PlayerPrefs.GetInt("damage") * 5));
            PlayerPrefs.SetInt("damage", PlayerPrefs.GetInt("damage") + 1);
            coinText.text = string.Format("Coins: {0}",PlayerPrefs.GetInt("Coins"));
            damageUpgradeCost.text = string.Format("Costs: {0}", (PlayerPrefs.GetInt("damage") * 5));
            vendorDialogue.text = "Thanks for your purchase.";
        }
        else
        {
            damageUpgradeCost.text = string.Format("Costs: {0}", (PlayerPrefs.GetInt("damage") * 5));
            vendorDialogue.text = "You don't have enough money for that.";


        }
    }
}
