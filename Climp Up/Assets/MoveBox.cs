using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBox : MonoBehaviour
{
    private void Update()
    {
        float floatMoveX = Input.GetAxis("Vertical");
        float floatMoveY = Input.GetAxis("Horizontal");
        transform.Translate(floatMoveX*Time.deltaTime, 0f,floatMoveY* Time.deltaTime);
    }
}
