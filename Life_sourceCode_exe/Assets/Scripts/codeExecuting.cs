using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class codeExecuting : MonoBehaviour
{
    //event relates vars
    public GameObject Compile;
    private compileButtonPhaze fireEvent;

    //doOnce related vars
    private bool cancel = false;


    private void Start()
    {
        fireEvent = Compile.GetComponent<compileButtonPhaze>();

        fireEvent.onButtonPressed += FireEvent_onButtonPressed;
        fireEvent.onButtonDesabled += FireEvent_onButtonDesabled;

    }

    //fire the event (execute the code)
    private void FireEvent_onButtonPressed(object sender, EventArgs e)
    {
        cancel = false;
        StartIterating();
        Debug.Log("cancel state is " + cancel);
    }

    //stop the event
    private void FireEvent_onButtonDesabled(object sender, EventArgs e)
    {
        cancel = true;
        Debug.Log("cancel state is " + cancel);

    }

    //user code compile-related code
    public void StartIterating()
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            if (cancel) return;
            else doLogic(transform.GetChild(i).gameObject);
        }
    }

    private void doLogic(GameObject obj)
    {
        codeButtonsManager command = obj.GetComponent<codeButtonsManager>();
        command.DoCommand();
    }

}
