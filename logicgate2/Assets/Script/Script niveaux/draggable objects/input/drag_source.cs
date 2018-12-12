using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class drag_source : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{

    public new Camera camera;

    public Material lineMaterialfalse,lineMaterialtrue;
    
    public float lineWith;
    
    private Vector3? lineStartPoint = null;

    public UnityEngine.GameObject src;
    private bool used = false;
    private bool contactCursor = false;

    private int max_line = 20;
    private UnityEngine.GameObject[] lines;// nombre de ligne 
    private LineRenderer[] linesRend;

    public controller_link control;
    public obj_input obj_in;
    public drag_source dg;
    private int state = 1;

    private int nb_line = 0; // count of linerenderer to the path
    private bool valid_path = false;// tell if the pass connected 2 object or no
    
    public bool GetValid_path()
    {
        return valid_path;
    }



    public void NewPath()// réinitialise le tableau qui contiet les tracées graphique du chmemin
    {
        Debug.Log("       NEW PATH");
        for(int i = 0; i < nb_line; i++)
        {
          
            Destroy(lines[i]);


        }
        nb_line = 0;
        used = false;
        valid_path = false;
    }

    public void ValidPath()
    {
        valid_path = true;
        used = true;
    }


    public void ChangePathState()
    {
        bool mat;
        if (nb_line > 0)
        {
            if (obj_in.Getinstate() == 2)
            {
                state = 2;
                mat = true;
            }
            else
            {

                state = 1;
                mat = false;
            }

            Debug.Log(" change fil de couleur");
            for (int i = 0; i < nb_line; i++)
            {
                if (mat == true)
                    linesRend[i].material = lineMaterialtrue;
                else
                {
                    linesRend[i].material = lineMaterialfalse;
                }




            }
        }
            
    }
    private Vector3 GetMouseCameraPoint()
    {
        var ray = camera.ScreenPointToRay(Input.mousePosition);
        return ray.origin;
    }

    public void CutLink()
    {
        if (nb_line + 1 >= max_line) return;// afficher à l'utilisateur qu'il ne peut plus ajouter de lien
        nb_line++;
        lineStartPoint = GetMouseCameraPoint();
    }
    public void OnBeginDrag(PointerEventData eventData)
    {
        if (contactCursor == true)
        {
            
            control.Setin(obj_in);
            control.SetDragSrc(dg);
        }
        if (used == true){
            NewPath();
            valid_path = false;
            
            used = false;
        }
        

    }
    public void OnDrag(PointerEventData eventData)
    {
        if (!lineStartPoint.HasValue)
            return;

        if (valid_path)
            return;

        if (used == true)
        {
            Destroy(lines[nb_line]);
        }
       
        var lineEndPoint =  GetMouseCameraPoint();
        var nextline = new UnityEngine.GameObject();
        var lineRenderer = nextline.AddComponent<LineRenderer>();

        lines[nb_line] = nextline;

        if (obj_in.Getinstate() == 2)
            lineRenderer.material = lineMaterialtrue;
        else
            lineRenderer.material = lineMaterialfalse;

        lineRenderer.SetPositions(new Vector3[] { lineStartPoint.Value, lineEndPoint });
        lineRenderer.startWidth = lineWith;
        lineRenderer.endWidth = lineWith;
        linesRend[nb_line] = lineRenderer;
        used = true;
        
    }

    public void OnEndDrag(PointerEventData eventData)
    {

        lineStartPoint = null;
        nb_line++;
        if ( valid_path == false)
        {
            NewPath();
            used = false;

        }
        
           


    }
    // Use this for initialization
    void Start () {
        lines = new UnityEngine.GameObject[max_line];
        linesRend = new LineRenderer[max_line];
        if (lineWith == 0) lineWith = (float)0.002;
        

    }

   void OnTriggerEnter2D(Collider2D col)
    {
        if(col.name == "cursor")
        {
            contactCursor = true;
            lineStartPoint = GetMouseCameraPoint();
            Debug.Log("cursor col true");
        }
        
    }


    void OnTriggerExit2D(Collider2D col)
    {
        if (col.name == "cursor")
        {
            contactCursor = false;
            Debug.Log("curso false");
        }
       
    }
    // Update is called once per frame
    void Update () {

        int tmpstate = obj_in.Getinstate();
        if (state == 1 && tmpstate == 2 || state == 2 && (tmpstate == 1 || tmpstate == 0))
            ChangePathState();
	}
}
