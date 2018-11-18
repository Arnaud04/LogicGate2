using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class drag_gate : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{

    public bool fix;
    public UnityEngine.GameObject node_in1,node_in2,node_out;
    public obj_output obj_enter1, obj_enter2;
    public obj_input obj_src;
    
    public float width_c, height_c;// size of central picture x = with_c ;; y = height_c
    public float margin_x = 8;
    public float margin_y = 20;
    
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
            pos.x = eventData.position.x - (width_c * (float) 0.5) + margin_x;
           

            if (node_in2 != null)
            {
                /* suppression partie graphique*/
                obj_enter1.DeletePath();
                obj_enter1.Unlinkin();
                obj_enter2.DeletePath();
                obj_enter2.Unlinkin();

                obj_src.NewPath();
                obj_src.Unlinkout();


                /*mise à jour de la position*/
                pos.y = eventData.position.y + margin_y;
                node_in1.transform.position = pos;
                pos.y = pos.y - 2 * margin_y;
                node_in2.transform.position = pos;

                pos.x = pos.x + (width_c ) - 2*margin_x;
                pos.y = pos.y + margin_y;
                node_out.transform.position = pos;



            }
            else
            {
                /* suppression partie graphique*/
                obj_enter1.DeletePath();
                obj_enter1.Unlinkin();

                obj_src.NewPath();
                obj_src.Unlinkout();


                /*mise à jour de la position*/
                pos.y = eventData.position.y;
                node_in1.transform.position = pos;

                pos.x = pos.x + width_c - 2*margin_x;
                node_out.transform.position = pos;

            }

            

           

        }
    }

    public void OnEndDrag(PointerEventData eventData)
    {



    }

    public void Start()
    {
        if (margin_y == 0) margin_y = 20;

        if (margin_x == 0) margin_x = 8;
    }
}
