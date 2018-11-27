using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class info_cond : MonoBehaviour {
    // cette classe sert juste à faire la liaison entre selfdestruct et drag_source sans avoir à changer tout les objets qui contiennent une classe existante
    public selfdestruct self;
    public drag_source dg;
    public scinput state;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        self.condition.SetLink(dg.GetValid_path());
        if (state.GetState() == 2)
            self.condition.SetLight(true);
        else
            self.condition.SetLight(false);
    }
}
