using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonAnim : MonoBehaviour
{
    private Animator buttonAnimator;
    // Start is called before the first frame update
    void Start()
    {
        buttonAnimator = GetComponent<Animator>();
        
    }


    //This will be ran when the player hovers over the button using the unity event for it.
    public void buttonEnter()
    {
        buttonAnimator.SetBool("isHovering", true);

    }
    //This will be ran when the player stops hoverig over the button using the unity event for it.
    public void buttonexit()
    {
        buttonAnimator.SetBool("isHovering", false);
    }
}
