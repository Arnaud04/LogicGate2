using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obj_input : MonoBehaviour {

    public scinput ininfo;// l'objet sur lequel on se trouve
    private obj_output outinfo;

    public void Setout(obj_output newout)
    {
        outinfo = newout;
    }


    public void Unsetout()
    {
        outinfo = null;
    }


    public int Getinstate()
    {
        return ininfo.GetState();
    }

    public int Getoutstate()
    {
        return outinfo.Getoutstate();
    }


    public bool OutIsnotnull()
    {
        if (outinfo == null) return false;
        return true;
    }

    public void NewPath()
    {

        if(outinfo != null)
            outinfo.DeletePath();
    }
    public void Unlinkout()
    {
        if (outinfo != null)
        {
            Debug.Log("ancien lien supprimé");
            outinfo.Unsetin();
            outinfo.Setdg(null);
            Unsetout();
        }
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
