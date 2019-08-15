using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallDestroy : MonoBehaviour {

    //public float speed = 0.02f;
    public GameObject leftW;
    public GameObject rightW;
    int wallNum;
    // Use this for initialization
    void Start () {
        Instantiate(leftW, new Vector3(-2, 2, 9), Quaternion.Euler(0, 0, 0));
        Instantiate(rightW, new Vector3(2, 2, 9), Quaternion.Euler(0, 0, 0));
        Instantiate(leftW, new Vector3(-2, 2, 32), Quaternion.Euler(0, 0, 0));
        Instantiate(rightW, new Vector3(2, 2, 32), Quaternion.Euler(0, 0, 0));
        Instantiate(leftW, new Vector3(-2, 2, -15), Quaternion.Euler(0, 0, 0));
        Instantiate(rightW, new Vector3(2, 2, -15), Quaternion.Euler(0, 0, 0));
    }
	
	// Update is called once per frame
	void Update () {
        wallNum = GameObject.FindGameObjectsWithTag("wall").Length;
        if (wallNum <= 4)
        {
            Instantiate(leftW, new Vector3(-2, 2, 32), Quaternion.Euler(0, 0, 0));
            Instantiate(rightW, new Vector3(2, 2, 32), Quaternion.Euler(0, 0, 0));
        }
    }
}
