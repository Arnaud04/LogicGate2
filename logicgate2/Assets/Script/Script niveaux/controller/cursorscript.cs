using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cursorscript : MonoBehaviour {

    public UnityEngine.GameObject cursor;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        cursor.transform.position = Input.mousePosition;

	}
}
