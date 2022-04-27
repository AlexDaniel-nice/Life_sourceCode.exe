using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class compileButtonPhaze : MonoBehaviour
{
    public event EventHandler onButtonPressed;
    public event EventHandler onButtonDesabled;

    bool StartCompiling = false;
    bool StopCompiling = false;
    
    //functii atasate butoanelor
    public void PRESSED()
    {
        StartCompiling = true;
    } 
    public void PRESSED_STOP()
    {
        StopCompiling = true;
    }

    private void Update()
    {
        if (StartCompiling)
        {
            onButtonPressed?.Invoke(this, EventArgs.Empty);
            StartCompiling = false;
        }

        if (StopCompiling)
        {
            onButtonDesabled?.Invoke(this, EventArgs.Empty);
            StopCompiling = false;
        }
        
    }
}
