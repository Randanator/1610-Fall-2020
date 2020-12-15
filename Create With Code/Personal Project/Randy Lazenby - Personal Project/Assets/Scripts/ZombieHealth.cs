using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieHealth : MonoBehaviour
{
    public float healthValue = 1f;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        healthValue -= 0.35f;

        if (healthValue <=0)
        {
            Destroy(gameObject);
        }
    }
}
