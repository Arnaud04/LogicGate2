using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class dragging : MonoBehaviour,IBeginDragHandler, IDragHandler, IEndDragHandler
{
    float time;
    Vector2 pos;
    // Use this for initialization

    public void OnBeginDrag(PointerEventData eventData)
    {
        pos = transform.position;
        time = Time.realtimeSinceStartup;
       
    }
    public void OnDrag(PointerEventData eventData)
    {
        this.transform.position = eventData.position;
    }

    public void OnEndDrag(PointerEventData eventData)
    {

        if( (Time.realtimeSinceStartup - time) < 0.5)
        {
            this.transform.position = pos;
        }

    }
}
