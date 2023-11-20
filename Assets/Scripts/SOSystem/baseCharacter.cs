using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum classType { Warrior, Mage, Unknown };

[CreateAssetMenu(menuName = "Custom Asset/Character Asset")]
public class baseCharacter : ScriptableObject
{
    [Header("Character General")]
    public string characterName;

    [Header("Character Attribute")]
    public classType clasType;
    public float charScale;
    public float charATK;
    public float charDEF;
    public float charHP;
}
