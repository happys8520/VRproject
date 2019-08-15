using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HealthBar : MonoBehaviour {

    public static float health;
    float maxHealth = 100f;
    public static Image hp;

    void Start()
    {
        hp = GetComponent<Image>();
        health = maxHealth;
    }

    void Update()
    {
        hp.fillAmount = health / maxHealth;
        Invoke("timeSpan", 0f);
        if(health > maxHealth)
        {
            health = maxHealth;
        }
        //if(health < 0)
        //{
        //    print("gameover");
        //    //SceneManager.LoadScene("");
        //}
    }

    void timeSpan()
    {
        health -= 0.03f;
    }
}
