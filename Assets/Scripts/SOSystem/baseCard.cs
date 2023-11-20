using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum cardType { Attack, Defend, Potion };

[CreateAssetMenu(menuName = "Custom Asset/Card Asset")]
public class baseCard : ScriptableObject
{
    [Header("Card General Properties")]
    public string cardName;

    [Header("Card Uniqueness")]
    public cardType typeCard;
    public int cardCost;
    public int cardValue;
}
