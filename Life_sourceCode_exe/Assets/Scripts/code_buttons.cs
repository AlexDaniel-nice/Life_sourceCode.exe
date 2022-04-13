using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class code_buttons : MonoBehaviour
{
    [SerializeField] private string DefaultBeginMess;
    [SerializeField] private Text DefaultMessageText;

    private InputField CodeWrite;
    private string[] command;

    // Adauga functii pt butoane aici:
    void If()
    {
        //Do whatever it takes for if button
    }

    private void Start()
    {
        //CodeWrite.Select();
        CodeWrite = gameObject.GetComponent<InputField>();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(CodeWrite.text);
    }
}
