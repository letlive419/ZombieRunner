﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] float health = 100f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void takeDamage(float damage)
    {
        health -= damage;
        print(health);
        if (health <= 0)
        {
            print("game over");
        }
    }
}