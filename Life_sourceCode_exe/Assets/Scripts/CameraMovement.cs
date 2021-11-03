using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform TargetPoz1;
    public Transform TargetPoz2;
    public Transform OriginalPoz;

    public GameObject NextPhazeBTN;
    //public float smoothMove = 10f;

    private bool isUpView;
    private bool isCodeView;

    void Update()
    {
        /*
        Vector3 Poz1 = TargetPoz1.position;
        Vector3 Poz0 = OriginalPoz.position;

        Vector3 smoothToPlace = Vector3.Lerp(transform.position, Poz1, smoothMove*Time.deltaTime);
        Vector3 smoothToPlaceBack = Vector3.Lerp(Poz1, Poz0, smoothMove * Time.deltaTime);
        */

        if (Input.GetKeyDown(KeyCode.Z))
        {
            transform.position = TargetPoz1.position;
            transform.rotation = TargetPoz1.rotation;
        }
        
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            transform.position = OriginalPoz.position;
            transform.rotation = OriginalPoz.rotation;
        }

        /*
        isCodeView = NextPhazeBTN.GetComponent<nextPhaze>().CodePhaze;

        if (isCodeView==true)
        {
            this.transform.position = TargetPoz2.position;
            this.transform.rotation = TargetPoz2.rotation;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            this.transform.position = TargetPoz1.position;
            this.transform.rotation = TargetPoz1.rotation;
        }
        */
    }
}
