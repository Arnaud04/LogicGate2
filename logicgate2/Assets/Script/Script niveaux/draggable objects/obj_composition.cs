using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obj_composition : MonoBehaviour {


    public GameObject obj, source_out, source_in1, source_in2, central;
    public float src_o_x, src_o_y, src_i1_x, src_i1_y, src_i2_x, src_i2_y, c_x, c_y;
    Vector3 vec;
    // Use this for initialization
    void Setvec(float x,float y,float z)
    {
        vec.x = x;
        vec.y = y;
        vec.z = z;
    }
	void Start () {

        Setvec(src_o_x, src_o_y, 0);
        source_out.transform.localPosition = vec;

        Setvec(src_i1_x, src_i1_y, 0);
        source_in1.transform.localPosition = vec;

        Setvec(src_i2_x, src_i2_y, 0);
        source_in2.transform.localPosition = vec;

        Setvec(c_x, c_y, 0);
        central.transform.localPosition = vec;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
