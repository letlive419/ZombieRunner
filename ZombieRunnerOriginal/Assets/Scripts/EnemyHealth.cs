using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{

    [SerializeField] float Health = 100f;
    void Start()
    {
        
    }
    

    public void DamageTaken(float damage)
    {
        Health -= damage;
        print(Health);
        if (Health <= 0)
            {
            Destroy(gameObject);
        }
       
    }
}
