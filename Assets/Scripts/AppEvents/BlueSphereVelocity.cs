using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueSphereVelocity : MonoBehaviour
{
    public float max = 7;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody>().velocity = new Vector3(Random.Range(0, max), 0, Random.Range(0, max));
    }
}
