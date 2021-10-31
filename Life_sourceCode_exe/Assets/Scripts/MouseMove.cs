using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseMove : MonoBehaviour
{
    
    private Vector3 MouseOffset;
    private Vector3 FinalPozition;
    private Rigidbody _rigidbody;
    private float MouseZCoord;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
        FinalPozition = transform.position;
    }

    private void OnMouseDown()
    {
        MouseZCoord = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;
        MouseOffset = gameObject.transform.position - GetMouseWorldPose();
        _rigidbody.isKinematic = true;

    }
    private void OnMouseUp()
    {
        _rigidbody.isKinematic = false;
    }
    private Vector3 GetMouseWorldPose()
    {
        Vector3 MousePoint = Input.mousePosition;

         MousePoint.z =MouseZCoord;

        return Camera.main.ScreenToWorldPoint(MousePoint);
    }

    private void OnMouseDrag()
    {
       

        FinalPozition = GetMouseWorldPose() + MouseOffset;
        FinalPozition.y = Mathf.Clamp(FinalPozition.y, 1.6f, 2.6f);

        transform.position = FinalPozition;
    }
   
}
