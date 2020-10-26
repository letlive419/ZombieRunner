using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlLight : MonoBehaviour
{
    [SerializeField] float lightFlicker = 1f;
    float timer;
    Light sourceLight;
    // Start is called before the first frame update
    void Start()
    {
        sourceLight = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {

        lightChange();
        
    }

    private void lightChange()
    {
        timer = (float)Math.Round(lightFlicker * Time.time);
        if (timer % 2 == 0)
        {
            sourceLight.enabled = false;
        }
        else
        {
            sourceLight.enabled = true;
        }
    }
}
