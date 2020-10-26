using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickups : MonoBehaviour
{
    [SerializeField] public int ammoAmount = 30;
    [SerializeField] AmmoType ammoType;

    private void OnTriggerEnter(Collider other)
    {
       if (other.gameObject.tag == "Player")
        Destroy(gameObject);
        FindObjectOfType<Ammo>().IncreaseAmmo(ammoType, ammoAmount);
    }

}
