using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class numDaysSurvivedScript : MonoBehaviour
{
    public Text numDaysText;
    // Start is called before the first frame update
    void Start()
    {
        numDaysText.text = string.Format("You survived {0} days", PlayerPrefs.GetInt("daysSurvived"));
        
    }
}
