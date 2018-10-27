using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class drag_out : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{

    public bool fix;
    public GameObject node;
    private Vector2 pos;
    public void OnBeginDrag(PointerEventData eventData)
    {


    }
    public void OnDrag(PointerEventData eventData)
    {
        if (fix == false)
        {
            this.transform.position = eventData.position;
            pos.x = eventData.position.x - 40;
            pos.y = eventData.position.y;
            node.transform.position = pos;

        }
    }

    public void OnEndDrag(PointerEventData eventData)
    {



    }
}
