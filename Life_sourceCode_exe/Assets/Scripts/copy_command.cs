﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class copy_command : codeButtonsManager
{
    [SerializeField] private GameObject ribozom;
    [SerializeField] private GameObject friend;

    //isTutorial needs to be changed if not the tutorial
    private bool isTutorial = false;

    private friendBehaviour Friend_Functions;

    // Adauga functii pt butoane aici:
    private void Start()
    {
        Friend_Functions = friend.GetComponent<friendBehaviour>();
    }

    private void OnMouseDown()
    {
        //Instantiate(GameAssets.GetInstance.buton_copy);
    }
    private void CopyBtn()
    {
       // if (Friend_Functions.GetColidingBool()) Instantiate(GameAssets.GetInstance.Proteins);
    }
    // Update is called once per frame
    void Update()
    {
    }
}
