﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueSphereCollisionReporter : MonoBehaviour
{
    void OnCollisionEnter(Collision c)
    {
        foreach (ContactPoint contact in c.contacts)
        {

            if (c.impulse.magnitude > 0.25f)
            {
                EventManager.TriggerEvent<BombBounceEvent, Vector3>(contact.point);
            }

        }
    }
}

