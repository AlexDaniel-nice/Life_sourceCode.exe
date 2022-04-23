using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Drag_and_Drop_commands : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler, IDropHandler
{
    [SerializeField] private Canvas Canvas;

    private RectTransform butonComenzi;
    private CanvasGroup InteractableObjects;

    private void Awake()
    {
        butonComenzi = this.GetComponent<RectTransform>();
        InteractableObjects = this.GetComponent<CanvasGroup>();
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("OneginDrag");
        InteractableObjects.blocksRaycasts = false;
    }

    public void OnDrag(PointerEventData eventData)
    {
        Debug.Log("onDrag");
        butonComenzi.anchoredPosition += eventData.delta / Canvas.scaleFactor;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("OnEndDrag");
        InteractableObjects.blocksRaycasts = true;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("Pressed");
       // Instantiate(GameAssets.GetInstance.buton_if); //asta vine in locul lui butonului initial

        //butonComenzi = instance.getComponent<RectTransform>();

    }

    public void OnDrop(PointerEventData eventData)
    {
        throw new System.NotImplementedException();
    }
}
