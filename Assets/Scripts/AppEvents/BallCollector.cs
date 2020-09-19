using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class BallCollector : MonoBehaviour
{
    Transform handHold;
    public bool hasBall = false;
    public Rigidbody ballPrefab;

    List<Rigidbody> currBalls = new List<Rigidbody>();

    Animator animator;

    void Awake()
    {
        handHold = this.transform.Find("mixamorig:Hips/mixamorig:Spine/mixamorig:Spine1/mixamorig:Spine2/mixamorig:LeftShoulder/mixamorig:LeftArm/mixamorig:LeftForeArm/mixamorig:LeftHand/BallHoldSpot");

        if (ballPrefab == null)
            Debug.Log("ballPrefab could not be found");

        animator = GetComponent<Animator>();
    }

    public void ReceiveBall()
    {
        if (hasBall == false)
        {
            hasBall = true;
        }
        Rigidbody currBall = Instantiate<Rigidbody>(ballPrefab);
        currBall.transform.parent = handHold;
        currBall.transform.localPosition = Vector3.zero;
        currBall.isKinematic = true;
        currBalls.Add(currBall);
    }

    public void ThrowBall()
    {
        if (currBalls.Count != 0)
        {
            Rigidbody currBall = currBalls[currBalls.Count - 1];
            currBall.transform.parent = null;
            currBall.isKinematic = false;
            currBall.velocity = Vector3.zero;
            currBall.angularVelocity = Vector3.zero;
            currBall.AddForce(this.transform.forward * 100.0f, ForceMode.VelocityChange);
            currBalls.Remove(currBall);
            currBall = null;
            if (currBalls.Count == 0)
            {
                hasBall = false;
            }
        }
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire2") && hasBall == true)
        {
            animator.SetBool("throw", true);

        }
        if (Input.GetButtonUp("Fire2"))
        {
            animator.SetBool("throw", false);
        }

    }
}
