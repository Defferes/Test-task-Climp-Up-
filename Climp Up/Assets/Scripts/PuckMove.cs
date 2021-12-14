using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PuckMove : MonoBehaviour
{
    
    private Rigidbody _rigidbody;
    private CharacterJoint _characterJoint;
    private float speed = 0.001f;
    private bool Isflag = false;
    private Camera _camera;
    public GameObject otherPuck;
    public HeadRotate _HeadRotate;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _characterJoint = GetComponent<CharacterJoint>();
        _camera = Camera.main;
    }

    void FixedUpdate()
    {
        int layerMaskOnlyPlayer = 1 << 8;
            int layerMaskWithoutPlayer = ~layerMaskOnlyPlayer;
            if (Input.touchCount == 1)
            {
                Touch _touch = Input.GetTouch(0);
                if (Input.GetMouseButtonDown(0))
                {
                    Ray ray = _camera.ScreenPointToRay(Input.mousePosition);
                    RaycastHit hit;
                    if (Physics.Raycast(ray, out hit, Mathf.Infinity, layerMaskWithoutPlayer))
                    {
                        if (hit.collider.name == gameObject.name)
                        {
                            _HeadRotate.target = hit.transform;
                                Isflag = true;
                            _rigidbody.useGravity = false;
                        }
                    }
                }
                
                if (Input.GetMouseButton(0))
                {
                    if (Isflag && Distance() < 2.5)
                    {
                        Physics.gravity = new Vector3(0f,-9.8f,-2f);
                        _rigidbody.transform.position = new Vector3(_rigidbody.transform.position.x + _touch.deltaPosition.x * (speed / (Distance()*3)),
                            _rigidbody.transform.position.y,_rigidbody.transform.position.z + _touch.deltaPosition.y * (speed / (Distance()*3)));
                    }
                    else if (Distance() >= 2.5)
                    {
                        Physics.gravity = new Vector3(0f,0f,-15.8f);
                        Isflag = false;
                        _rigidbody.useGravity = true;
                        _characterJoint.connectedBody = null;
                    }
                }
            
                if (Input.GetMouseButtonUp(0))
                {
                    Physics.gravity = new Vector3(0f,-9.8f,-15.8f);
                    Isflag = false;
                    _rigidbody.useGravity = true;
                } 
            }
    }

    private float Distance()
    {
        float distance = -1;
        distance = Vector3.Distance(transform.position, otherPuck.transform.position);
        return distance;
    }
}
