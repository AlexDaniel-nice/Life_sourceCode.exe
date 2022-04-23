using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class codeExecuting : MonoBehaviour
{
    public GameObject Compile;
    private compileButtonPhaze YesNo;

    private void Start()
    {
        YesNo = Compile.GetComponent<compileButtonPhaze>();
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
        if ( YesNo.Pressed == true)
            StartIterating();
    }
}
