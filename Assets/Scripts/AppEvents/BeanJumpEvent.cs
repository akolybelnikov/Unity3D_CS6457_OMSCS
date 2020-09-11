using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeanJumpEvent : MonoBehaviour
{
    Rigidbody bean;
    private float maxYForce = 10;
    private float maxXForce = 3;
    private float minXForce = -3;
    private bool isOnGround;
    void Start()
    {
        bean = GetComponent<Rigidbody>();
        isOnGround = true;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (isOnGround == true)
        {
            bean.velocity = new Vector3(Random.Range(minXForce, maxXForce), Random.Range(5, maxYForce), 0);
            isOnGround = false;
        }

    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("ground"))
        {
            isOnGround = true;
        }
    }
}
