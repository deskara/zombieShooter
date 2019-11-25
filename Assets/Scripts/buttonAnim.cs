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

    // Update is called once per frame
    void Update()
    {
        
    }
    public void buttonEnter()
    {
        buttonAnimator.SetBool("isHovering", true);

    }
    public void buttonexit()
    {
        buttonAnimator.SetBool("isHovering", false);
    }
}
