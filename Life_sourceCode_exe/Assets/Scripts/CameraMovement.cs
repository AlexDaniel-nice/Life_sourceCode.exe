using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField] private ScriptableObjectsPoz CameraPozition;

    //[SerializeField] private float smoothingValue = 10f;

    private bool isUpView;
    private bool isCodeView;

    private void nextPhaze()
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
    void Update()
    {
        nextPhaze();
        ZoomView();
        OriginalCameraView();
        
        /** Extra code, purpose: UNKNOWN :))))
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
        **/
    }
}
