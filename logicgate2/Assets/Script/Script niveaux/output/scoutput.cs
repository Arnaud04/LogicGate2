using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scoutput : MonoBehaviour {

    private int state;
    public GameObject on, off,gate,source;
    private Vector3 mine;
    // Use this for initialization
    void Start()
    {
        state = 0;
       if(state != 2) on.SetActive(false);
        else off.SetActive(false);
       
        mine = this.transform.position;
        


    }

    public void LinkGate(GameObject newGate)
    {
        gate = newGate;
        // l'état de la sortie = celui de la porte
    }

    public void Unlink()
    {
        gate = null;
        state = 0;
    }

    public int GetState()
    {

        return state;
    }
    public void ChangeState(int newState)
    {

        state = newState;
        if(state != 2)
        {
            on.SetActive(false);
            off.SetActive(true);
        }
        if(state == 2)
        {
            on.SetActive(true);
            off.SetActive(false);
        }

    }

    // Update is called once per frame
    void Update () {
		
       
	}
}
