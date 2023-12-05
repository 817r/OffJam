using System.Collections;
using System.Collections.Generic;
using Microsoft.Unity.VisualStudio.Editor;
using UnityEngine;

public enum cardType { Attack, Defend, Potion, BuffDebuff };

[CreateAssetMenu(menuName = "Custom Asset/Card Asset")]
public class baseCard : ScriptableObject
{
    [Header("Card General Properties")]
    public string cardName;
    public Sprite image;
    public string cardDesc;

    [Header("Card Uniqueness")]
    public cardType typeCard;
    public int cardCost;
}
