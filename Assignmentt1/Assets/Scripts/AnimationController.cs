using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.InputSystem;


public class AnimationController : MonoBehaviour
{
    public Animator animator;
    public InputActionReference changeAnimation = null;


    void Start()
    {
        animator = GetComponent<Animator>();
        changeAnimation.action.started += animationChange; 
    }


    void animationChange(InputAction.CallbackContext context){
        bool active = animator.GetBool("Change");
        Debug.Log(active);
        if(active){
            animator.SetBool("Change", false);
        }

        if(!active){
            animator.SetBool("Change", true);
        } 
    }
}
