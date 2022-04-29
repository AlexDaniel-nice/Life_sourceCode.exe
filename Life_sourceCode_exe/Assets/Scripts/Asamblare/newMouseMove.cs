using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newMouseMove : MonoBehaviour
{
    [SerializeField] private Camera mainCamera;
    [SerializeField] private LayerMask layerMask;
    [SerializeField] private Transform fixedPozition;

    private Rigidbody _rb;
    private void Awake()
    {
        _rb = GetComponent<Rigidbody>();
    }

    private void FixObjInPlace()
    {
            _rb.transform.position = fixedPozition.position;
    }
    private void HandleCursorMovement()
    {
        Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out RaycastHit rayCastHit, float.MaxValue, layerMask))
        {
            transform.position = rayCastHit.point;
        }
    }

    private void OnMouseDrag()
    {
        HandleCursorMovement();
        _rb.isKinematic = true;
        if (Input.GetKeyDown(KeyCode.LeftControl) || Input.GetKeyDown(KeyCode.RightControl))
        {
            FixObjInPlace();
            return;
        }
    }

    private void OnMouseUp()
    {
        _rb.isKinematic = false;
    }
}
