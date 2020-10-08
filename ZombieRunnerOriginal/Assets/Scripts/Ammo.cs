﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ammo : MonoBehaviour
{

    [SerializeField] int ammoAmount = 10;

    public int ReturnAmmo()
    {
        return ammoAmount;
    }

    public void reduceAmmo()
    {
        ammoAmount--;
    }
}
