using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Draggable : MonoBehaviour
{
    //[SerializeField]
    private RectTransform rt;

    private Vector3 lastMousePos;
    private Vector3 lastMenuPos;
    private Vector3 currentMousePos;
    private float Distance;

    // Start is called before the first frame update
    void Start()
    {
        rt = GetComponent<RectTransform>();
    }

    // Update is called once per frame
    void Update()
    {
        currentMousePos = Input.mousePosition;

        if (Input.GetMouseButton(0))
        {
            Dragging();
        } 
        else
        {
            Distance = 0;
            lastMousePos = currentMousePos;
            lastMenuPos = rt.localPosition;
        }
    }
    
    void Dragging()
    {
        float newXPosition = lastMenuPos.x + Distance;
        Vector3 newPosition;

        Debug.Log(newXPosition);

        if (newXPosition < -656.84f)
        {
            lastMousePos = currentMousePos;
            lastMenuPos = rt.localPosition;
            newXPosition = -656.84f;
        }
        else if (newXPosition > 656.84f)
        {
            lastMousePos = currentMousePos;
            lastMenuPos = rt.localPosition;
            newXPosition = 656.84f;
        }

        Distance = currentMousePos.x - lastMousePos.x;

        newPosition = new Vector3(newXPosition, lastMenuPos.y, lastMenuPos.z);
        rt.localPosition = newPosition;
    }
}
