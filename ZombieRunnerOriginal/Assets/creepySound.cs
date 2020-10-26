using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class creepySound : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
      GetComponent<AudioSource>().Play();
    }
}
