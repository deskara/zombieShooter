using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fpsLimiter : MonoBehaviour
{
    //This script limits the FPS of the game
    //This ensures that the game doesn't have excessive FPS e.g 4300 which can cause problems for user's computers.
    void Start()
    {
        Application.targetFrameRate = 120;
    }
}
