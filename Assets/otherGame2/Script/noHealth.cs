using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class noHealth : MonoBehaviour {

    public GameObject gameoverUI;
    public static int status;

	// Use this for initialization
	void Start () {
        status = 0;
	}
	
	// Update is called once per frame
	void Update () {
        if (status == 1 && HealthBar.health <= 0)
        {
            status++;
            gameoverUI.SetActive(true);
        }
	}
}
