using System;
using System.Collections;
using UnityEngine;
[RequireComponent(typeof(Rigidbody))]
public class BulletBehaviour : MonoBehaviour
{
    private Rigidbody rBody;
    public float bulletForce = 500f;
    public float lifeTime = 2f;
    private IEnumerator Start()
    {
        rBody = GetComponent<Rigidbody>();
        rBody.AddForce(transform.forward * bulletForce);
        yield return new WaitForSeconds(lifeTime);
        Destroy(gameObject);
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }
}
