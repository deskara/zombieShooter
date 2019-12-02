using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class addScore : MonoBehaviour
{
    public delegate void SendScore(int theScore);
    public static event SendScore OnSendScore;
    public int score = 10;
    //This script makes it so that the score is incremented by 10 whenever a zombie is slain.
    private bool scoreSent = false;
    public void OnAddScore()
    {
        if (OnSendScore != null)
        {

            if(scoreSent== false)
            {
                OnSendScore(score);
                scoreSent = true;
            }
        }
    }
}