using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class settingsScript : MonoBehaviour
{
    public Text currentFireState;
    // Start is called before the first frame update
    void Start()
    {
        if(PlayerPrefs.GetString("fireState") != "Singular")
        {
            PlayerPrefs.SetString("fireState", "Both");
            currentFireState.text = "Enabled";

        }
        else
        {
            currentFireState.text = "Disabled";
        }
        
    }
    public void flipFireState()
    {
        if(PlayerPrefs.GetString("fireState") == "Both")
        {
            PlayerPrefs.SetString("fireState", "Singular");
            currentFireState.text = "Disabled";

        }
        else
        {
            PlayerPrefs.SetString("fireState", "Both");
            currentFireState.text = "Enabled";

        }
    }

}
