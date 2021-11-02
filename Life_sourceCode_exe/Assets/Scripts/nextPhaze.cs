using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nextPhaze : MonoBehaviour
{
    public bool CodePhaze;

    public void NextPhaze()
    {
        Debug.Log("Next part");
        CodePhaze = true;
    }
}
