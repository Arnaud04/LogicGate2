using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class drag_source : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{

    public new Camera camera;

    public Material lineMaterial;
    public float lineWith;
    public float depth;
    private Vector3? lineStartPoint = null;

    public UnityEngine.GameObject src;
    private bool used = false;
    private bool contactCursor = false;

    private int max_line = 20;
    private UnityEngine.GameObject[] lines;// nombre de ligne 

    public controller_link control;
    public obj_input obj_in;
    public drag_source dg;
    private int nb_line = 0; // count of linerenderer to the path
    private bool valid_path = false;// tell if the pass connected 2 object or no
    



    public void NewPath()// réinitialise le tableau qui contiet les tracées graphique du chmemin
    {
        for(int i = 0; i <= nb_line; i++)
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

    private Vector3 GetMouseCameraPoint()
    {
        var ray = camera.ScreenPointToRay(Input.mousePosition);
        return ray.origin;// + ray.direction * depth;
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

        lineRenderer.material = lineMaterial;
        lineRenderer.SetPositions(new Vector3[] { lineStartPoint.Value, lineEndPoint });
        lineRenderer.startWidth = lineWith;
        lineRenderer.endWidth = lineWith;
        used = true;
        
    }

    public void OnEndDrag(PointerEventData eventData)
    {

        lineStartPoint = null;

        if( valid_path == false)
        {
            NewPath();
            used = false;

        }


    }
    // Use this for initialization
    void Start () {
        lines = new UnityEngine.GameObject[max_line];
        if (lineWith == 0) lineWith = (float)0.02;

    }

   void OnTriggerEnter2D(Collider2D col)
    {
        if(col.name == "cursor")
        {
            contactCursor = true;
            lineStartPoint = GetMouseCameraPoint();
            Debug.Log("enter col");
        }
        
    }


    void OnTriggerExit2D(Collider2D col)
    {
        if (col.name == "cursor")
        {
            contactCursor = false;
            Debug.Log("exit col");
        }
       
    }
    // Update is called once per frame
    void Update () {
		
	}
}
