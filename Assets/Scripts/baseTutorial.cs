using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class baseTutorial : MonoBehaviour
{
    public UnityEvent startBaseTutorial;
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.GetString("baseTutorialState") == "Enabled")
        {
            startBaseTutorial.Invoke();
        }

    }

}
