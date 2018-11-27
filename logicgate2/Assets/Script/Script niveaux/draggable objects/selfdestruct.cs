using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class selfdestruct : MonoBehaviour {

    public UnityEngine.GameObject me;
    public int collisiondestruct;
    public level_controller cont_level;
    private int index_tab_controller_level = -1;
    public selfdestruct me_destruct;
    public instanciation instancieur;
    public cond_obj condition;// sert de passerelle entre l'objet qui à les liens et/ou le signal de la source et le level_controller 
    
    private bool reactivation = false ;// savoir si on vient de réactiver quelque chose qui risque de supprimer l'objet donc ne pas le supprimer cette fois ci, il sera changer dans le level_controller

    public bool player_is_instancieur;  // permet au level_controller de savoir si l'objet sera instancié par le joueur ( la décision sera en fait prise par le créateur du niveau)
    // Use this for initialization

    public void SetIndex(int nb)
    {
        index_tab_controller_level = nb;
    }

    public int GetIndex()
    {
        return index_tab_controller_level;
    }

    public void SetReactivation(bool newreact)
    {
        reactivation = newreact;
    }

    public bool GetReactivation()
    {
        return reactivation;
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
       
        if (collisiondestruct > 0 && collision.name == "instantiatespace") collisiondestruct--;
        else
        {
           
            if (collision.name == "instantiatespace" && reactivation == false )
            {
                int ret = 0;
                if (player_is_instancieur)
                     ret = cont_level.DeleteObj(me_destruct);
                Debug.Log("obj Destruction "+ me.name);
                if (ret == 1)
                {
                      instancieur.Createobj();
                }
                Destroy(me);

               
            }
            if(collision.name == cont_level.lvl)
            {
                reactivation = false;
            }
            
        }
            
    }

  
    public int AskRightCreate()
    {
        return cont_level.CanAddObj(me_destruct);
    }
    public void Setcollision(int nb)
    {
        collisiondestruct = nb;

    }
    void Start()
    {
        /* quand il sera instancié et que ce sera le joueur le responsable il demandera la gestion du controller du niveau*/
        if (player_is_instancieur)
        {
            cont_level.Addobj(me_destruct);
        }

    }

    // Update is called once per frame
    void Update () {
		
	}
}
