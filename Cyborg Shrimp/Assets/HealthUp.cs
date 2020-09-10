using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthUp : MonoBehaviour
{
    public int health;
    private void OnTriggerEnter(Collider other)
    {
        health++;
        print(health);
    }
}
