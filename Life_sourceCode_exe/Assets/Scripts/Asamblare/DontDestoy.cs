using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestoy : MonoBehaviour
{
    [SerializeField] CameraMovement getLoadEvent;

    private CameraMovement reloadEvent;
    private Rigidbody _rb;

    void Start()
    {
        _rb = GetComponent<Rigidbody>();

        //get event from camera
        reloadEvent = getLoadEvent.GetComponent<CameraMovement>();

        //subscribe to events
        reloadEvent.OnReload += ReloadEvent_OnReload;
        reloadEvent.onNextScene += ReloadEvent_onNextScene;
        
        DontDestroyOnLoad(this.gameObject);
    }

    //prlucrare obiect dupa distrugere
    private void ReloadEvent_onNextScene(object sender, System.EventArgs e)
    {
        Vector3 finalPoz = new Vector3(.5f, 1.6f, -9.5f);
        Debug.Log(finalPoz);
        _rb.transform.position = finalPoz;
        _rb.transform.rotation = Quaternion.Euler(0, 0, 0);
        _rb.isKinematic = true;
    }

    private void ReloadEvent_OnReload(object sender, System.EventArgs e)
    {
        Destroy(this.gameObject);
    }
}
