using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

public enum cardType { Attack, Defend, Potion, BuffDebuff };
public enum characterType { GatotKaca };

[CreateAssetMenu(menuName = "Custom Asset/Card Asset")]
public class baseCard : ScriptableObject
{
    [Header("Card General Properties")]
    public string cardName;

    [Header("Card Uniqueness")]
    public cardType typeCard;
    public characterType heroName;
    public int cardCost;
    public GameObject cardModel;

    [Header("Card Value")]
    [Description("IF THERE ARE NO PUT 1")] public int BaseValue = 1; // IF THERE ARE NO PUT 0 
}
