using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class C_PlusPlus_code_interpret : MonoBehaviour
{
    [SerializeField] private string defaultBeginMess;

    private InputField CodeWrite;
    private string beginningMessage;
    private string[] command;

    private void Start()
    {
        CodeWrite.Select();
        CodeWrite = gameObject.GetComponent<InputField>();
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
