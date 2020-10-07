using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponZoom : MonoBehaviour
{

    [SerializeField] Camera cameraFieldOfView;

    float zoomedOutFOV = 60;
    float zoomedInFOV = 20;

    bool zoomedIn = false;
    // Start is called before the first frame update
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            if (zoomedIn == false)
            {
                zoomedIn = true;
                cameraFieldOfView.fieldOfView = zoomedInFOV;
            }
            else
            {
                zoomedIn = false;
                cameraFieldOfView.fieldOfView = zoomedOutFOV;
            }
        }
        

    }

   
}
