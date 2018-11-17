using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class transmitter : MonoBehaviour {


    public controller_link control;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        control.Ordertocut();    
    }

    // doit couper la ligne  entrain d'etre drag sans avoir transmettre l'état

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
