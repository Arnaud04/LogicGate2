using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class source_out : MonoBehaviour {


    public controller_link control;
    public obj_output obj_out;
    void OnTriggerEnter2D(Collider2D col)
    {

        control.Setout(obj_out);
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
