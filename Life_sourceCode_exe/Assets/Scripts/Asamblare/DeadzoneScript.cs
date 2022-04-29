using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class DeadzoneScript : MonoBehaviour
{
    public static EventHandler onDeadzoneEnter;

    private void OnCollisionEnter(Collision collision)
    {
        
            onDeadzoneEnter?.Invoke(this, EventArgs.Empty);
            Debug.Log("We are here respawning");
        
    }
}
