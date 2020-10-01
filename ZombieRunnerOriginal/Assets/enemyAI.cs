using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.AI;

public class enemyAI : MonoBehaviour
{
    [SerializeField] Transform target;
    [SerializeField] float chaseRange = 10f;

    bool isProvoked = false;

    NavMeshAgent navMeshAgent;
    float distanceToTarget = Mathf.Infinity;
    // Start is called before the first frame update
    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>(); 
    }

    // Update is called once per frame
    void Update()
    {
        distanceToTarget = Vector3.Distance(target.transform.position, transform.position);

        if (isProvoked)
        {
            EngageTarget();
        }

        else if (distanceToTarget <= chaseRange)
        {
            isProvoked = true;
            

        }
    }

    private  void EngageTarget()
    {
        if (distanceToTarget >= navMeshAgent.stoppingDistance)
        {
            chaseEnemy();
        }
       if (distanceToTarget <= navMeshAgent.stoppingDistance)
        {
            attackEnemy();
        }

    }

    public void chaseEnemy()
    {
        navMeshAgent.SetDestination(target.transform.position);
    }
    public void attackEnemy()
    {
        print("Attack");
    }
    void OnDrawGizmosSelected()
    {

        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, chaseRange);
    }




}
