using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameOver : MonoBehaviour {
    
    public void tryAgain()
    {
        GameObject.Find("NoDaddy").SetActive(false);
        noHealth.status = 1;
    }

    public void restart()
    {
        Destroy(GameObject.Find("HpManager"));
        SceneManager.LoadScene("hpScene");
    }

    public void gotoResult()
    {
        Destroy(GameObject.Find("HpManager"));
        SceneManager.LoadScene("resultBackground");
    }

}
