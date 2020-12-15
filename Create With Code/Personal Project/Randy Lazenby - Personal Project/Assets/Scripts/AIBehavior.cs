using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class AIBehavior : MonoBehaviour
{
    private NavMeshAgent agent;
    private Transform destination;
    [SerializeField] private GameObject player;
    private bool isPlayerNull = false;

    private void Start()
    {
        isPlayerNull = false;
        agent = GetComponent<NavMeshAgent>();
        destination = player.transform;
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
        isPlayerNull = true;
    }

    private void Update()
    {
        if (isPlayerNull)
        {
            agent.SetDestination(Vector3.negativeInfinity);
            Debug.Log("You Died!");
        }
        else
        {
            agent.destination = destination.position;
        }
    }
}
        