using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wcondition_fixec_obj : MonoBehaviour {


    /* sert pour les niveaux avec des portes déjà placé ; Attention bien mettre les portes en Fix (pour éviter qu'elle puisse être supprimé et faire des niveaux non finissable*/
    public selfdestruct obj1 =null, obj2 = null, obj3 = null, obj4 = null, obj5 = null,
                        obj6 = null, obj7 = null, obj8 = null, obj9 = null,  obj10 = null;
	// Use this for initialization

    // nous dit c'est les objectif fixé ici sont atteint
    public bool SuccessGoal()
    {
        if(obj1 != null)
             if (obj1.condition.ValidCondition() != obj1.condition.objectif) return false;

        if (obj2 != null)
            if (obj2.condition.ValidCondition() != obj2.condition.objectif) return false;

        if (obj3 != null)
            if (obj3.condition.ValidCondition() != obj3.condition.objectif) return false;

        if (obj4 != null)
            if (obj4.condition.ValidCondition() != obj4.condition.objectif) return false;

        if (obj5 != null)
            if (obj5.condition.ValidCondition() != obj5.condition.objectif) return false;

        if (obj6 != null)
            if (obj6.condition.ValidCondition() != obj6.condition.objectif) return false;

        if (obj7 != null)
            if (obj7.condition.ValidCondition() != obj7.condition.objectif) return false;

        if (obj8 != null)
            if (obj8.condition.ValidCondition() != obj8.condition.objectif) return false;

        if (obj9 != null)
            if (obj9.condition.ValidCondition() != obj9.condition.objectif) return false;

        if (obj10 != null)
            if (obj10.condition.ValidCondition() != obj10.condition.objectif) return false;

        return true;
    }
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
