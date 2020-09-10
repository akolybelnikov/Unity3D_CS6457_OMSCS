using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedSphereVelocity : MonoBehaviour
{
    public float max = 2;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody>().velocity = new Vector3(Random.Range(0, max), 0, Random.Range(0, max));
    }
}
