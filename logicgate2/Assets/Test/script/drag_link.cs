using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class drag_link : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    public GameObject source;
    public Material material;
    private Vector3 spot;
    private LineRenderer line;
    
    public void OnBeginDrag(PointerEventData eventData)
    {

        

    }
    public void OnDrag(PointerEventData eventData)
    {
        line.material = material;
        Vector3[] pos = new Vector3[2];
        line.startWidth = 5;
        line.endWidth = 5;
        pos[0] = source.transform.position;
        spot = eventData.position;
        spot.z = 100;
        pos[1] = spot;
        line.positionCount = 2;
        line.SetPositions(pos);
    }

    public void OnEndDrag(PointerEventData eventData)
    {

        

    }
    // Use this for initialization
    void Start () {
        line = this.gameObject.AddComponent<LineRenderer>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
