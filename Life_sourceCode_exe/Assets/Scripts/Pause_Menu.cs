using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause_Menu : MonoBehaviour
{
    [SerializeField] private GameObject PauseMenuWindow;


    private bool isPaused = false;
    private void PauseMenu()
    {
        if (Input.GetKeyDown(KeyCode.P) && isPaused == false)
        {
            isPaused = true;
            PauseMenuWindow.SetActive(true);

        }
        else
        {
            if (Input.GetKeyDown(KeyCode.P) && isPaused == true)
            {
                isPaused = false;
                PauseMenuWindow.SetActive(false);
            }
        }
    }

    void Start()
    {
        PauseMenuWindow.SetActive(false);
    }

    void Update()
    {
        PauseMenu();

    }
}
