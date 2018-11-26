using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class instanciation : MonoBehaviour {

    // Use this for initialization
    public string space;
    public float x_start, y_start;
    public GameObject me;
    
    public copy_obj copier;
    public selfdestruct self;
    public int hierarchy_index;
   
    public void Createobj()
    {
        if (self.AskRightCreate() == 1) return;

        Vector3 vec;
        Quaternion q;
        q.x = 0;
        q.y = 0;
        q.z = 0;
        q.w = 0;

        vec.x = x_start;
        vec.y = y_start;
        vec.z = 0;
        self.Setcollision(1);
        copier.copyobj(me, vec, q, hierarchy_index);
        self.Setcollision(0);
    }   
    void OnTriggerExit2D(Collider2D col)
    {

       
        if (col.name == space)
        {
            if (self.AskRightCreate() == 1) return;
            Createobj();
            Debug.Log("exit of space and create");
           

            
          
        }
    }
    void Start () {
        if (space == null) space = "instantiatespace";
       
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
