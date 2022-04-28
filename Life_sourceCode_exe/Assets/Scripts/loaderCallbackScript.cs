using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loaderCallbackScript : MonoBehaviour
{
    bool isFirstUpdate = true;

    private void Update()
    {
        if (isFirstUpdate)
        {
            isFirstUpdate = false;
            Loader.LoaderCallback();
        }
    }
}
