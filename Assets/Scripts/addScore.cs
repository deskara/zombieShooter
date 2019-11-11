﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class addScore : MonoBehaviour
{
    public delegate void SendScore(int theScore);
    public static event SendScore OnSendScore;
    public int score = 10;
    private void OnDestroy()
    {
        if (OnSendScore != null)
        {
            OnSendScore(score);
        }
    }
}