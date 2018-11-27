using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class g_xor : MonoBehaviour {

    public obj_output in1, in2;
    public obj_input output;// entry gates and output
    public UnityEngine.GameObject on, off; // image of state of gate
    public bool fix;// draging possible?
    public int state;
    public selfdestruct self;
    // Use this for initialization
    void Start()
    {
        state = 0; 
    }

    


    public int ExitOfGate()
    {

        if ((in1.InIsnotnull() && in2.InIsnotnull()) && (in1.Getinstate() != 0 && in2.Getinstate() != 0))
        {
            self.condition.SetLink(true);
            Debug.Log("les deux sont relié");
                if ((in1.Getinstate() == 1 && in2.Getinstate() == 2) || (in1.Getinstate() == 2 && in2.Getinstate() == 1))
                {
                Debug.Log(" vrai");
                        state = 2;
                         self.condition.SetLight(true);
                        return state;
                    
                    
                }
                else
                {
                     self.condition.SetLight(false);
                     state = 1;
                   return state;
                }
                   
                
        }
        self.condition.SetLink(false);
        self.condition.SetLight(false);
        state = 0;
        return state;
    }

    // Update is called once per frame
    void Update () {
        output.ininfo.SetState(ExitOfGate());
	}
}
