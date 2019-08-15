using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class solution : MonoBehaviour {

    public GameObject Panel1;
    public GameObject Panel2;
    public GameObject Panel3;
    public GameObject Panel4;
    public GameObject final;

    public void ChangePanel()
    {
        Panel1.SetActive(false);
        Panel2.SetActive(false);
        Panel3.SetActive(false);
        Panel4.SetActive(false);
        final.SetActive(true);
    }
}
