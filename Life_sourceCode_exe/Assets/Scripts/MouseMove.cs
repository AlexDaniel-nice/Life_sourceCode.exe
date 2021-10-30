using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseMove : MonoBehaviour
{

    /** Potential fix for dragging objects
     private float MouseX;
     private float MouseY;


     private float GetMousePos(bool x)
     {
         MouseX = Input.mousePosition.x;
         MouseY = Input.mousePosition.y;

         if (x == true) return MouseX;
         else return MouseY;
     
     }

     private void OnMouseDown()
     {

     }

     private void OnMouseDrag()
     {
         float objYpoz = transform.position.y;

         transform.position = new Vector3(GetMousePos(true), GetMousePos(false), objYpoz);
     }

     **/

    private Vector3 MouseOffset;

    private float MouseZCoord;

    private void OnMouseDown()
    {
        MouseZCoord = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;
        MouseOffset = gameObject.transform.position - GetMouseWorldPose();   
    }

    private Vector3 GetMouseWorldPose()
    {
        Vector3 MousePoint = Input.mousePosition;

        MousePoint.z = MouseZCoord;

        return Camera.main.ScreenToWorldPoint(MousePoint);
    }

    private void OnMouseDrag()
    {
        transform.position = GetMouseWorldPose() + MouseOffset;
    }
}
