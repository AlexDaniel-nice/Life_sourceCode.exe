using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class CameraMovement : MonoBehaviour
{
    [SerializeField] private ScriptableObjectsPoz CameraPozition;
    //public float smoothMove = 10f;

    private void CodeView()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.position = CameraPozition.CodeViewPoz.position;
            transform.rotation = CameraPozition.CodeViewPoz.rotation;
        }
    }
    private void ZoomView()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            transform.position = CameraPozition.TopViewPoz.position;
            transform.rotation = CameraPozition.TopViewPoz.rotation;
        }
    }

    private void OriginalCameraView()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            transform.position = CameraPozition.OriginalPoz.position;
            transform.rotation = CameraPozition.OriginalPoz.rotation;
        }
    }

    //This code can be added to other scripts to maintain readability
    public event EventHandler OnReload;
    public event EventHandler onNextScene;
    private void ReloadScene()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            Loader.Load(Loader.Scene.GameScene);
            OnReload?.Invoke(this, EventArgs.Empty);
        }
    }

    private void LoadNextScene()
    {
        if (Input.GetKeyDown(KeyCode.N))
        {
            Loader.Load(Loader.Scene.CodeWriting);
            onNextScene?.Invoke(this, EventArgs.Empty);
        }
    }
    void Update()
    {
        CodeView();
        ZoomView();
        OriginalCameraView();
        ReloadScene();
        LoadNextScene();
    }
}
