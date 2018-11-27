using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obj_output : MonoBehaviour {

    public scoutput outinfo;// l'objet sur lequel on se trouve
    private obj_input ininfo;
    private drag_source dg_src  = null; // used to delete previous graphic path
    public bool pit = false;
    public selfdestruct self = null;// laisser null si dans autre chose que un puit de sortie (ou source recevante,taker)

    // Use this for initialization
    public  void Setin(obj_input newin)
    {
        ininfo = newin;
        outinfo.ChangeState(ininfo.ininfo.GetState());
    }
    
    public void Setdg(drag_source dg)
    {
        dg_src = dg;
    }

    public void Unsetdg()
    {
        dg_src = null;
    }


    public drag_source Getdg()
    {
        return dg_src;
    }

    public void DeletePath()
    {
        if(dg_src != null)
             dg_src.NewPath();
    }
    public void Unsetin()
    {
        ininfo = null;
        outinfo.ChangeState(0);
    }

    public void Unlinkin()
    {
        if(ininfo != null)
        {
            ininfo.Unsetout();
           
            Unsetin();
        }

    }
	void Start () {
        ininfo = null;
        outinfo.ChangeState(0);

    }
	
    public bool InIsnotnull()
    {
        if(ininfo != null)return true;
        return false;
    }

    public int Getinstate()
    {
        return ininfo.ininfo.GetState();
    }

    public int Getoutstate()
    {
        return outinfo.GetState();
    }
	// Update is called once per frame
	void Update () {
		
        if(ininfo != null)
        {
            int state = ininfo.ininfo.GetState();
            if (pit == true)
            {
                if (state == 2)
                {
                    self.condition.SetLight(true);
                    self.condition.SetLink(true);
                }
                if (state != 2)
                {
                    self.condition.SetLight(false);

                    if (state == 0)
                        self.condition.SetLink(false);
                }
            }


            outinfo.ChangeState(state);
        }
	}
}
