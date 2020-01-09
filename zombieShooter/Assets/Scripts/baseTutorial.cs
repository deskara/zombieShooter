using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class baseTutorial : MonoBehaviour
{
    public UnityEvent startBaseTutorial;
    //This script starts the base tutorial if it's the player's first time in the base
    //and they haven't disabled the tutorial for the base.
    void Start()
    {
        
        if (PlayerPrefs.GetString("baseTutorialState") != "Disabled" && PlayerPrefs.GetInt("daysSurvived") == 1)
        {
            startBaseTutorial.Invoke();
        }

    }

}
