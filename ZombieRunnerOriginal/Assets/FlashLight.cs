﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashLight : MonoBehaviour
{
    [SerializeField] float lightDecay = .1f;
    [SerializeField] float angleDecay = 1f;

    [SerializeField] float minimumAngle = 40f;

    Light myLight;

    
    
    // Start is called before the first frame update
    void Start()
    {
        myLight = GetComponent<Light>();
      
    }

    private void Update()
    {
     
                DescreaseLightAngle();
                DecreaseLightIntensity();

            
    }

    private void DecreaseLightIntensity()
    {
        myLight.intensity -= lightDecay * Time.deltaTime;
    }

    private void DescreaseLightAngle()
    {
        if (myLight.spotAngle <= minimumAngle)
        {
            return;
        }
        else
        {
            myLight.spotAngle -= angleDecay * Time.deltaTime;
        }
    }
}
