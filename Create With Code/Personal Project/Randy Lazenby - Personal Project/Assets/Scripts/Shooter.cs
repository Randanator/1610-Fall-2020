using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
public class Shooter : MonoBehaviour
{
        public GameObject bullet;
        private float fireRate;
        private float nextFire;
        private void Start()
        {
            fireRate = 1f;
            nextFire = Time.time;
        }
        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space) && Time.time > nextFire)
            {
                Instantiate(bullet, transform.position, transform.rotation);
                nextFire = Time.time + fireRate;
            }
            
        }
        
    }


