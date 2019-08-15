using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class smallICE2 : MonoBehaviour {

    int ran;
    public GameObject fish;
    public GameObject UI;
    public GameObject UI2;
    int IceStatus=0;

    // Use this for initialization
    void Start () {
        ran = Random.Range(0, 2);
        if (ran == 1)
        {
            Instantiate(fish);
            Invoke("toActive", 0);
            HealthBar.health += 10;
            StartCoroutine(WaitSecond(3f));
        }
    }
	
	// Update is called once per frame
	void Update () {
        if(ran == 0 && transform.position.y >= -4.8f)
        {
            transform.Translate(0, -0.02f, 0);
            GameObject.Find("Player").transform.Translate(0, -0.02f, 0);
        }
        if (IceStatus == 0 && transform.position.y < -4.8f)
        {
            UI.SetActive(true);
            HealthBar.health -= 3;
            IceStatus = 1;
        }
    }

    void toActive()
    {
        UI2.SetActive(true);
    }

    IEnumerator WaitSecond(float second)
    {
        yield return new WaitForSeconds(second);
        SceneManager.LoadScene("Main");
    }
}
