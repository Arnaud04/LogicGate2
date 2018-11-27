using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cond_obj : MonoBehaviour {


    private bool linked = false;
    private bool light = false;
    public bool by_link = false, by_light = false;
    public int objectif = 0;// 1 juste la laison , 2 allumé, 3 les  2 condition ; Attention bien coordonnée by_link et by_light avec objectif


    public void SetLink(bool state)
    {
        linked = state;
    }

    public void SetLight(bool state)
    {
        light = state;
    }

    public int  ValidCondition()// renvoie -1 si il y a un probleme ;renvoie 0 si aucune des condition n'est validé ; 1 si validé par liaison ; 2 validé par allumé ; 3 les deux conditions;
    {
        
        if( by_light == false && by_link == false)
        {
            Debug.Log(" DANGER PAS DE CONDITION SUR L OBJ:  " + this.name);
            return -1;
        }

        if (by_link == true && linked == true  && by_light == true && light == true)
        {
            return 3;
        }

        if (by_link == true && linked == true)
            return 1;

        if (by_light == true && light == true)
            return 2;
        return 0;
    }
	// Use this for initialization

    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
