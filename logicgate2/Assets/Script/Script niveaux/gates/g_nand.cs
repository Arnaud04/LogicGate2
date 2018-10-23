using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class g_nand : MonoBehaviour {

    // Use this for initialization
    public GameObject in1, in2, output;// entry gates and output
    public GameObject on, off; // image of state of gate
    public bool fix;// draging possible?

    // Use this for initialization
    void Start()
    {
        in1 = null;
        in2 = null;
        output = null;
    }

    public void LinkIn1(GameObject first)
    {
        in1 = first;
    }
    public void LinkIn2(GameObject second)
    {
        in2 = second;
    }
    public void LinkOutput(GameObject exit)
    {
        output = exit;
    }

    public void UnlinkIn1()
    {
        in1 = null;
    }
    public void UnlinkIn2()
    {
        in2 = null;
    }
    public void UnlinkOutput()
    {
        output = null;
    }


    public bool ExitOfGate()
    {


        return false;

        return true;
    }

    // Update is called once per frame
    void Update () {
		
	}
}
