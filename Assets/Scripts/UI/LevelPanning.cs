using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class LevelPanning : MonoBehaviour
{
    [SerializeField] private float speed = 2.5f;

    private float panningDirection;
    private RectTransform rt;

    // Start is called before the first frame update
    void Awake()
    {
        rt = GetComponent<RectTransform>();
    }

    // Update is called once per frame
    void Update()
    {
        float dist = panningDirection * speed;
        if (dist == 0f) return;

        float newPos = rt.localPosition.x + dist;
        if (newPos < -656.84f) newPos = -656.84f;
        else if (newPos > 656.84f) newPos = 656.84f;

        rt.localPosition = new Vector3(newPos, rt.localPosition.y, rt.localPosition.z);
    }

    public void SetPanDirection(float direction)
    {
        panningDirection = direction;
    }
}
