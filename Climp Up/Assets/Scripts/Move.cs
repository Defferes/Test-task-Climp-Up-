using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public GameObject trackingObj;

    private void FixedUpdate()
    {
        transform.position = new Vector3(trackingObj.transform.position.x,transform.position.y,trackingObj.transform.position.z);
    }
}
