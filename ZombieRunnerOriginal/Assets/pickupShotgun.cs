using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickupShotgun : MonoBehaviour
{

    
    void Start()
    {
        GetComponent<Weapon>().enabled = false;

    }

    public void OnTriggerEnter(Collider other)
    {
        ProcessPickup();

        

    }
    private void ProcessPickup()
    {
        var weapon = FindObjectOfType<WeaponSwitcher>();


        this.transform.parent = weapon.transform;



        transform.localPosition = new Vector3(.165f, 0.42f, 0.457f);
        transform.localRotation = Quaternion.Euler(0f, -90f, 0f);


        GetComponent<Weapon>().enabled = true;
       
        weapon.currentWeapon = 1;
        weapon.transform.GetChild(0).gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
