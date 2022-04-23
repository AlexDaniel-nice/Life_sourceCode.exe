using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class codeButtonsManager : MonoBehaviour
{
    private int NrOfAvailableCommands = 0;

    [SerializeField] private GameObject FinalPoz4Command;

    public void ifClicked()
    {
        GameObject clone = Instantiate(this.gameObject);

        clone.transform.SetParent(FinalPoz4Command.transform);
        clone.transform.localScale = FinalPoz4Command.transform.localScale;
    }
}
