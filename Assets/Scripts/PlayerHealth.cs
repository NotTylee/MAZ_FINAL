using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public static PlayerHealth singleton;
    public float currentHealth;
    public float maxHealth = 100;

    private void Awake()
    {
        singleton = this;
    }
    void Start()
    {
       
        currentHealth = maxHealth;
    }

   
    void Update()
    {
        
    }
    public void PlayerDamage(float damage)
    {
        currentHealth -= damage;
    }
}
