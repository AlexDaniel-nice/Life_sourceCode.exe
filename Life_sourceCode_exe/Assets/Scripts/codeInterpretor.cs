using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class codeInterpretor : MonoBehaviour
{
    public InputField CodeWrite;
    public string defaultBeginMess;

    private string[] command;

    private void Start()
    {
        CodeWrite.Select();
    }
    private void ena()
    {
        // CodeWrite.enabled = false;
       // CodeWrite.interactable = !CodeWrite.interactable;
        Debug.Log("entering advanced config");
        CodeWrite.text = CodeWrite.text + '\n' + "entering advanced config" + '\n';
        // CodeWrite.interactable = !CodeWrite.interactable;
        CodeWrite.enabled = true;
        CodeWrite.Select();
        
        CodeWrite.text = CodeWrite.text + '\n';

        CodeWrite.Select();
        CodeWrite.caretPosition = CodeWrite.text.Length + 10;
    }

    private void getInput()
    {
        CodeWrite.text = CodeWrite.text + '\n' + "C:<JohnDowe<ribozom<getinput> " + '\n';

        CodeWrite.Select();
        CodeWrite.caretPosition = CodeWrite.text.Length + 10;
    }

    private void printResult()
    {
        CodeWrite.text = CodeWrite.text + '\n' + "C:<JohnDowe<ribozom<printing...> " + '\n';

        CodeWrite.Select();
        CodeWrite.caretPosition = CodeWrite.text.Length + 10;
    }

    private void LineInterpretor(string a)
    {
        if (a == "enable") ena();
        if (a == "get input") getInput();
        if (a == "print") printResult();
      //if (a == "conf t") conf_t();
      //if (a == "move") move();
      //if (a == "other") other();
    }

    public void FinalEdit(InputField inpF)
    {
        command = inpF.text.Split('\n');
        LineInterpretor(command[command.Length - 1]);
    }

    /* Leftover code
    void Start()
    {
        //CodeWrite.text =defaultBeginMess;
      //  CodeWrite.onEndEdit.AddListener(delegate { FinalEdit(CodeWrite); });
        
    }

    /*
     private void Update()
     {
        CodeWrite.onEndEdit.AddListener(delegate { FinalEdit(CodeWrite); });
             
     }
    public void onClik()
    {
        CodeWrite.text = "enable" + '\n' + "entering advanced conf";
    }
    */

    //Many things that are up are garbage

    //THE SOLUTION!!!!!
    public void InputText(string NewText)
    {
        FinalEdit(CodeWrite);
        Debug.Log(NewText);

    }
}
