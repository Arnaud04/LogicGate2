using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class dragging : MonoBehaviour,IBeginDragHandler, IDragHandler, IEndDragHandler
{
   
    Vector2 pos;
    public bool fix = false;
    // Use this for initialization

    public void OnBeginDrag(PointerEventData eventData)
    {
       
       
    }
    public void OnDrag(PointerEventData eventData)
    {
        if (fix == false) this.transform.position = eventData.position;
    }

    public void OnEndDrag(PointerEventData eventData)
    {

        

    }
}
