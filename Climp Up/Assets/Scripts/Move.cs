using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public GameObject trackingObj;

    private void FixedUpdate()
    {
        transform.position = trackingObj.transform.position;
    }
}
