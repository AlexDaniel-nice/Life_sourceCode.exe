using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class command_copy : codeButtonsManager
{
    public void Copy(GameObject obiect)
    {
        if (_doCommand)
        {
            Instantiate(obiect.gameObject);
            _doCommand = false;
            Debug.Log("It is working");
        }
        
    }
}
