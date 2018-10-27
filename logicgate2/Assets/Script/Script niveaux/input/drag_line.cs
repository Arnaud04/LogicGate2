using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class drag_line : MonoBehaviour,IBeginDragHandler, IDragHandler, IEndDragHandler
{
    protected LineRenderer line;
    private Color linecolor;
    public GameObject source;
    public void OnBeginDrag(PointerEventData eventData)
    {

        line = GetComponent<LineRenderer>();
        line.positionCount = 0;

    }
    public void OnDrag(PointerEventData eventData)
    {
        line.SetPosition(line.positionCount -1, eventData.position);
        line.positionCount++;
        Debug.Log(" dessine");
    }

    public void OnEndDrag(PointerEventData eventData)
    {



    }
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
