using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InflictedDamage : MonoBehaviour
{
    PlayerHealth target;
    [SerializeField] public float damage = 40f;

    // Start is called before the first frame update
    void Start()
    {
        target = FindObjectOfType<PlayerHealth>();
    }
    public void AttackPoints()

    {
        if (target == null) return;
      
        target.takeDamage(damage);
        target.GetComponent<DamageTakenDisplay>().startDamageTaken();
    }
  
}
