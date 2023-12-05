using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PanControl : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    [SerializeField] private GameObject Levels;
    [SerializeField] private float panDirection;

    private LevelPanning lp;

    void Awake()
    {
        lp = Levels.GetComponent<LevelPanning>();
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        lp.SetPanDirection(panDirection);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        lp.SetPanDirection(0f);
    }
}
