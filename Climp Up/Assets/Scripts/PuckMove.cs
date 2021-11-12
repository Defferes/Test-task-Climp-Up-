using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuckMove : MonoBehaviour
{
    
    private Rigidbody _rigidbody;
    private float speed = 10f;
    private bool Isflag = false;
    public float maxDistance = 2f;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        float Distances = Distance();
        float xInput = Input.GetAxis("Mouse X");
        float yInput = Input.GetAxis("Mouse Y");
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
 
            if (Physics.Raycast(ray, out hit, 100))
            {
                if (hit.collider.name == gameObject.name)
                {
                    Isflag = true;
                    _rigidbody.useGravity = false;
                }
            }
        }
        if (Input.GetMouseButton(0))
        {
            if (Isflag)
            {
                /*if (Distances < maxDistance)
                {*/
                    transform.Translate(xInput * speed * Time.deltaTime,0f, yInput * speed * Time.deltaTime);
                /*}
                else
                {
                    Isflag = false;
                    _rigidbody.useGravity = true;
                }*/
            }
        }

        if (Input.GetMouseButtonUp(0))
        {
            Isflag = false;
            _rigidbody.useGravity = true;
        }
    }

    private float Distance()
    {
        GameObject other;
        float distance = -1;
        if (gameObject.name == "PuckRight")
        {
            other = GameObject.Find("PuckLeft");
            distance = Vector3.Distance(transform.position, other.transform.position);
        }
        else if (gameObject.name == "PuckLeft")
        {
            other = GameObject.Find("PuckRight");
            distance = Vector3.Distance(transform.position, other.transform.position);
        }
        return distance;
    }
}
