using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimateDoor : MonoBehaviour
{
    Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }
    void OnTriggerEnter(Collider other)
    {
        animator.SetTrigger("OpenDoor");
    }

    void OnTriggerExit(Collider other)
    {
        animator.enabled = true;
    }

    void PauseAnimationEvent()
    {
        animator.enabled = false;
    }
}
