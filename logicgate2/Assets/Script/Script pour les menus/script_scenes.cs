using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script_scenes : MonoBehaviour {

    // permet d'y avoir accès de partout dans le projet
    public static script_scenes Mine;

    public int Menuprincipal;
    public int Menujouer;
    public int Menucampagne;
    public int Choixdifficult;
    public int Options;
    public int Aide;
    public int Menudidactitiel;

    // Use this for initialization
    void Start () {
        Mine = this;		
	}
	
	
}
