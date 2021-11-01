using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnapObject : MonoBehaviour
{
    [SerializeField] private GameObject SnapZone;
    [SerializeField] private GameObject SnapObjectFather;

    private bool onbjectSnapped;
    private SnappToPlaceScript Snapper;
    private void Start()
    {
        Snapper = SnapZone.GetComponent<SnappToPlaceScript>();
    }
    void Update()
    {
        onbjectSnapped = Snapper.isSnapped;

        if (onbjectSnapped == true)
        { 
            transform.SetParent(SnapObjectFather.transform);

            transform.position = SnapZone.transform.position;
            transform.rotation = SnapZone.transform.rotation;
        }
       
    }
}
