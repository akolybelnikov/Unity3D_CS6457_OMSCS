﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableBall : MonoBehaviour
{
    void OnTriggerEnter(Collider c)
    {
        if (c.attachedRigidbody)
        {
            BallCollector bc = c.attachedRigidbody.gameObject.GetComponent<BallCollector>();
            if (bc)
            {
                bc.ReceiveBall();
                EventManager.TriggerEvent<BombBounceEvent, Vector3>(c.transform.position);
                Destroy(this.gameObject);
            }
        }
    }
}
