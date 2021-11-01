using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnappToPlaceScript : MonoBehaviour
{
    private bool isInsideSnapZone;

    public GameObject partThatIsGoingToSnap;
    //public GameObject refrenceRotationWhenSnaped;
    public bool isSnapped;

    [SerializeField] private LayerMask layerMask;
    private void OnTriggerEnter(Collider col)
    {
        isInsideSnapZone = true;
    }
    private void OnTriggerExit(Collider col)
    {
        isInsideSnapZone = false;
    }

    private void OnMouseDrag()
    {
        if (isInsideSnapZone == true && Input.GetKeyDown(KeyCode.LeftControl)==true)
        {
            partThatIsGoingToSnap.transform.position = this.transform.position;
            partThatIsGoingToSnap.transform.rotation = this.transform.rotation;
            isSnapped = true;
        }
    }

}
