using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    [SerializeField] Camera myCamera;
    [SerializeField] float Range = 100f;
    [SerializeField] public float damage = 10f;
 
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire1"))
        {
            Shoot();
        }

    }
    private void Shoot()
    {
        RaycastHit Hit;
        if (Physics.Raycast(myCamera.transform.position, myCamera.transform.forward, out Hit, Range))
        {

            print(Hit.transform.name);
            EnemyHealth target = Hit.transform.GetComponent<EnemyHealth>();
            if (target == null) return;
            target.DamageTaken(damage);
        }
        else
        {
            return;
        }
    }
}
