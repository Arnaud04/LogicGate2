using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obj_composition : MonoBehaviour {


    public GameObject obj =null , source_out = null , source_in1 = null, source_in2 = null , central = null;
    public float src_o_x, src_o_y, src_i1_x, src_i1_y, src_i2_x, src_i2_y, c_x, c_y;
    public bool start_with_vec = false;
    Vector3 vec;
    // Use this for initialization
    void Setvec(float x,float y,float z)
    {
        vec.x = x;
        vec.y = y;
        vec.z = z;
    }
	void Start () {

        if (start_with_vec)
        {
            if (source_out != null)
            {
                Setvec(src_o_x, src_o_y, 0);
                source_out.transform.localPosition = vec;
            }
            

            if(source_in1 != null)
            {
                Setvec(src_i1_x, src_i1_y, 0);
                source_in1.transform.localPosition = vec;
            }
           
            if(source_in2 != null)
            {
                Setvec(src_i2_x, src_i2_y, 0);
                source_in2.transform.localPosition = vec;
            }
         
            if(central != null)
            {
                Setvec(c_x, c_y, 0);
                central.transform.localPosition = vec;
            }
            
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
