using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform TargetPoz1;
    public Transform TargetPoz2;
    public GameObject NextPhazeBTN;

    private bool isUpView;
    private bool isCodeView;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
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
    }
}
