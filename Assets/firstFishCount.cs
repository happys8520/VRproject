using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class firstFishCount : MonoBehaviour {

    public static Text firstCount;

    private void Start()
    {
        firstCount = GetComponent<Text>();
    }

    void Update ()
    {
        firstCount.text = moveXYZ.cnt1.ToString() + " / 3";
	}
}
