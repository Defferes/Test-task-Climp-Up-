using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadCollider : MonoBehaviour
{
    public GameManager _gameManager;
    private void OnCollisionEnter(Collision other)
    { 
        Invoke("LoseGm",2f);
    }

    private void LoseGm()
    {
        _gameManager.LoseGame();
    }
}
