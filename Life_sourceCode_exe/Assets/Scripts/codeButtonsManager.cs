using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class codeButtonsManager : MonoBehaviour
{
    private static codeButtonsManager instance;
    private bool isFixed = false;

    private static codeButtonsManager GetInstance()
    {
        return instance;
    }

    private void OnMouseDown()
    {
        Instantiate(codeButtonsManager.GetInstance().gameObject);
        isFixed = true;
    }


}
