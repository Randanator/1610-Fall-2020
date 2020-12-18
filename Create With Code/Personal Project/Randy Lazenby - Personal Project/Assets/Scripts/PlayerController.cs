using System;
using UnityEditor;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class PlayerController : MonoBehaviour
{
    private CharacterController controller;
    public float moveSpeed = 5f, gravity = -9.81f, jumpForce = 10f;

    private Vector3 moveDirection;
    private float yDirection;
    public bool gameOver = false;
    public GameObject Bullet;
    public float speed = 10;
    public float rotationSpeed = 180;
    private float playerHealth = 1;
    private bool isPlayerNull = false;
    private GameManager gameManager;
    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        isPlayerNull = true;
        gameManager.GameOver();
        
    }

    private void Start()
    {
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
        controller = GetComponent<CharacterController>();
    }

    private void Update()
    {
        Vector3 rotation = new Vector3(0, Input.GetAxisRaw("Horizontal") * rotationSpeed * Time.deltaTime, 0);
        this.transform.Rotate(rotation);
        Vector3 move = new Vector3(0, 0, Input.GetAxisRaw("Vertical") * Time.deltaTime);
        move = this.transform.TransformDirection(move);
        controller.Move(move * speed);

        var movement = moveDirection * Time.deltaTime;
        controller.Move(movement);
    }
}