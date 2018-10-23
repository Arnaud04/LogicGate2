using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scinput : MonoBehaviour {

    public bool state;
    public GameObject on, off;
    private Vector3 mine;
    public bool fix_d,fix_value;

	// Use this for initialization
	void Start () {
        mine = this.transform.position;

        if (state == true) off.SetActive(false);
        else on.SetActive(false);
       
            
	}
	

    public bool GetState()
    {

        return state;
    }
    public void ChangeState()
    {
       
        
        if ( Vector3.Equals( mine , this.transform.position) && fix_value == false)// if input didn't moved, change the state
        {

          
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
