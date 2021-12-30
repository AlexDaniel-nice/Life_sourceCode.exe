using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


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
    public void FinalEdit(InputField inpF)
    {
        string input = inpF.text;
        command = input.Split('\n');
        LineInterpretor(command[command.Length - 1]);
        Debug.Log(command[command.Length - 1]);
        Debug.Log(input);

    }
    // Start is called before the first frame update
    void Start()
    {
        CodeWrite.text = '\n'+ defaultBeginMess + '\n';
        CodeWrite.onEndEdit.AddListener(delegate { FinalEdit(CodeWrite); });
        
    }

    /*
     private void Update()
     {
        CodeWrite.onEndEdit.AddListener(delegate { FinalEdit(CodeWrite); });
             
     }
    */
    public void onClik()
    {
        CodeWrite.text = "enable" + '\n' + "entering advanced conf";
    }
}
