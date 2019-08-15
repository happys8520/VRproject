using System.Collections;
using UnityEngine;
//------------- 여러마리 클론 생기고 그 클론에 위치 , 방향 지정
public class globalFlock : MonoBehaviour
{
    public GameObject fishPrefab;
    public GameObject goalPrefab;
    public static int tankSize = 8;

    static int numFish = 6;
    public static GameObject[] allFish = new GameObject[numFish];

    public static Vector3 goalPos = Vector3.zero;

    // Use this for initialization
    void Start()
    {
        RenderSettings.fogColor = Camera.main.backgroundColor;
        RenderSettings.fogDensity = 0.02f;
        RenderSettings.fog = true;
        for (int i = 0; i < numFish; i++)
        {
            Vector3 pos = new Vector3(Random.Range(-tankSize, tankSize),
                                    Random.Range(-tankSize, tankSize),
                                    Random.Range(-tankSize, tankSize));
            allFish[i] = (GameObject) Instantiate(fishPrefab, pos, Quaternion.identity);
        }                                                       // 위치, 회전
    }

    // Update is called once per frame
    void Update()
    {
        /*
        if (Random.Range(0, 10000) < 50)
        {
            goalPos = new Vector3(Random.Range(-tankSize, tankSize),
                                Random.Range(-tankSize, tankSize),
                                Random.Range(-tankSize, tankSize));
            goalPrefab.transform.position = goalPos;
        }*/
    }
}