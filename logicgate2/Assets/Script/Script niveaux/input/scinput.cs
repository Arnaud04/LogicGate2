using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scinput : MonoBehaviour {

    public bool state;
    public GameObject on, off;
    private Vector3 mine;
    public bool fix_drag, fix_value;
    private  bool dragged;// savoir si elle à était posé
   // public GameObject copyon, copyoff, copysource,parent;

	// Use this for initialization
	void Start () {
        mine = this.transform.position;

        if (state == true) off.SetActive(false);
        else on.SetActive(false);
        dragged = false;

       // Instantiate(copyon,transform.parent);
       
            
	}

    private void Instantiate(GameObject copyon, GameObject parent)
    {
        throw new NotImplementedException();
    }

    public bool GetState()
    {

        return state;
    }

    public void Setdraggedtrue()
    {
        dragged = true;
    }

    public void Setdraggedfalse()
    {
        dragged = false;
    }

    public bool Getdragged()
    {
        return dragged;
    }
    public void ChangeState()
    {
       
        
        if ( Vector3.Equals( mine , this.transform.position) && fix_value == false)// if input didn't moved, change the state
        {
            Debug.Log("deplacement");
          
            if (state == true)
            {
                state = false;
                on.SetActive(false);
                off.SetActive(true);
            }
            else
            {
                state = true;
                on.SetActive(true);
                off.SetActive(false);
            }
        }

       
        mine = this.transform.position;// the current position


    }
	// Update is called once per frame
	void Update () {
		
	}
}
