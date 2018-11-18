using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class level_controller : MonoBehaviour {


    // tableau des points de la grille
    public int width, height;// size of screen
    public int nb_transmitter;
    // un tableau par type d'objet 
    // un tableau 2d par tableau d'objet pour les trait

    // un entier de nombre courant par objet
    private int nb_g_and = 0;
    private int nb_g_or = 0;
    private int nb_g_no = 0;
    private int nb_g_nand = 0;
    private int nb_g_xor= 0;
    private int nb_g_nor = 0;
    private int nb_giver = 0;
    private int nb_taker = 0;

    public int max_g_and ;
    public int max_g_or ;
    public int max_g_no ;
    public int max_g_nand;
    public int max_g_xor ;
    public int max_g_nor ;
    public int max_giver ;
    public int max_taker;

    // un autre pour le max
    // une fonction d'initialisation


    public int AddObj(obj_structure obj)
    {

        return 0;
    }

    public int DeleteObj(obj_structure obj)
    {
        return 0;
    }
    public void InitLevel()
    {
            nb_g_and = 0;
            nb_g_or = 0;
            nb_g_no = 0;
            nb_g_nand = 0;
            nb_g_xor = 0;
            nb_g_nor = 0;
            nb_giver = 0;
            nb_taker = 0;
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
