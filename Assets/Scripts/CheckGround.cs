using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckGround : MonoBehaviour
{
    [SerializeField] private AnimController animController;
    [SerializeField] private GameObject girl;
    [SerializeField] private Animator animator;
    private bool isGrounded;
    private float timer = 50f;
    private void Update()
    {
        if (isGrounded) timer -= 0.1f;
        if(timer<0) { girl.SetActive(false); timer = 50f; isGrounded = false; }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name== "Girl1" || 
            other.gameObject.name == "Girl2" || 
            other.gameObject.name == "Girl3" || 
            other.gameObject.name == "Girl4")
        {
            girl = other.gameObject;
            animator = girl.GetComponent<Animator>();
            animController.SetThisAnimatorPassedTrue(animator);
            isGrounded = true;
        }
    }
}
