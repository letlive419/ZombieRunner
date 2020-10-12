using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.AI;

public class enemyAI : MonoBehaviour
{
    [SerializeField] Transform target;
    [SerializeField] float chaseRange = 10f;
    [SerializeField] float turnSpeed = 5f;
    EnemyHealth health;

    bool isProvoked = false;

    NavMeshAgent navMeshAgent;
    float distanceToTarget = Mathf.Infinity;
    // Start is called before the first frame update
    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
        health = GetComponent<EnemyHealth>();
    }

    // Update is called once per frame
    void Update()
    {
        distanceToTarget = Vector3.Distance(target.transform.position, transform.position);
        if (health.IsDead())
        {
            enabled = false;
            navMeshAgent.enabled = false;
        }
        

        if (isProvoked)
        {
            EngageTarget();
        }

        else if (distanceToTarget <= chaseRange)
        {
            isProvoked = true;
            

        }
    }

    public void OnDamageTaken()
    {
        isProvoked = true;
    }
    private  void EngageTarget()
    {
        FaceEnemy();
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
        GetComponent<Animator>().SetBool("Attack", false);
        GetComponent<Animator>().SetTrigger("move");
        navMeshAgent.SetDestination(target.transform.position);
    }
    public void attackEnemy()
    {
        GetComponent<Animator>().SetBool("Attack", true);
        
        print("Attack");
    }
    private void FaceEnemy()
    {
        Vector3 direction = (target.position - transform.position).normalized;
        Quaternion lookRotation = Quaternion.LookRotation(new Vector3(direction.x, 0, direction.z));
        transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime * turnSpeed);

    }
    void OnDrawGizmosSelected()
    {

        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, chaseRange);
    }




}
