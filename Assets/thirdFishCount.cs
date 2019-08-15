using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class thirdFishCount : MonoBehaviour {

    // Use this for initialization
    public static Text thirdCount;

    private void Start()
    {
        thirdCount = GetComponent<Text>();
    }

    void Update()
    {
        thirdCount.text = moveXYZ.cnt3.ToString() + " / 3";
    }
}
