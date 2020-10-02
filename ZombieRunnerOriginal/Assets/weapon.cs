﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weapon : MonoBehaviour
{
    [SerializeField] Camera myCamera;
    [SerializeField] float Range = 100f;
 
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("fire1"))
        {
            Shoot();
        }

    }
    private void Shoot()
    {
        RaycastHit Hit;
        Physics.Raycast(myCamera.transform.position, transform.forward, out Hit, Range);
        print(Hit);
    }
}