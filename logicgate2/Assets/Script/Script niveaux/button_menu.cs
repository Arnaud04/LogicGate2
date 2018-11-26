using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button_menu : MonoBehaviour {

    public Menu_in_game menu;
    public GameObject lvl;
    public GameObject space;
    public level_controller lvl_cont;

    

    public void ShowMenu()
    {
        Debug.Log("click on menu for show");
        lvl.SetActive(false);
        menu.SetByButton(this,space,lvl);
        menu.ShowMe();
        
    }

    public level_controller GetLvlCont()
    {
        
        return lvl_cont;
    }


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
