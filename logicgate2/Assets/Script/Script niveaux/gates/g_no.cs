using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class g_no : MonoBehaviour {

    public GameObject in1, output;// entry gates and output
    public GameObject on, off; // image of state of gate
    public bool fix;// draging possible?
    private bool state;

	// Use this for initialization
	void Start () {
        in1 = null;
        
        output = null;
	}
	
    public void LinkIn1(GameObject first)
    {
        in1 = first;
    }
   
    public void LinkOutput(GameObject exit)
    {
        output = exit;
    }

    public void UnlinkIn1()
    {
        in1 = null;
    }
    
    public void UnlinkOutput()
    {
        output = null;
    }


    public bool ExitOfGate()
    {
       
        if ( true) {
            state = false;
            return state;
        }
        else {
            state = true;
            return state;
        }
    }
    // Update is called once per frame
    void Update () {
		
            
	}
}
