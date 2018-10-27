using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class drag_gate : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{

    public bool fix;
    public GameObject node_in1,node_in2,node_out;
    public int width_c, height_c;// size of central picture
   
    private Vector2 pos;
    public void OnBeginDrag(PointerEventData eventData)
    {


    }
    public void OnDrag(PointerEventData eventData)
    {
        if (fix == false)
        {
            // seat centrale picture
            this.transform.position = eventData.position;

            // place first input
            pos.x = eventData.position.x - 52;
           

            if (node_in2 != null)
            {

                pos.y = eventData.position.y + 35;
                node_in1.transform.position = pos;
                pos.y = pos.y - 70;
                node_in2.transform.position = pos;

                pos.x = pos.x + 105;
                pos.y = pos.y + 35;
                node_out.transform.position = pos;



            }
            else
            {
                pos.y = eventData.position.y;
                node_in1.transform.position = pos;

                pos.x = pos.x + 105;
                node_out.transform.position = pos;

            }

            

           

        }
    }

    public void OnEndDrag(PointerEventData eventData)
    {



    }
}
