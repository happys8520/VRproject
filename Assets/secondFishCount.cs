using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class secondFishCount : MonoBehaviour {

    // Use this for initialization
    public static Text secondCount;

    private void Start()
    {
        secondCount = GetComponent<Text>();
    }

    void Update()
    {
        secondCount.text = moveXYZ.cnt2.ToString() + " / 3";
    }
}
