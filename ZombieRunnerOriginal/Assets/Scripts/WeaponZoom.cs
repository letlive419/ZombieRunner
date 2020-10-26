using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class WeaponZoom : MonoBehaviour
{

    [SerializeField] Camera cameraFieldOfView;
    RigidbodyFirstPersonController sensitivityController;


    private void Start()
    {
        sensitivityController = GetComponent<RigidbodyFirstPersonController>();
        

    }
    float zoomedOutFOV = 60;
    float zoomedInFOV = 20;

    bool zoomedIn = false;
    // Start is called before the first frame update


    void Update()
    {
        //if (Input.GetMouseButtonDown(1))
        //{
        //    if (zoomedIn == false)
        //    {
        //        zoomedIn = true;
        //        cameraFieldOfView.fieldOfView = zoomedInFOV;
        //        sensitivityController.mouseLook.XSensitivity = 1f;
        //        sensitivityController.mouseLook.YSensitivity = 1f;
                
        //    }
        //    else
        //    {
        //        zoomedIn = false;
        //        cameraFieldOfView.fieldOfView = zoomedOutFOV;
        //        sensitivityController.mouseLook.XSensitivity = 2f;
        //        sensitivityController.mouseLook.YSensitivity = 2f;
        //    }
        //}
        

    }

   
}
