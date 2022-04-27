using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class codeExecuting : MonoBehaviour
{
    private compileButtonPhaze fireEvent;

    public GameObject Compile;

    private bool GoOnce = false;


    private void Start()
    {
        fireEvent = Compile.GetComponent<compileButtonPhaze>();

        fireEvent.onButtonPressed += FireEvent_onButtonPressed;
    }

    private void FireEvent_onButtonPressed(object sender, EventArgs e)
    {
        GoOnce = true;
    }

    public void StartIterating()
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            doLogic(transform.GetChild(i).gameObject);
        }
    }

    private void doLogic(GameObject obj)
    {
        codeButtonsManager command = obj.GetComponent<codeButtonsManager>();
        command.DoCommand();
    }
    private void Update()
    {

        if (GoOnce)
        {
            StartIterating();
            Compile.gameObject.SetActive(false);
            GoOnce = false;
        }
        else Compile.gameObject.SetActive(true);

    }
}
