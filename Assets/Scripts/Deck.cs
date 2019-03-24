using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Deck : MonoBehaviour, IPointerDownHandler
{
    public DeckData deckdata;

    // Start is called before the first frame update
    void Start()
    {
        GenerateDeckList();

        deckdata.discard = new List<Card>();
        deckdata.removed = new List<Card>();
        deckdata.hand = new List<Card>();

        DrawCard(); 
    }


    public void OnPointerDown(PointerEventData eventData)
    {
        DrawCard();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void GenerateDeckList()
    {
        CreateCard("Move Forward", "Move your character forward 1 space", 1);
        List<Card> cards = new List<Card>
        {
            CreateCard("Move Forward", "Move your character forward 1 space", 1 ),
            CreateCard("Move Forward", "Move your character forward 1 space", 1),
            CreateCard("Move Forward", "Move your character forward 1 space", 1),
            CreateCard("Move Forward", "Move your character forward 1 space", 1),
            CreateCard("Move Back", "Move your character backwards 1 space", 1),
            CreateCard("Move Back", "Move your character backwards 1 space", 1),
            CreateCard("Move Back", "Move your character backwards 1 space", 1),
            CreateCard("Move Back", "Move your character backwards 1 space", 1),
            CreateCard("Turn Left", "Turn your character left", 1),
            CreateCard("Turn Left", "Turn your character left", 1),
            CreateCard("Turn Left", "Turn your character left", 1),
            CreateCard("Turn Left", "Turn your character left", 1),
            CreateCard("Turn Right", "Turn your character right", 1),
            CreateCard("Turn Right", "Turn your character right", 1),
            CreateCard("Turn Right", "Turn your character right", 1),
            CreateCard("Turn Right", "Turn your character right", 1),
            CreateCard("Dash Forward", "Move your character forward 2 spaces", 2),
            CreateCard("Dash Forward", "Move your character forward 2 spaces", 2),
            CreateCard("Dash Forward", "Move your character forward 2 spaces", 2),
            CreateCard("Dash Forward", "Move your character forward 2 spaces", 2),

        };

        deckdata.deck = new List<Card>(cards);
    }

    Card CreateCard(string cardName, string cardDescription, int cardCost) 
    {
        Card card = ScriptableObject.CreateInstance<Card>();
        card.name = cardName;
        card.description = cardDescription;
        card.cost = cardCost;
        return card;

    }


    Card TakeCard(List<Card> source, int index)
    {
        if (source.Count > 0)
        {
            Card card = source[0];
            source.Remove(card);
            return card;
        }
        return null;
    }

    void AddCard(List<Card> target, Card card)
    {
        target.Add(card);
    }

    void DrawCard()
    {
        Card card = TakeCard(deckdata.deck, 0);
        AddCard(deckdata.hand, card);
    }

}
