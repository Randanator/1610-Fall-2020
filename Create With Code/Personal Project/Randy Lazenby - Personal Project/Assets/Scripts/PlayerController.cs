using System;
using UnityEditor;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private CharacterController controller;
    public Rigidbody playerRb;
    public float speed = 1000f;
    public bool shoot;
    public float horizontalInput;
    
    
    private void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        shoot = Input.GetKeyDown(KeyCode.Space);
        playerRb.AddForce(Vector3.right * (speed * horizontalInput * Time.deltaTime));
        if (shoot)
        {
            
        }
    }
}
