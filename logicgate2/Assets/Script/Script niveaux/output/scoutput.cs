using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scoutput : MonoBehaviour {

    private bool state;
    public GameObject on, off,gate;
    private Vector3 mine;
    // Use this for initialization
    void Start()
    {
        state = false;
       if(state == false) on.SetActive(false);
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
        state = false;
    }

    public bool GetState()
    {

        return state;
    }
    public void ChangeState(bool newState)
    {

        state = newState;


    }

    // Update is called once per frame
    void Update () {
		
       
	}
}
