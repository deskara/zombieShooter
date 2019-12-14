using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leftGunAnim : MonoBehaviour
{
    private Animator leftGun;
    // Start is called before the first frame update
    void Start()
    {
        leftGun = GetComponent<Animator>();

    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        if (Input.GetMouseButton(0))
        {
            leftGun.SetBool("isFiring", true);
        }
        else if (Input.GetMouseButton(1))
        {
            if (PlayerPrefs.GetString("fireState") == "Both")
            {
                leftGun.SetBool("isFiring", true);
            }
            else
            {
                leftGun.SetBool("isFiring", false);
            }

        }
        else
        {
            leftGun.SetBool("isFiring", false);
        }
    }
}
