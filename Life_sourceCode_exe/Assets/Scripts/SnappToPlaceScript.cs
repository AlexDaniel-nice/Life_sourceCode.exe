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
        SnapFunction();
        partThatIsGoingToSnap.GetComponent<Rigidbody>().isKinematic = true;
        Debug.Log(isInsideSnapZone);
    }
    private void OnTriggerExit(Collider col)
    {
        isInsideSnapZone = false;
        Debug.Log(isInsideSnapZone);

    }

    private void SnapFunction()
    {
        if (isInsideSnapZone == true && Input.GetKeyDown(KeyCode.LeftControl)==true)
        {
            partThatIsGoingToSnap.transform.position = this.transform.position;
            partThatIsGoingToSnap.transform.rotation = this.transform.rotation;
            isSnapped = true;
        }
    }

}
