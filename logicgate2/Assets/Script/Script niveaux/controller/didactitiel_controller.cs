using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class didactitiel_controller : MonoBehaviour {


    public GameObject e1, e2, e3, e4, e5, e6, e7, e8, e9, e10,e11,e12;
    public GameObject menu, choix_level;
    private int current_lvl;

    public void Load_level(int lvl)
    {
       
        
            if (lvl == 1)
            {
                e1.SetActive(true);
            }
            if (lvl == 2)
            {
                e2.SetActive(true);
            }
            if (lvl == 3)
            {
                e3.SetActive(true);
            }
            if (lvl == 4)
            {
                e4.SetActive(true);

            }
            if (lvl == 5)
            {
                e5.SetActive(true);
            }
            if (lvl == 6)
            {
                e6.SetActive(true);
            }
            if (lvl == 7)
            {
                e7.SetActive(true);
            }
            if (lvl == 8)
            {
                e8.SetActive(true);
            }
            if (lvl == 9)
            {
                e9.SetActive(true);
            }
            if (lvl == 10)
            {
                e10.SetActive(true);
            }
            if(lvl == 11)
             {
                  e11.SetActive(true);
             }
            if (lvl == 12)
            {
                e12.SetActive(true);
            }

        menu.SetActive(false);
        choix_level.SetActive(false);
        current_lvl = lvl;
    }

    public void ActiveMenu()
    {
        menu.SetActive(true);

    }
    public void ActiveChoice()
    {
        choix_level.SetActive(true);
    }

    public void ChoiceToMenu()
    {
        choix_level.SetActive(false);
        menu.SetActive(true);

    }

    public void Unloadlvl()
    {
        if (current_lvl == 1)
        {
            e1.SetActive(false);
        }
        if (current_lvl == 2)
        {
            e2.SetActive(false);
        }
        if (current_lvl == 3)
        {
            e3.SetActive(false);
        }
        if (current_lvl == 4)
        {
            e4.SetActive(false);

        }
        if (current_lvl == 5)
        {
            e5.SetActive(false);
        }
        if (current_lvl == 6)
        {
            e6.SetActive(false);
        }
        if (current_lvl == 7)
        {
            e7.SetActive(false);
        }
        if (current_lvl == 8)
        {
            e8.SetActive(false);
        }
        if (current_lvl == 9)
        {
            e9.SetActive(false);
        }
        if (current_lvl == 10)
        {
            e10.SetActive(false);
        }
        if (current_lvl == 11)
        {
            e11.SetActive(false);
        }
        if (current_lvl == 12)
        {
            e12.SetActive(false);
        }
        choix_level.SetActive(true);
    }

    public void MenuToChoice()
    {
        menu.SetActive(false);
        choix_level.SetActive(true);
    }
        // Use this for initialization
        void Start () {

        menu.SetActive(true);
        choix_level.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
