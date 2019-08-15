using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class continueHP : MonoBehaviour {

	// Use this for initialization
	void Start () {
        DontDestroyOnLoad(this);
        SceneManager.LoadScene("Main");
    }
	
	// Update is called once per frame
	void Update () {
        
    }
}
