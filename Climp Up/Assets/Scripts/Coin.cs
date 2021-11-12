using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{

    private void OnCollisionEnter(Collision other)
    {
        MoneyData.Coin++;
        GetComponent<MeshRenderer>().enabled = false;
        GetComponent<CapsuleCollider>().isTrigger = true;
    }
}
