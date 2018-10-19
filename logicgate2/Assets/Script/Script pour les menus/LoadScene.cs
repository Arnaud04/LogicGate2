using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour {

    // Use this for initialization
    public int scene;
    
    void Start()
    {


    }
	public void loader(){

        SceneManager.LoadSceneAsync(scene);
        SceneManager.UnloadScene(SceneManager.GetActiveScene());
    }
	
	
}
