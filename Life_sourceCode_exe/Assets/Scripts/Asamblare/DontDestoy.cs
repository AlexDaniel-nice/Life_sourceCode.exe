using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestoy : MonoBehaviour
{
    [SerializeField] CameraMovement getLoadEvent;

    private CameraMovement reloadEvent;

    void Start()
    {
        //get event from camera
        reloadEvent = getLoadEvent.GetComponent<CameraMovement>();
        reloadEvent.OnReload += ReloadEvent_OnReload;
        
        DontDestroyOnLoad(this.gameObject);
    }

    private void ReloadEvent_OnReload(object sender, System.EventArgs e)
    {
        Destroy(this.gameObject);
    }
}
