using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class VbControler : MonoBehaviour
{
    public GameObject girl;
    private Animator animator;

    [System.Obsolete]
    void Start()
    {
        girl = GameObject.Find("girl");
        animator = girl.GetComponent<Animator>();

        var vbbs = GetComponentsInChildren<VirtualButtonBehaviour>();
        for (int i = 0; i < vbbs.Length; ++i)
        {
            vbbs[i].RegisterOnButtonPressed(OnButtonPressed);
            vbbs[i].RegisterOnButtonReleased(OnButtonReleased);
        }
    }

    [System.Obsolete]
    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {

        switch (vb.VirtualButtonName)
        {

            case "RunButton":
                animator.SetBool("walk", false);
                animator.SetBool("run", true);
                break;

            case "WalkButton":
                animator.SetBool("run", false);
                animator.SetBool("walk", true);
                break;

            default:
                animator.SetBool("walk", false);
                animator.SetBool("run", false);
                break;
        }
    }

    [System.Obsolete]
    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        animator.Play("Idle");
    }
}
