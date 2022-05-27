using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class codeButtonsManager : MonoBehaviour
{
    [SerializeField] private GameObject FinalPoz4Command;

    public void ifClicked()
    {
        GameObject clone = Instantiate(this.gameObject);
        Transform _trComp = clone.GetComponent<Transform>();

        _trComp.SetParent(FinalPoz4Command.transform);
        _trComp.localScale = FinalPoz4Command.transform.localScale;
        _trComp.position = Vector3.zero;
    }
   
    public bool _doCommand = false;
    public void DoCommand()
    {
        _doCommand = true;
        Debug.Log("_doCommand is " + _doCommand);
    }
}
