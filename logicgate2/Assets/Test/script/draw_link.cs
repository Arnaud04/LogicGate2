using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class draw_link : MonoBehaviour {


    private new Camera camera;

    public Material lineMaterial;
    public float lineWith;
    public float depth = 5;
    private Vector3? lineStartPoint = null;
	// Use this for initialization
	void Start () {
        camera = GetComponent<Camera>();
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetMouseButtonDown(0))
        {
            lineStartPoint = GetMouseCameraPoint();
        }
        else if(Input.GetMouseButtonUp(0))
        {

            if (!lineStartPoint.HasValue)
                return;
            
                var lineEndPoint = GetMouseCameraPoint();
                var gameObject = new UnityEngine.GameObject();
                var lineRenderer = gameObject.AddComponent<LineRenderer>();
                lineRenderer.material = lineMaterial;
                lineRenderer.SetPositions(new Vector3[] { lineStartPoint.Value, lineEndPoint });
                lineRenderer.startWidth = lineWith;
                lineRenderer.endWidth = lineWith;

                lineStartPoint = null;
            
        }
	}

    private Vector3 GetMouseCameraPoint()
    {
        var ray = camera.ScreenPointToRay(Input.mousePosition);
        return ray.origin + ray.direction * depth;
    }
}
