using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nextScene : MonoBehaviour
{
    // Start is called before the first frame update
    public void LoadNextScene()
    {
        Loader.Load(Loader.Scene.codeExecute);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.N)) Loader.Load(Loader.Scene.codeExecute);
    }
}
