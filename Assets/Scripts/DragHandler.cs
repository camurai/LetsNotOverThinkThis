using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragHandler : MonoBehaviour, IDragHandler, IEndDragHandler
{
    public GameObject DropArea;

    private Vector3 startPosition;

    public void OnDrag(PointerEventData eventData)
    {
        transform.position = Input.mousePosition;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        if (Input.mousePosition.y > 470)
        {
            //TODO:Add card action to action queue
            Debug.Log("Card Played!");
            Object.Destroy(gameObject);
        }
        else
        {
            transform.localPosition = startPosition;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.localPosition; 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
