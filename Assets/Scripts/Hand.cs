using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hand : MonoBehaviour
{
    [SerializeField]
    public GameObject cardClass;

    [SerializeField]
    public DeckData deckData;

    [SerializeField]
    public float cardRotation;

    [SerializeField]
    public float cardRotationDecay;

    [SerializeField]
    public float cardHeightOffsetMax;


    public Dictionary<Card, GameObject> cardDisplays;

    // Start is called before the first frame update
    void Start()
    {
        cardDisplays = new Dictionary<Card, GameObject>();
        cardRotation = 30;
        cardRotationDecay = 3;
        cardHeightOffsetMax = 50;

    }

    // Update is called once per frame
    void Update()
    {
        float leftOffset = 400f;
        float rotationChange = cardRotation - (cardRotationDecay * cardDisplays.Count);
        float rotationOffset = rotationChange * (0.5f * (cardDisplays.Count-1));
        float heightChange = 0f;


        foreach (Card card in deckData.hand)
        {
            GameObject cardObject;
            if (card && !cardDisplays.ContainsKey(card))
            {
                cardObject = Instantiate(cardClass, transform);
                cardObject.name = "Card - " + card.name;
                CardDisplay cardDisplay = cardObject.GetComponent<CardDisplay>();
                cardDisplay.card = card;
                cardDisplays.Add(card, cardObject);

            }

            cardObject = cardDisplays[card];
            DragHandler dragHandler = cardObject.GetComponent<DragHandler>();
            heightChange = ((System.Math.Abs(rotationOffset) / cardRotation)) * cardHeightOffsetMax; 

            Vector3 moveTarget = new Vector3(leftOffset, 300 - heightChange);

            DragRotator dragRotator = cardObject.GetComponent<DragRotator>();
            cardObject.transform.eulerAngles = new Vector3(0, 0, rotationOffset);
            dragRotator.m_originalAngles = cardObject.transform.localRotation.eulerAngles;

            if (!dragHandler.moveTarget.Equals(moveTarget))
            {
                dragHandler.MoveToPosition(moveTarget, 0.2f);
            }

            rotationOffset -= rotationChange;
            leftOffset += 100f;
            //cardDisplay.transform.SetPositionAndRotation(new Vector3(0, 0), new Quaternion());

        }

    }
}
