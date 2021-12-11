using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.name == "PuckRight" || other.gameObject.name == "PuckLeft")
        {
            MoneyData.Coin += 100;
            GetComponent<MeshRenderer>().enabled = false;
            GetComponent<CapsuleCollider>().isTrigger = true;
        }
        
        
    }
}
