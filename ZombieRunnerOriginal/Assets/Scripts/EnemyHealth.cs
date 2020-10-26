using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{

    [SerializeField] float Health = 100f;
    

    public bool isDead = false;


    public bool IsDead()
    {
        return isDead;
    }
    void Start()
    {
        
    }
    

    public void DamageTaken(float damage)
    {
        BroadcastMessage("OnDamageTaken");
        Health -= damage;
        

        print(Health);
        if (Health <= 0)
            {
            Die();
                
        }
       
    }

    private void Die()
    {
        if (isDead) return;
        isDead = true;
        GetComponent<Animator>().SetTrigger("die");
    }
}
