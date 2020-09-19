using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimateDoor : MonoBehaviour
{
    Animator animator;
    private bool paused = false;

    void Start()
    {
        animator = GetComponent<Animator>();
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.name == "SomeDude_RootMotion" && paused == false)
        {
            animator.SetTrigger("OpenDoor");
            EventManager.TriggerEvent<BoxCollisionEvent, Vector3, float>(other.transform.position, 0);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.name == "SomeDude_RootMotion" && paused == true)
        {
            animator.enabled = true;
            paused = false;
        };
    }

    void PauseAnimationEvent()
    {
        animator.enabled = false;
        paused = true;
    }
}
