using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnappToPlaceScript : MonoBehaviour
{
    private bool isInsideSnapZone;

    [SerializeField] private GameObject partThatIsGoingToSnap;
    [SerializeField] private GameObject refrenceRotationWhenSnaped;
    
    public bool isSnapped;

 
    private void OnTriggerEnter(Collider col)
    {
        isInsideSnapZone = true;
    }
    private void OnTriggerExit(Collider col)
    {
        isInsideSnapZone = false;
    }

    private void OnMouseUp()
    {
        if (isInsideSnapZone == true)
        {
           
            partThatIsGoingToSnap.gameObject.transform.position = this.transform.position;
            partThatIsGoingToSnap.gameObject.transform.rotation = refrenceRotationWhenSnaped.transform.rotation;
            isSnapped = true;
        }
    }

}
