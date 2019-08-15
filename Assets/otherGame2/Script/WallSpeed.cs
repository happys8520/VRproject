﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallSpeed : MonoBehaviour {

    public float speed = 0.2f;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(0, 0, -speed);
        }
        if (transform.position.z <= -30 && GameObject.FindWithTag("wall"))
        {
            Destroy(gameObject);
        }
    }
}
