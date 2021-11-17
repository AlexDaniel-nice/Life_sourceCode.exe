using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nextPhaze : MonoBehaviour
{
    public Transform TargetPozCode;
    public GameObject cam;
    public GameObject ObjAsambled;
    public Transform ObjAsambledPoz;
    public GameObject CodeUI;

    private void Awake()
    {
        CodeUI.SetActive(false);
    }
    public void NextPhaze()
    {
        cam.transform.position = TargetPozCode.position;
        cam.transform.rotation = TargetPozCode.rotation;

        ObjAsambled.transform.position = ObjAsambledPoz.position;
        ObjAsambled.transform.rotation = ObjAsambledPoz.rotation;
        Debug.Log("Next part");

        CodeUI.SetActive(true);
       
    }
}
