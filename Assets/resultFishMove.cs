//using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class resultFishMove : MonoBehaviour {

    float angle;
    float length;
    float x;
    float z;

    float cameraX;
    float cameraY;
    float cameraZ;

    float angleSpeed;

	void Start ()
    {
        angle = Random.Range(0,361);

        length = Random.Range(20, 40);
        cameraX = 42.5f;
        cameraY = 2.1f;
        cameraZ = -10f;

        do
        {
            angleSpeed = Random.Range(-0.006f, 0.006f);
        } while (angleSpeed == 0f);

    }

    void Update()
    {

        angle -= angleSpeed;

        x = cameraX + length * Mathf.Cos(angle);
        z = cameraZ + length * Mathf.Sin(angle);
        transform.position = new Vector3(x, transform.position.y, z);

        if (angleSpeed > 0)
        {
            transform.LookAt(new Vector3(cameraX, cameraY, cameraZ));
        }
        else if (angleSpeed < 0)
        {
            transform.LookAt(new Vector3(cameraX+180, cameraY, 180 + cameraZ));
        }
        
    }  


}

