using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnapObject : MonoBehaviour
{
    [SerializeField] private GameObject SnapZone;
    [SerializeField] private GameObject SnapObjectFather;

    [SerializeField] private bool onjectSnapped;


    // Update is called once per frame
    void Update()
    {
        onjectSnapped = SnapZone.GetComponent<SnappToPlaceScript>().isSnapped;

        if (onjectSnapped == true)
        {
            GetComponent<Rigidbody>().isKinematic = true;
            transform.SetParent(SnapObjectFather.transform);
        }
       
    }
}
