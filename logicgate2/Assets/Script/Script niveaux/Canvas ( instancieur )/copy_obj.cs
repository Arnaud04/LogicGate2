using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class copy_obj : MonoBehaviour {

    // Use this for initialization
    public GameObject father;
    

    public void copyobj(GameObject obj ,Vector3 vec,Quaternion q, int index)
    {

        GameObject newme = Instantiate(obj, father.transform,false);
        //   newme.transform.position = vec;// permit to config object before collision with some objects
        Debug.Log(" copie d'objet");
        newme.transform.SetSiblingIndex(index);
        newme.transform.localPosition = vec;// place him on his spawn ( visible for player);
      

    }
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
