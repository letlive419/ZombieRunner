using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    [SerializeField] Camera myCamera;
    [SerializeField] float Range = 100f;
    [SerializeField] public float damage = 10f;
    [SerializeField] ParticleSystem muzzleFlash;
    [SerializeField] GameObject sparks;
    [SerializeField] Ammo ammoSlot;
   
 
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }

    }
    private void Shoot()
    {
        if (ammoSlot.ReturnAmmo() > 0)
        {
            
            processEffects();
            processShot();
            ammoSlot.reduceAmmo();
            
        }
        else
        {
            return;
        }
    }

    private void processEffects()
    {
        muzzleFlash.Play();
    }
    
    private void processShot()
    {
        RaycastHit Hit;
        
        if (Physics.Raycast(myCamera.transform.position, myCamera.transform.forward, out Hit, Range))
        {
      
            impactGenerated(Hit);
            EnemyHealth target = Hit.transform.GetComponent<EnemyHealth>();
            if (target == null) return;
            target.DamageTaken(damage);
            

        }
        else
        {
            return;
        }
    }
    private void impactGenerated(RaycastHit Hit)
    {
        GameObject impact = Instantiate(sparks, Hit.point, Quaternion.LookRotation(Hit.normal));
        Destroy(impact, .1f);
    }

}
