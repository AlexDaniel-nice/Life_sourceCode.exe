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

    bool doOnce = true;
    int nr=0;
    private void Update()
    {

        if (YesNo.Pressed == true && doOnce == true)
        {
            nr++;
            StartIterating();
            Compile.gameObject.SetActive(false);
            doOnce = false;
        }
        else Compile.gameObject.SetActive(true);

        if (!YesNo.Pressed) doOnce = true;

        Debug.Log(YesNo.Pressed);
        Debug.Log(nr);
    }
}
