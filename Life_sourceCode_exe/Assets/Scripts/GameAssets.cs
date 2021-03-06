using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameAssets : MonoBehaviour
{
    //Referinta la aset-uri:
    public GameObject Friend;
    public GameObject FinalPozForCommands;

    private static GameAssets instance;

    public static GameAssets GetInstance
    {
        get
        {
            if (instance == null)
                instance = (Instantiate(Resources.Load("GameAssets")) as GameObject).GetComponent<GameAssets>();
            return instance;
        }
        
    }

    private void Awake()
    {
        instance = this;
    }
}
