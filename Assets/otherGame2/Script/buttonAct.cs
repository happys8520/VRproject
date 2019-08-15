using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttonAct : MonoBehaviour {
    void Awake()
    {

    }
    public void restart()
    {
        Invoke("rerestart", .2f);
    }
    void rerestart()
    {
        SceneManager.LoadScene("Main");
        noHealth.status = 0;
    }
    public void gotoGame1()
    {
        SceneManager.LoadScene("FishGame");
    }
    public void gotoGame2()
    {
        SceneManager.LoadScene("hpScene");
    }
    public void gotoSelect()
    {
        SceneManager.LoadScene("select");
    }
}
