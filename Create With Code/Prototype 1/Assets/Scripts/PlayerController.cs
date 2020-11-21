using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // variable for speed
    [SerializeField] float speed = 20f;
    // variable for turning rotation
    [SerializeField] float turnSpeed = 45f;
    // variable for the horizontal input gathering
    private float horizontalInput;
    // variable for vertical input gathering
    private float verticalInput;
    // Update is called once per frame
    void FixedUpdate()
    {
        // these get the inputs
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        // moves the car forward based on forward math
        transform.Translate(Vector3.forward * (Time.deltaTime * speed * verticalInput));
        // rotates the car based on rotate math
        transform.Rotate(Vector3.up * (Time.deltaTime * turnSpeed * horizontalInput));
    }
}
