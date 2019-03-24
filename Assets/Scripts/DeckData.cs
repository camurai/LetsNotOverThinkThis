using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Deck", menuName = "Deck")]
public class DeckData : ScriptableObject
{
    public List<Card> deck;
    public List<Card> discard;
    public List<Card> removed;
    public List<Card> hand;
}
