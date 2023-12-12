using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Hover : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public GameObject cardDesc;

    public void OnPointerEnter(PointerEventData eventData)
    {
        cardDesc.SetActive(true);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        cardDesc.SetActive(false);
    }
}
