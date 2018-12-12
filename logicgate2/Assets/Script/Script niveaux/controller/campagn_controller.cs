using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class campagn_controller : MonoBehaviour {

    // Use this for initialization
    private int difficult = 0;// 0 easy, 1 normal , 2 hard
    private LoadScene loader;
    public GameObject menu_choix_lvl, menu_choix_diff;
    private int current_lvl;

    // niveaux facile 
    public GameObject e1, e2, e3, e4, e5, e6, e7, e8, e9, e10;

    // niveaux normaux
    public GameObject m1, m2, m3, m4, m5, m6, m7, m8, m9, m10;

   // niveaux dur 
    public GameObject h1, h2, h3, h4, h5, h6, h7, h8, h9, h10;
    

    public void ActiveDiff()
    {
        menu_choix_diff.SetActive(true);
        menu_choix_lvl.SetActive(false);


    }

    public void ActiveLvl(int diff_value)
    {
        difficult = diff_value;
        menu_choix_diff.SetActive(false);
        menu_choix_lvl.SetActive(true);


    }

    
    

   

    public void SetDifficult(int nb)
    {
        difficult = nb;
    }

    public int GetDifficult()
    {
        return difficult;
    }

    
    public void Load_level(int lvl)
    {
        if( difficult == 0)
        {
            if( lvl == 1 )
            {
                e1.SetActive(true);
            }
            if(lvl == 2)
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
        }
       if(difficult == 1)
        {
            if (lvl == 1)
            {
                m1.SetActive(true);
            }
            if (lvl == 2)
            {
                m2.SetActive(true);
            }
            if (lvl == 3)
            {
                m3.SetActive(true);
            }
            if (lvl == 4)
            {
                m4.SetActive(true);

            }
            if (lvl == 5)
            {
                m5.SetActive(true);
            }
            if (lvl == 6)
            {
                m6.SetActive(true);
            }
            if (lvl == 7)
            {
                m7.SetActive(true);
            }
            if (lvl == 8)
            {
                m8.SetActive(true);
            }
            if (lvl == 9)
            {
                m9.SetActive(true);
            }
            if (lvl == 10)
            {
                m10.SetActive(true);

            }
        }
       if(difficult == 2)
        {
            if (lvl == 1)
            {
                h1.SetActive(true);
            }
            if (lvl == 2)
            {
                h2.SetActive(true);
            }
            if (lvl == 3)
            {
                h3.SetActive(true);
            }
            if (lvl == 4)
            {

                h4.SetActive(true);
            }
            if (lvl == 5)
            {
                h5.SetActive(true);
            }
            if (lvl == 6)
            {
                h6.SetActive(true);
            }
            if (lvl == 7)
            {
                h7.SetActive(true);
            }
            if (lvl == 8)
            {
                h8.SetActive(true);
            }
            if (lvl == 9)
            {
                h9.SetActive(true);
            }
            if (lvl == 10)
            {
                h10.SetActive(true);
            }
        }
        current_lvl = lvl;
        menu_choix_diff.SetActive(false);
        menu_choix_lvl.SetActive(false);
    }


    public void Unloadlvl()
    {
        if (difficult == 0)
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
        }
        if (difficult == 1)
        {
            if (current_lvl == 1)
            {
                m1.SetActive(false);
            }
            if (current_lvl == 2)
            {
                m2.SetActive(false);
            }
            if (current_lvl == 3)
            {
                m3.SetActive(false);
            }
            if (current_lvl == 4)
            {
                m4.SetActive(false);

            }
            if (current_lvl == 5)
            {
                m5.SetActive(false);
            }
            if (current_lvl == 6)
            {
                m6.SetActive(false);
            }
            if (current_lvl == 7)
            {
                m7.SetActive(false);
            }
            if (current_lvl == 8)
            {
                m8.SetActive(false);
            }
            if (current_lvl == 9)
            {
                m9.SetActive(false);
            }
            if (current_lvl == 10)
            {
                m10.SetActive(false);

            }
        }
        if (difficult == 2)
        {
            if (current_lvl == 1)
            {
                h1.SetActive(false);
            }
            if (current_lvl == 2)
            {
                h2.SetActive(false);
            }
            if (current_lvl == 3)
            {
                h3.SetActive(false);
            }
            if (current_lvl == 4)
            {

                h4.SetActive(false);
            }
            if (current_lvl == 5)
            {
                h5.SetActive(false);
            }
            if (current_lvl == 6)
            {
                h6.SetActive(false);
            }
            if (current_lvl == 7)
            {
                h7.SetActive(false);
            }
            if (current_lvl == 8)
            {
                h8.SetActive(false);
            }
            if (current_lvl == 9)
            {
                h9.SetActive(false);
            }
            if (current_lvl == 10)
            {
                h10.SetActive(false);
            }
        }

        menu_choix_lvl.SetActive(true);
    }


   
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
