using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomOb : MonoBehaviour
{

    public GameObject enemy1;
    public GameObject enemy2;
    public GameObject enemy3;
    //int[] num = new int[3];
    GameObject[] enemy = new GameObject[3];
    //float speed = 0.2f;

    public void RandomObject()
    {
        //for (int i = 0; i < 3; i++)
        //{
        //    num[i] = Random.Range(0, 3);
        //    for (int j = 0; j < i; j++)
        //    {
        //        if (num[j] == num[i])
        //        {
        //            i--;
        //            break;
        //        }
        //    }
        //}
    }

    //public void ReplaceObject(GameObject GO, int x)
    //{
    //    Vector3 vec = GO.transform.position;
    //    switch (x)
    //    {
    //        case 0:
    //            Instantiate(GO, new Vector3(0, vec.y, vec.z), Quaternion.Euler(0, 0, 0));
    //            break;
    //        case 1:
    //            Instantiate(GO, new Vector3(-3.5f, vec.y, vec.z), Quaternion.Euler(0, 0, 0));
    //            break;
    //        case 2:
    //            Instantiate(GO, new Vector3(3.5f, vec.y, vec.z), Quaternion.Euler(0, 0, 0));
    //            break;
    //    }
    //}

    public void UseFun()
    {
    //    RandomObject();
    //    ReplaceObject(enemy1, num[0]);
    //    ReplaceObject(enemy2, num[1]);
    //    ReplaceObject(enemy3, num[2]);
        GameObject tmp = enemy[Random.Range(0, 3)];
        Vector3 vec = tmp.transform.position;
        Instantiate(tmp, new Vector3(0, vec.y, vec.z), Quaternion.Euler(0, 0, 0));

        tmp = enemy[Random.Range(0, 3)];
        vec = tmp.transform.position;
        Instantiate(tmp, new Vector3(-3.5f, vec.y, vec.z), Quaternion.Euler(0, 0, 0));

        tmp = enemy[Random.Range(0, 3)];
        vec = tmp.transform.position;
        Instantiate(tmp, new Vector3(3.5f, vec.y, vec.z), Quaternion.Euler(0, 0, 0));
    }

    void Start()
    {
        enemy[0] = enemy1;
        enemy[1] = enemy2;
        enemy[2] = enemy3;
        //GameObject tmp = enemy[Random.Range(0, 3)];
        //Vector3 vec = tmp.transform.position;
        //Instantiate(tmp, new Vector3(0, vec.y, vec.z), Quaternion.Euler(0, 0, 0));

        //tmp = enemy[Random.Range(0, 3)];
        //vec = tmp.transform.position;
        //Instantiate(tmp, new Vector3(-3.5f, vec.y, vec.z), Quaternion.Euler(0, 0, 0));

        //tmp = enemy[Random.Range(0, 3)];
        //vec = tmp.transform.position;
        //Instantiate(tmp, new Vector3(3.5f, vec.y, vec.z), Quaternion.Euler(0, 0, 0));

        UseFun();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
