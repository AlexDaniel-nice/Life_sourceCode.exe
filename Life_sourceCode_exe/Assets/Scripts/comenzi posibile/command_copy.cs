using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class command_copy : codeButtonsManager
{
    public void Copy(GameObject obiect)
    {
        Instantiate(obiect.gameObject);
    }

    private void Update()
    {
        if (_doCommand)
        {
            Debug.Log("It is working");
            Copy(this.gameObject);
            _doCommand = false;
        }
    }
}
