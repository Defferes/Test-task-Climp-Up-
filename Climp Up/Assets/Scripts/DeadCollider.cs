using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadCollider : MonoBehaviour
{
    public GameManager _gameManager;
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.name == "PuckRight" || other.gameObject.name == "PuckLeft")
        {
            _gameManager.LoseGame();
        }
    }
}
