using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class drag_in : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{

    Vector2 pos;
    public GameObject node;
    public scinput in0;
    private float time;
   

    // Use this for initialization

    public void OnBeginDrag(PointerEventData eventData)
    {
        time = Time.time;

    }
    public void OnDrag(PointerEventData eventData)
    {
        if (in0.fix_drag == false)
        {
            if (in0.Getdragged() == false || (in0.Getdragged() == true && Time.time - time > 0.5))
            {
                this.transform.position = eventData.position;
                pos.x = eventData.position.x + 40;
                pos.y = eventData.position.y ;
                node.transform.position = pos;
            }
        }
    }

    public void OnEndDrag(PointerEventData eventData)
    {



    }
}

