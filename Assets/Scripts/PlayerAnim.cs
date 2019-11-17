using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//This script handles the animations for the player.
public class PlayerAnim : MonoBehaviour
{
    private Animator gunAnim;
    private void Start()
    {
        gunAnim = GetComponent<Animator>();
    }
    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            gunAnim.SetBool("isFiring", true);
        }
        else if (Input.GetMouseButton(1))
        {
            gunAnim.SetBool("isFiring", true);
        }
        else
        {
            gunAnim.SetBool("isFiring", false);
        }
    }
}
