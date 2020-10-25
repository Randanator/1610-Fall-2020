using System;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private CharacterController controller;
    public Rigidbody playerRb;
    public float speed = 1000f;
    public float verticalInput;
    public float horizontalInput;
    
    private void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        playerRb.AddForce(Vector3.forward * (speed * verticalInput * Time.deltaTime));
        playerRb.AddForce(Vector3.right * (speed * horizontalInput * Time.deltaTime));
    }
}
