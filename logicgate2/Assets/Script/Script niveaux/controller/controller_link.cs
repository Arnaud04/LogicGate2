using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controller_link : MonoBehaviour {


    private obj_output  outobj;// les sources d'entré et de sortie vont nous servir à passer la porte, sortie ou entré
    private obj_input inobj;
    private drag_source drag_src;
    private bool inuse, outuse;// savoir si l'un est selectionné

	// Use this for initialization
	void Start () {
        inobj = null;
        outobj = null;
        inuse = false;
        outuse = false;
	}

    public void SetDragSrc(drag_source dg_src)
    {
        drag_src = dg_src;
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


            if (outobj.Getdg() != null && outobj.Getdg() !=  drag_src)// si le chemin est  tracé et n'est un ancien chemin (  permet de supprimer le chemin si relier plusieurs fois au meme objet avec un autre )
                outobj.DeletePath();

            outobj.Setdg(drag_src);
            outobj.Setin(inobj);// sortie recup l'état
            inobj.Setout(outobj);
            drag_src.ValidPath();                  

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


    public void Ordertocut()
    {
        drag_src.CutLink();
    }

    // Update is called once per frame
    void Update () {
		
	}
}
