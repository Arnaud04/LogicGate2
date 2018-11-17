using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class selfdestruct : MonoBehaviour {

    public UnityEngine.GameObject me;
    public int collisiondestruct;
	// Use this for initialization
	

    void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("collision");
        if (collisiondestruct > 0 && collision.name == "instantiatespace") collisiondestruct--;
        else
        {
            if (collision.name == "instantiatespace")  Destroy(me);
        }
            
    }

    public void Setcollision(int nb)
    {
        collisiondestruct = nb;

    }
    void Start()
    {
       

    }

    // Update is called once per frame
    void Update () {
		
	}
}
