﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class g_no : MonoBehaviour {

    //public GameObject in1, output;// entry gates and output
    public UnityEngine.GameObject on, off; // image of state of gate

    public obj_output in1;
    public obj_input exit;
    public bool fix;// draging possible?
    private int state;
    public selfdestruct self;


    // Use this for initialization
    void Start () {

        state = 0;
        
	}
	
   


    public int ExitOfGate()
    {


        if (in1.InIsnotnull() == true  && in1.outinfo.GetState() != 0)
        {
            self.condition.SetLink(true);
            if (in1.outinfo.GetState() == 2)
            {
                state = 1;
                self.condition.SetLight(false);
                return state;
            }
            else
            {
                state = 2;
                self.condition.SetLight(true);
                return state;
            }
        }
        else
        {
            state = 0;
            self.condition.SetLink(false);
            self.condition.SetLight(false);
            return 0;
        }
    }
    // Update is called once per frame
    void Update () {

        exit.ininfo.SetState(ExitOfGate());  
	}
}
