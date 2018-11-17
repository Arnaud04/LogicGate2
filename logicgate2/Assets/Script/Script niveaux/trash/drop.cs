using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drop : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnTriggerEnter2D(Collider2D coll)
    {

        selfdestruct me = coll.GetComponent<selfdestruct>();
        Destroy(me.me);
    }
}
