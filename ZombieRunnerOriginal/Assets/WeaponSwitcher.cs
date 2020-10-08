using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSwitcher : MonoBehaviour
{
   [SerializeField] int currentWeapon = 0;

    private void Start()
    {
        setWeaponActive();
        
    }

    private void Update()
    {
        int previousWeapon = currentWeapon;

        ProcessKey();


        if (previousWeapon != currentWeapon)
        {
            setWeaponActive();
        }
        

    }

    private void ProcessKey()
    {
        
        
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            currentWeapon = 0;
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            currentWeapon = 1;
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            currentWeapon = 2;
        }

    }

    private void setWeaponActive()
    {
        int weaponIndex = 0;

        foreach (Transform weapon in transform)
        {
            if (weaponIndex == currentWeapon)
            {
                weapon.gameObject.SetActive(true);
            }
            else
            {
                weapon.gameObject.SetActive(false);

            }
            weaponIndex++;
        }
    }
}
