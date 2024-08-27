using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomGravity : MonoBehaviour
{
    public float gravityMultiplier = 1.0f;  
    private Rigidbody rigbod;

    void Start()
    {
        rigbod = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        if (rigbod != null)
        {
            Vector3 downwardForce = Vector3.down * gravityMultiplier * Physics.gravity.magnitude;
            rigbod.AddForce(downwardForce, ForceMode.Acceleration);
        }
    }
}
