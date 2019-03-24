using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragHandler : MonoBehaviour, IDragHandler, IEndDragHandler
{
    public GameObject DropArea;

    private Vector3 startPosition;
    private Vector3 moveStart;
    public Vector3 moveTarget;
    private bool isMoving;
    private float moveTime;
    private float movePercentComplete;

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

        }
        else
        {
            Debug.Log("Returning:" + startPosition);
            moveTarget = transform.position;
            MoveToPosition(startPosition, 0.3f);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position;
        moveTarget = startPosition;
        isMoving = false;
        moveTime = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (isMoving && movePercentComplete <= 1)
        {
           Debug.Log(transform.position + " - " + transform.localPosition + " - " + moveTarget + " - " + gameObject.name);
            movePercentComplete += Time.deltaTime / moveTime; 
            transform.position = Vector3.Lerp(moveStart, moveTarget, movePercentComplete);
            //Debug.Log(isMoving + " - " + movePercentComplete + " - " + (movePercentComplete > 1));

            isMoving = !(movePercentComplete > 1);
        }
    }

    public void MoveToPosition(Vector3 position, float timeToMove)
    {
        Debug.Log(moveTarget + " - " + position);

            Debug.Log("MoveToPosition:" + position.x);
            moveStart = Input.mousePosition;
            moveTarget = position;
            moveTime = timeToMove;
            movePercentComplete = 0;
            isMoving = true;
    }
}
