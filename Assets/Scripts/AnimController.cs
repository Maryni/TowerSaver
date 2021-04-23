using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimController : MonoBehaviour
{
    [SerializeField] private Animator animator;
    [SerializeField] private bool currentMoving;

    [SerializeField] private List<Animator> animatorList;
    [SerializeField] private bool currentPassed=false;

    [SerializeField] private Animator tempAnimator;

    private float timer = 10f;
    private void Update()
    {
        if(currentPassed) timer -= 0.1f;
        if(timer<0f && tempAnimator!=null) { SetThisAnimatorPassedTrue(tempAnimator); tempAnimator = null; }

    }

    public void SetThisAnimatorPassedTrue(Animator anim)
    {
        tempAnimator = anim;
        currentPassed = true;
        anim.SetBool("isPassed", true);
        if (timer < 0f) 
        { 
            anim.SetInteger("i", 1);  //set off passed animation
            timer = 10f; 
            currentPassed = false; 
        } 
    }

    public bool GetMoving() { return currentMoving; }
    public void SetMovingTrue() { animator.SetBool("isMoving", true); currentMoving = true; }
    public void SetMovingFalse() { animator.SetBool("isMoving", false); currentMoving = false; }
}
