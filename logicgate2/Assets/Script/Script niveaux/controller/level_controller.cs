using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class level_controller : MonoBehaviour {


    // tableau des points de la grille
    public int width, height;// size of screen
    public int nb_transmitter;
    public string lvl;
    public bool init = false;// ne pas toucher
    // un tableau par type d'objet 
    // un tableau 2d par tableau d'objet pour les trait

    // un entier de nombre courant par objet ; Attention!!  bien coordonée les chiffres avec les élément présent 0 alors l'objet n'est pas diposnible à instancié
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
    public int max_giver ;// source 
    public int max_taker;// puit ou source de fin 


   
   
     
    /*partie fixé par le concepteur du niveau seront fix donc pas de gestion direct de l'objet ( car il ne peut instancier de copie  ou être supprimé en jeu */
    /* partie qui peut être instancié par le joueur*/
    private selfdestruct[] tab_and;
    private selfdestruct[] tab_or;
    private selfdestruct[] tab_no;
    private selfdestruct[] tab_nand;
    private selfdestruct[] tab_xor;
    private selfdestruct[] tab_nor;
    private selfdestruct[] tab_giver;
    private selfdestruct[] tab_taker;


   

    public int objectif_g_and;
    public int objectif_g_or;
    public int objectif_g_no;
    public int objectif_g_nand;
    public int objectif_g_xor;
    public int objectif_g_nor;
    public int objectif_giver;// source 
    public int objectif_taker;// puit ou source de fin 

    // choix de condition de victoire : avoir relier tout les objets placés( et allumer tout les takers); avoir utilisé tout les objets donnés( relier et vérifié les taker);
    // avoir utilisé ,relier et allumé un minimum d'objets

    public void SetColisionOfTab(selfdestruct[] tab,int nb_colision,int max)
    {

        for(int i = 0; i < max; i++)
        {
                 if(tab[i] != null)
                 {
                    tab[i].Setcollision(nb_colision);
                 }
        }
    }

    public void SetColAllTab(int nb_colision)
    {
       SetColisionOfTab(tab_and,nb_colision, max_g_and);
        SetColisionOfTab(tab_or, nb_colision, max_g_or);
        SetColisionOfTab(tab_no, nb_colision, max_g_no);
        SetColisionOfTab(tab_nand, nb_colision, max_g_nand);
        SetColisionOfTab(tab_xor, nb_colision, max_g_xor);
        SetColisionOfTab(tab_nor, nb_colision, max_g_nor);
        SetColisionOfTab(tab_giver, nb_colision, max_giver);
        SetColisionOfTab(tab_taker, nb_colision, max_taker);
    }

    public void SaveTabReactivation(selfdestruct[]tab,int max)
    {
        for (int i = 0; i < max; i++)
        {
            if (tab[i] != null)
            {
                tab[i].SetReactivation(true);
                Debug.Log("save       "+ tab[i].me.name);
            }
        }
    }


    public void SetReactivation(selfdestruct obj, int index,bool state)
    {
        if (index < 0)
        {
            Debug.Log(" probleme d'indice");
            return ;
        }


        switch (obj.me.name)
        {
            case "obj_gate or":
                 tab_or[index].SetReactivation(state);
                break;

            case "obj_gate and":
                tab_and[index].SetReactivation(state);
                break;

            case "obj_gate no":
                 tab_no[index].SetReactivation(state);
                break;

            case "obj_gate nand":
                tab_nand[index].SetReactivation(state);
                break;

            case "obj_gate xor":
                 tab_xor[index].SetReactivation(state);
                break;

            case "obj_gate nor":
                tab_nor[index].SetReactivation(state);
                break;


            case "obj_input":
                tab_giver[index].SetReactivation(state);
                break;

            case "obj_output":
                 tab_taker[index].SetReactivation(state);
                break;
            default:
                Debug.Log(" Appel annormal car rien ne correspond (  default )");
                break;
        }
       
    
    }
    public bool GetReactivation(selfdestruct obj , int index)
    {
        if(index < 0) {
            Debug.Log(" probleme d'indice");
            return false;
        }


        switch (obj.me.name)
        {
            case "obj_gate or":
                return tab_or[index].GetReactivation();
                

            case "obj_gate and":
                return tab_and[index].GetReactivation();
               

            case "obj_gate no":
                return tab_no[index].GetReactivation();
               

            case "obj_gate nand":
                return tab_nand[index].GetReactivation();
               

            case "obj_gate xor":
                return tab_xor[index].GetReactivation();
               

            case "obj_gate nor":
                return tab_nor[index].GetReactivation();
               


            case "obj_input":
                return tab_giver[index].GetReactivation();
              

            case "obj_output":
                return tab_taker[index].GetReactivation();
               
            default:
                Debug.Log(" Appel annormal car rien ne correspond (  default )");
                break;
        }
        return false;
    }
    public void SaveCauseReactivation()
    {
        Debug.Log("save cause react");
        SaveTabReactivation(tab_and, max_g_and);
        SaveTabReactivation(tab_or, max_g_or);
        SaveTabReactivation(tab_no, max_g_no);
        SaveTabReactivation(tab_nand, max_g_nand);
        SaveTabReactivation(tab_xor, max_g_xor);
        SaveTabReactivation(tab_nor, max_g_nor);
        SaveTabReactivation(tab_giver, max_giver);
        SaveTabReactivation(tab_taker, max_taker);
    }
    public int CanAddObj(selfdestruct obj)// revoie 0 si on à le droit d'instancier l'objet et 1 si c'est interdit
    {

        if (obj.me.name == "obj_gate or" && nb_g_or < max_g_no)
            return 0;

        if (obj.me.name == "obj_gate and" && nb_g_and < max_g_and)
            return 0;
        if (obj.me.name == "obj_gate no" && nb_g_no < max_g_no)
            return 0;
        if (obj.me.name == "obj_gate nand" && nb_g_nand < max_g_nand)
            return 0;
        if (obj.me.name == "obj_gate xor"  && nb_g_xor < max_g_xor)
            return 0;
        if (obj.me.name == "obj_gate nor" && nb_g_nor < max_g_nor)
            return 0;
        if (obj.me.name == "obj_input" && nb_giver < max_giver)
            return 0;
        if (obj.me.name == "obj_output" && nb_taker < max_taker)
            return 0;

        return 1;
    }


    public int AddinTab(selfdestruct[] tab,int max, selfdestruct me)
    {
        int index = FindEmptyCase(tab, max);
        if (index == -1)
        {
            Debug.Log(" probleme tente d'ajouter objet sans avoir la place");
            return -1;
        }

        tab[index] = me;
        return index;
    }
    public void Addobj(selfdestruct obj)
    {
       
        int ret;
        switch (obj.me.name)
        {
            case "obj_gate or":
                ret = AddinTab(tab_or, max_g_or, obj);
                if (ret != -1)
                {
                    obj.SetIndex(ret);
                    nb_g_or++;
                }
                else Debug.Log("non ajouté");
                break;

            case "obj_gate and":
                ret = AddinTab(tab_and, max_g_and, obj);
                if (ret != -1)
                {
                    obj.SetIndex(ret);
                    nb_g_and++;
                }
                else Debug.Log("non ajouté");
                break;

            case "obj_gate no":
                ret = AddinTab(tab_no, max_g_no, obj);
                if (ret != -1)
                {
                    obj.SetIndex(ret);
                    nb_g_no++;
                }
                else Debug.Log("non ajouté");
                break;

            case "obj_gate nand":
                ret = AddinTab(tab_nand, max_g_nand, obj);
                if (ret != -1)
                {
                    obj.SetIndex(ret);
                    nb_g_nand++;
                }
                else Debug.Log("non ajouté");
                break;

            case "obj_gate xor":
                ret = AddinTab(tab_xor, max_g_xor, obj) ;
                if (ret != -1)
                {
                    obj.SetIndex(ret);
                    nb_g_xor++;
                }
                else Debug.Log("non ajouté");
                break;

            case "obj_gate nor":
                ret = AddinTab(tab_nor, max_g_nor, obj);
                if ( ret != -1)
                {
                    obj.SetIndex(ret);
                    nb_g_nor++;
                }
                else Debug.Log("non ajouté");
                break;


            case "obj_input":
                ret = AddinTab(tab_giver, max_giver, obj);
                if (ret != -1)
                {
                    obj.SetIndex(ret);
                    nb_giver++;
                }
                else Debug.Log("non ajouté");
                break;

            case "obj_output":
                ret = AddinTab(tab_taker, max_taker, obj);
                if ( ret != -1)
                {
                    obj.SetIndex(ret);
                    nb_taker++;
                }
                else Debug.Log("non ajouté");
                break;
            default:
                Debug.Log(" Appel annormal car rien ne correspond (  default )");
                break;
        }
      
    }
    public int DeleteObj(selfdestruct obj)// renvoie 0 si on ne doit pas remettre une instance dans le stock , et 1 si on doit le faire
    {
        int ret_value = 0;
        if (obj.me.name == "obj_gate or")
        {
            if (nb_g_or == max_g_or) ret_value = 1;
            tab_or[obj.GetIndex()] = null;
            nb_g_or--;
            

        }
         
        if (obj.me.name == "obj_gate and")
        {
            if (nb_g_and == max_g_and) ret_value = 1;
            tab_and[obj.GetIndex()] = null;
            nb_g_and--;

        }
        if (obj.me.name == "obj_gate no")
        {
            if (nb_g_no == max_g_no) ret_value = 1;
            tab_no[obj.GetIndex()] = null;
            nb_g_no--;

        }
        if (obj.me.name == "obj_gate nand")
        {
            if (nb_g_nand == max_g_nand) ret_value = 1;
            tab_nand[obj.GetIndex()] = null;
            nb_g_nand--;

        }
        if (obj.me.name == "obj_gate xor")
        {
            if (nb_g_xor == max_g_xor) ret_value = 1;
            tab_xor[obj.GetIndex()] = null;
            nb_g_xor--;

        }
        if (obj.me.name == "obj_gate nor")
        {
            if (nb_g_nor == max_g_nor) ret_value = 1;
            tab_nor[obj.GetIndex()] = null;
            nb_g_nor--;

        }
        if (obj.me.name == "obj_input")
        {
            if (nb_giver == max_giver) ret_value = 1;
            tab_giver[obj.GetIndex()] = null;
            nb_giver--;

        }
        if (obj.me.name == "obj_output")
        {
            if (nb_taker == max_taker) ret_value = 1;
            tab_taker[obj.GetIndex()] = null;
            nb_taker--;

        }

        return ret_value;
       
    }

    public void Inittab(selfdestruct[] tab,int max)
    {
        for(int i =  0; i < max; i++)
        {
            tab[i] = null;
        }

    }

    public void InitAllTab()
    {
        Inittab(tab_and, max_g_and);
        Inittab(tab_or, max_g_or);
        Inittab(tab_no, max_g_no);
        Inittab(tab_nand, max_g_nand);
        Inittab(tab_xor, max_g_xor);
        Inittab(tab_nor, max_g_nor);
        Inittab(tab_giver, max_giver);
        Inittab(tab_taker, max_taker);


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
             InitAllTab();
    }

    
    public int FindEmptyCase(selfdestruct[] tab,int max)
    {
        for (int i = 0; i < max; i++)
        {
            if(tab[i] == null)return i;
        }

        return -1;
    }

    public int NbValid(selfdestruct[] tab,int max)
    {
        int nb = 0;
        for(int i = 0; i < max; i++)
        {
            if(tab[i] != null)
            {
               
               if( tab[i].condition.Execpted() == tab[i].condition.ValidCondition())
                {
                    
                    nb++;
                }
               
            }
        }

        
        return nb;
    }
    public bool EndOfLevel()
    {
        int nb = 0;

        nb = NbValid(tab_or, max_g_or);
        if (nb < objectif_g_or) return false;

        nb = NbValid(tab_nand, max_g_nand);
        if (nb < objectif_g_nand) return false;

        nb = NbValid(tab_no, max_g_no);
        if (nb < objectif_g_no) return false;

        nb = NbValid(tab_and, max_g_and);
        if (nb < objectif_g_and) return false;

        nb = NbValid(tab_xor, max_g_xor);
        if (nb < objectif_g_xor) return false;

        nb = NbValid(tab_nor, max_g_nor); 
        if (nb < objectif_g_nor) return false;

        nb = NbValid(tab_taker, max_taker);
        if (nb < objectif_taker) return false;

       nb = NbValid(tab_giver, max_giver);
        if (nb < objectif_giver) return false;

        return true;
    }
    // Use this for initialization
    void Start () {
        tab_and = new selfdestruct[max_g_and];
        tab_or = new selfdestruct[max_g_or];
        tab_no = new selfdestruct[max_g_no];
        tab_nand = new selfdestruct[max_g_nand];
        tab_xor = new selfdestruct[max_g_xor];
        tab_nor = new selfdestruct[max_g_nor];
        tab_giver = new selfdestruct[max_giver];
        tab_taker = new selfdestruct[max_taker];

        init = true;
    }

    // Update is called once per frame
    void Update () {
		
        if(EndOfLevel() == true)
        {
            Debug.Log(" niveaux accompli");
        }
	}
}
