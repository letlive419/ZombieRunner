using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ammo : MonoBehaviour
{

    [SerializeField] AmmoSlot[] ammoSlots;


    [System.Serializable]
    private void AmmoSlot()
    {
        public int ammoAmount;
   public AmmoType ammoType;

    }

    public int ReturnAmmo()
    {
        return ammoAmount;
    }

    public void reduceAmmo()
    {
        ammoAmount--;
    }
}
}