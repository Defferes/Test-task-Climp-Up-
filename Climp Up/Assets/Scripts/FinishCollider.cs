using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishCollider : MonoBehaviour
{
    public GameManager _GameManager;
    private void OnCollisionStay(Collision other)
    {
        if (other.gameObject.name == "PuckLeft")
        {
            _GameManager.Finish();
        }
    }
}
