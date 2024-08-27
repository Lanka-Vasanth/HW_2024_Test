using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFollow : MonoBehaviour
{
    public Transform playerTransform; 
    public Vector3 offset = new Vector3(0, 5, -10);  
    public float smoothSpeed = 0.125f;  

    void LateUpdate()
    {
        if (playerTransform != null)
        {
            Vector3 desiredPosition = playerTransform.position + offset;
            
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
            transform.position = smoothedPosition;
            
            transform.rotation = Quaternion.Euler(30f, 0f, 0f);
        }
    }
}
