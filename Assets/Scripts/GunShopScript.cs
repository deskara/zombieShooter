using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GunShopScript : MonoBehaviour
{
    public Text coinText;
    public Text vendorDialogue;
    public void purchasePiercingRifle()
    {
        if(PlayerPrefs.GetInt("Coins") >= 32 && PlayerPrefs.GetInt("numOfPiercingRifles") < 2)
        {
            vendorDialogue.text = "Thanks for the purchase" +
                "You can equip the new weapon by going to the inventory [I]";
            PlayerPrefs.SetInt("Coins", PlayerPrefs.GetInt("Coins") - 32);
            coinText.text = string.Format("Coins: {0}", PlayerPrefs.GetInt("Coins"));
            PlayerPrefs.SetInt("numOfPiercingRifles", PlayerPrefs.GetInt("numOfPiercingRifles") + 1);
        }
        else if (PlayerPrefs.GetInt("numOfPiercingRifles") >= 2)
        {
            vendorDialogue.text = "You wouldn't benefit from more of these...";

        }
        else
        {
            vendorDialogue.text = "You don't have enough coins to purchase that.";
        }
    }


}
