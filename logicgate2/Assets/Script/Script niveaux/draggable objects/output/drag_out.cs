﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class drag_out : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{

    public bool fix;
    public UnityEngine.GameObject node;
    private Vector2 pos;
    public obj_output obj_out;
    public void OnBeginDrag(PointerEventData eventData)
    {


    }
    public void OnDrag(PointerEventData eventData)
    {
        if (fix == false)
        {
            /*  this.transform.position = eventData.position;*/
            obj_out.DeletePath();
            obj_out.Unlinkin();
            pos.x = eventData.position.x;
            pos.y = eventData.position.y;
            node.transform.position = pos;

        }
    }

    public void OnEndDrag(PointerEventData eventData)
    {



    }
}
