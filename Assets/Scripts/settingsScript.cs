using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class settingsScript : MonoBehaviour
{
    public Text currentFireState;
    public Text baseTutorialState;
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
        
        if(PlayerPrefs.GetString("baseTutorialState") != "Disabled")
        {
            PlayerPrefs.SetString("baseTutorialState", "Enabled");
            baseTutorialState.text = "Enabled";
        }
        else
        {
            baseTutorialState.text = "Disabled";

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

    public void toggleBaseTutorial()
    {
        if (PlayerPrefs.GetString("baseTutorialState") != "Disabled")
        {
            PlayerPrefs.SetString("baseTutorialState", "Disabled");
            baseTutorialState.text = "Disabled";
        }
        else
        {
            PlayerPrefs.SetString("baseTutorialState", "Enabled");
            baseTutorialState.text = "Enabled";

        }

    }

}
