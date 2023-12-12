using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class CardDisplay : MonoBehaviour
{
    public baseCard card;

    public TMP_Text cardName;
    public TMP_Text description;
    public Image image;
    public TMP_Text cardCost;
    public GameObject cardDesc;

    void Start(){
        cardName.text = card.cardName;
        description.text = card.cardDesc;
        image.sprite = card.image;
        cardCost.text = card.cardCost.ToString();
    }

    
}
