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
    private GameManager gameManager;

    private void Start()
    {
        isPlayerNull = false;
        agent = GetComponent<NavMeshAgent>();
        destination = player.transform;
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
    }
    
    private void Update()
    {
        while (isPlayerNull)
        {
           gameManager.GameOver();
           
        }
        
            
        
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
        