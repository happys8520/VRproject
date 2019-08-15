using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public static float health;
    float maxHealth = 100f;
    public static Image HealthBar;

    void Start()
    {
        HealthBar = GetComponent<Image>();
        health = maxHealth;
    }
 
    void Update()
    {
        HealthBar.fillAmount = health / maxHealth;
        Invoke("timeSpan", 0f);
        
    }

    void timeSpan()
    {
        health -= 0.015f;
    }

}
