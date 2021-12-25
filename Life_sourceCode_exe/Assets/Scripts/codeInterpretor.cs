using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.TextCore;


public class codeInterpretor : MonoBehaviour
{
    public InputField CodeWrite;
    public string defaultBeginMess;


    public void onEndEdit(string input)
    {
        if (input == "enable")
        {
            CodeWrite.text = '\n' + "entering advamced config";
            Debug.Log("entering advamced config");
        }
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
