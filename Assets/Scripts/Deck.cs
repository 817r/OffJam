using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Collections;
using UnityEngine;

public class Deck : MonoBehaviour
{
    public List<baseCard> card = new List<baseCard>();
    public List<baseCard> deck = new List<baseCard>();
    void Start()
    {
        baseCard[] card = Resources.LoadAll<baseCard>("Deck/");

        for(int i = 0; i<card.Length;i++)
        {
            switch(card[i].cardName)
            {
                case "Swift Strike":
                    deck.Add(card[i]);
                    deck.Add(card[i]);
                    deck.Add(card[i]);
                    break;
                
                case "Spirit Wave":
                    deck.Add(card[i]);
                    deck.Add(card[i]);
                    break;
                
                case "Berserk":
                    deck.Add(card[i]);
                    deck.Add(card[i]);
                    break;
                
                case "Luminescent Armor":
                    deck.Add(card[i]);
                    deck.Add(card[i]);
                    break;

                case "Celestial Shield":
                    deck.Add(card[i]);
                    deck.Add(card[i]);
                    break;

                case "Dual Exchange":
                    deck.Add(card[i]);
                    break;

                case "Elixir":
                    deck.Add(card[i]);
                    deck.Add(card[i]);
                    deck.Add(card[i]);
                    break;
                
                case "Red Herb":
                    deck.Add(card[i]);
                    break;
                
                case "White Herb":
                    deck.Add(card[i]);
                    break;

                case "Meditation":
                    deck.Add(card[i]);
                    break;

                case "Salt Bag":
                    deck.Add(card[i]);
                    break;

                case "Blessed Offering":
                    deck.Add(card[i]);
                    break;
            }
        }

        // Debug.Log(deck.Count);
        // foreach(var cardName in deck)
        // {
        //     Debug.Log(cardName);
        // }
    }
}
