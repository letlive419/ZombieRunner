using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class batteryPickUp : MonoBehaviour
{
    [SerializeField] public float lightAngleAmount = 60;
    [SerializeField] public float lightAmount = 8;
  
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            FindObjectOfType<FlashLight>().RestoreLightAngle(lightAngleAmount);
            FindObjectOfType<FlashLight>().RestoreLightIntensity(lightAmount);
        }
    }

}
