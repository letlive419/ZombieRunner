using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickups : MonoBehaviour
{
    [SerializeField] public int ammoAmount = 30;
    [SerializeField] AmmoType ammoType;

    public float lightAngleAmount = 60;
    public float lightAmount = 8;

    private void OnTriggerEnter(Collider other)
    {
       if (other.gameObject.tag == "Player")
        Destroy(gameObject);
        FindObjectOfType<FlashLight>().RestoreLightAngle(lightAngleAmount);
        FindObjectOfType<FlashLight>().RestoreLightAngle(lightAmount);

    }

}
