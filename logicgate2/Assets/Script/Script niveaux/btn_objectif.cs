using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class btn_objectif : MonoBehaviour {


    public GameObject objectif;
    private bool state = false;

    public void ChangeActive()
    {
        if(state == false)
        {
            state = true;
            objectif.SetActive(state);
        }
        else
        {
            state = false;
            objectif.SetActive(state);

        }
    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
