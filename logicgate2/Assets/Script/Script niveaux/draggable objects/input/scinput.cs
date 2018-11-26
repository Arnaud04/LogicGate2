using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scinput : MonoBehaviour {

    public int state;// 0 non connecté; 1 faux ; 2 vrai
    public UnityEngine.GameObject on = null, off = null,source;
    private Vector3 mine;
    public bool fix_drag, fix_value;
    private  bool dragged;// savoir si elle à était posé
   // public GameObject copyon, copyoff, copysource,parent;

	// Use this for initialization
	void Start () {
        mine = this.transform.position;
        
        if (state == 2 && off != null) off.SetActive(false);
        else if( on != null)on.SetActive(false);
        dragged = false;

       // Instantiate(copyon,transform.parent);
       
            
	}

    private void Instantiate(UnityEngine.GameObject copyon, UnityEngine.GameObject parent)
    {
        throw new NotImplementedException();
    }

    public void SetState(int newstate)
    {
        state = newstate;
    }
    public int GetState()
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
            Debug.Log("deplacement"+ state);

            if (state == 2)
            {
                state = 1;
                if (on != null && off != null)
                {
                    on.SetActive(false);
                    off.SetActive(true);
                }
            }
            else
            {
                if (state == 1)
                {
                    state = 2;
                    if (on != null && off != null)
                    {
                        on.SetActive(true);
                        off.SetActive(false);
                    }
                }
            }
        }

       
        mine = this.transform.position;// the current position


    }
	// Update is called once per frame
	void Update () {
		
	}
}
