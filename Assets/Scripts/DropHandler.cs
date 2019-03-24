using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DropHandler : MonoBehaviour, IDropHandler
{
    public GameObject DropArea;

    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log("Drop!");
        RectTransform dropAreaSize = DropArea.transform as RectTransform;

        if(RectTransformUtility.RectangleContainsScreenPoint(dropAreaSize, Input.mousePosition))
        {
            //TODO:Add card action to action queue
            Object.Destroy(gameObject);
        }
    }
}
