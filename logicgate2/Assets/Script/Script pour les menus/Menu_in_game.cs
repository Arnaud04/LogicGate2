using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu_in_game : MonoBehaviour {

    private button_menu button;
    public GameObject me;
    private GameObject space;
    private GameObject lvl;
    

    public void  ShowMe()
    {
        me.SetActive(true);
       // space.SetActive(false);
    }

    public void HideMe()
    {
        me.SetActive(false);
    }


    public void ContinueGame()
    {
        if(button != null)
        {

            /* quand on réactive un objet de colision il y a colision avec les objets, il faut donc éviter leur destruction non désiré*/
            level_controller lvl_cont = button.GetLvlCont();
            lvl_cont.SaveCauseReactivation();
          
            lvl.SetActive(true);
            HideMe();
            UnSetButton();
           // space.SetActive(true);
            Debug.Log("continue game");
            space = null;
            lvl = null;

        }
    }
    public void SetByButton(button_menu new_button, GameObject newspace,GameObject newlvl)
    {
        button = new_button;
        space = newspace;
        lvl = newlvl;

    }

    public void UnSetButton()
    {
        button = null;
    }
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
