using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rightGunAnim : MonoBehaviour
{
    private Animator rightGun;
    // Start is called before the first frame update
    void Start()
    {
        rightGun = GetComponent<Animator>();

    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        if (Input.GetMouseButton(0))
        {
            if (PlayerPrefs.GetString("fireState") == "Both")
            {
                rightGun.SetBool("isFiring", true);
            }
            else
            {
                rightGun.SetBool("isFiring", false);
            }

        }
        else if (Input.GetMouseButton(1))
        {
            rightGun.SetBool("isFiring", true);

        }
        else
        {
            rightGun.SetBool("isFiring", false);
        }
    }
}
