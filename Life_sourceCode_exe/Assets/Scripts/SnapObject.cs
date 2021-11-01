using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnapObject : MonoBehaviour
{
    [SerializeField] private GameObject SnapZone;
    [SerializeField] private GameObject SnapObjectFather;

    private bool onbjectSnapped;

    void Update()
    {
        onbjectSnapped = SnapZone.GetComponent<SnappToPlaceScript>().isSnapped;

        if (onbjectSnapped == true)
        { 
            transform.SetParent(SnapObjectFather.transform);
        }
       
    }
}
