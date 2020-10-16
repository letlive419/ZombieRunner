using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageTakenDisplay : MonoBehaviour
{

    [SerializeField] Canvas damageTaken;
    [SerializeField] float damageTakenTime = 3f;

    private void Start()
    {
        damageTaken.enabled = false;
    }
    public void startDamageTaken()
    {
        StartCoroutine(presentAttack());
    }

    IEnumerator presentAttack()
    {
        damageTaken.enabled = true;
        yield return new WaitForSeconds(damageTakenTime);
        damageTaken.enabled = false;

    }
}
