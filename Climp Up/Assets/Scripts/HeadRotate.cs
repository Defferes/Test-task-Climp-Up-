using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadRotate : MonoBehaviour
{
    public Transform target;
    public float maxRadian;
    
    void Update()
    {
        Vector3 newDir = Vector3.RotateTowards(transform.forward, (target.transform.position-transform.position), maxRadian, 0.0F);
        transform.rotation = Quaternion.LookRotation(newDir);
    }
}
