using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class compileButtonPhaze : MonoBehaviour
{
    public bool Pressed = false;
    
    public void PRESSED()
    {
        Pressed = true;
    } 
    public void PRESSED_STOP()
    {
        Pressed = false;
    }
}
