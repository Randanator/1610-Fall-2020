using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class AIBehavior : MonoBehaviour
{
    private NavMeshAgent agent;
    private Transform destination;
    [SerializeField] private GameObject player;

    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        destination = player.transform;
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
    }

    private void Update()
    {
        agent.destination = destination.position;
    }
}