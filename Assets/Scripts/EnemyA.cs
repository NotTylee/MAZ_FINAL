using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyA : MonoBehaviour
{
    Transform player;
    Animator anim;
    public float damageAmount = 35f;
    float attackTime = 2f;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Attackplayer();
    }
    void Attackplayer()
    {
        float distance = Vector3.Distance(player.position, anim.transform.position);
        if (distance > 3.5f)
            anim.SetBool("isAttacking", false);
        StartCoroutine(AttackTime());
    }
    IEnumerator AttackTime()
    {
        yield return new WaitForSeconds(0.5f);
        PlayerHealth.singleton.PlayerDamage(damageAmount);
        yield return new WaitForSeconds(attackTime);

    }
}
