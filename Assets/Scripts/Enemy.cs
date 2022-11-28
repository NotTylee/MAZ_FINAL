using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    public float health = 50;
    
    

   
    public void TakeDamage(float amount)
    {
       health -= amount;
        if (health <= 0f)
        {
            Die();
        }


    }
    void Die()
    {
        
        Destroy(gameObject);
    }

}
