using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PuckMove : MonoBehaviour
{
    
    private Rigidbody _rigidbody;
    private float speed = 5f;
    private bool Isflag = false;
    public float maxDistance = 2f;
    public Text Texttt;
    private Vector3 WorldPoint;
    private Vector3 ObjPoint;
    private Camera camera;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
        camera = Camera.main;
    }

    void FixedUpdate()
    {
        Touch _touch = Input.GetTouch(0);
        WorldPoint = camera.ScreenToWorldPoint(new Vector3(_touch.position.x, _touch.position.y, camera.nearClipPlane));
        ObjPoint = _camera(new Vector3(transform.position.x, transform.position.y, 0f));
        if (Input.touchCount > 0)
        {
            if (Input.GetMouseButton(0))
            {
                Texttt.text = (ObjPoint.x) + " " + WorldPoint.x;
                transform.Translate((WorldPoint.x - ObjPoint.x) * Time.deltaTime * speed,0f,0f);
            }
        }
        
        


        // For Win/macOs
        
       /* float Distances = Distance();
        float xInput = Input.GetAxis("Mouse X");
        float yInput = Input.GetAxis("Mouse Y");
        int layerMaskOnlyPlayer = 1 << 8;
        int layerMaskWithoutPlayer = ~layerMaskOnlyPlayer;
        Vector3 m_Input = new Vector3(Input.GetAxis(""), 0, Input.GetAxis("Mouse Y"));
        if (Input.touchCount > 0)
        {
            
            Touch touches = Input.GetTouch(0);
            if (Input.GetMouseButtonDown(0))
            {
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                RaycastHit hit;
 
                if (Physics.Raycast(ray, out hit, Mathf.Infinity, layerMaskWithoutPlayer))
                {
                    if (hit.collider.name == gameObject.name)
                    {
                        puckColor.color = Color.blue;
                        Isflag = true;
                        _rigidbody.useGravity = false;
                    }
                }
            }
            if (Input.GetMouseButton(0))
            {
                if (Isflag)
                {
                    _rigidbody.MovePosition(transform.position + new Vector3(0f,0f,1f));
                    /*if (Distances < maxDistance)
                    {
                    Physics.gravity = new Vector3(0f,-9.8f,-2f);
                    transform.Translate(xInput * Time.deltaTime * speed,0f,yInput * Time.deltaTime * speed);
                   // _rigidbody.MovePosition(transform.position + m_Input * Time.deltaTime * speed);
                    }
                    else
                    {
                        Isflag = false;
                        _rigidbody.useGravity = true;
                    }
                }
            }

            if (Input.GetMouseButtonUp(0))
            {
                puckColor.color = Color.black;
                Physics.gravity = new Vector3(0f,-9.8f,-15.8f);
                Isflag = false;
                _rigidbody.useGravity = true;
            } 
        }*/
        
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
