using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class compileButtonPhaze : MonoBehaviour
{
    public event EventHandler onButtonPressed;

    private bool pressed = false;
    
    //functii atasate butoanelor
    public void PRESSED()
    {
        pressed = true;
    } 
    public void PRESSED_STOP()
    {
        pressed = false;
    }

    private void Update()
    {
        if (pressed)
        {
            onButtonPressed?.Invoke(this, EventArgs.Empty);
        }
    }
}
