using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.TextCore;


public class codeInterpretor : MonoBehaviour
{
    public InputField CodeWrite;
    public string defaultBeginMess;

    private string[] command;

    private void ena()
    {
        Debug.Log("entering advanced config");
    }
    private void LineInterpretor(string a)
    {
        if (a == "enable") ena();
    }
    public void onEndEdit(string input)
    {
        command = input.Split('\n');
        LineInterpretor(command[command.Length - 1]);

    }
    // Start is called before the first frame update
    void Start()
    {
        CodeWrite.text = '\n'+ defaultBeginMess + '\n';
        
    }


    public void onClik()
    {
        CodeWrite.text = "enable" + '\n' + "entering advanced conf";
    }
}
