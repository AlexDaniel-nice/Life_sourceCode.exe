using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnapObject : MonoBehaviour
{
    [SerializeField] private GameObject SnapZone;
    [SerializeField] private GameObject SnapObjectFather;
    [SerializeField] private LayerMask layerMask;

    private bool objectSnapped;
    private SnappToPlaceScript Snapper;
    private void Start()
    {
        Snapper = SnapZone.GetComponent<SnappToPlaceScript>();
    }

    private void OnTriggerEnter(Collider other)
    {
            objectSnapped = true;
    }

    private void OnTriggerExit(Collider other)
    {
        objectSnapped = false;

    }
    void Update()
    {
       
        if (objectSnapped == true && Input.GetKeyDown(KeyCode.LeftControl))
        { 
            transform.SetParent(SnapObjectFather.transform);

            transform.position = SnapZone.transform.position;
            transform.rotation = SnapZone.transform.rotation;
            this.GetComponent<Rigidbody>().isKinematic = true;
        }
       
    }
}
