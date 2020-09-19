using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class BallCollector : MonoBehaviour
{
    Transform handHold;
    public bool hasBall = false;
    public Rigidbody ballPrefab;

    Rigidbody currBall;

    void Awake()
    {
        handHold = this.transform.Find("mixamorig:Hips/mixamorig:Spine/mixamorig:Spine1/mixamorig:Spine2/mixamorig:LeftShoulder/mixamorig:LeftArm/mixamorig:LeftForeArm/mixamorig:LeftHand/BallHoldSpot");

        if (ballPrefab == null)
            Debug.Log("ballPrefab could not be found");
    }

    public void ReceiveBall()
    {
        hasBall = true;
        currBall = Instantiate<Rigidbody>(ballPrefab);
        currBall.transform.parent = handHold;
        currBall.transform.localPosition = Vector3.zero;
        currBall.isKinematic = true;
    }
}
