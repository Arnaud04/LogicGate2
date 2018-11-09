using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controller_link : MonoBehaviour {


    private obj_output  outobj;// les sources d'entré et de sortie vont nous servir à passer la porte, sortie ou entré
    private obj_input inobj;
    private bool inuse, outuse;// savoir si l'un est selectionné

	// Use this for initialization
	void Start () {
        inobj = null;
        outobj = null;
        inuse = false;
        outuse = false;
	}

   public void Setin(obj_input newinobj)
    {
        inobj = newinobj;
        inuse = true;
        inobj.Unlinkout();
        Debug.Log("entré selectionné");
    }
    public void Setout(obj_output newoutobj)
    {
        if(inuse == true)
        {
            Debug.Log("output selected");
            outobj = newoutobj;
            outuse = true;
            outobj.Unlinkin();

            outobj.Setin(inobj);// sortie recup l'état
            inobj.Setout(outobj);// à remplacer par la fonction de dessin
                               

            inobj = null;
            inuse = false;
            outobj = null;
            outuse = false;

        }
        else
        {
            Debug.Log("selectionné d'abord une entré");
        }
    }


    // Update is called once per frame
    void Update () {
		
	}
}
