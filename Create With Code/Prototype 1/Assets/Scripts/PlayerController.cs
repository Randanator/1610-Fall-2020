using UnityEngine;

public class PlayerController : MonoBehaviour
{ 
    // Used for forward math calculations
    private Vector3 forward;
    // Used for rotational math calculations
    private Vector3 rotate;
    // variable for speed
    private float speed = 20f;
    // variable for turning rotation
    private float turnSpeed = 45f;
    // variable for the horizontal input gathering
    private float horizontalInput;
    // variable for vertical input gathering
    private float verticalInput;
   // Update is called once per frame
    void Update()
    {
        // does the math for the transform.Translate(forward)
        forward = Vector3.forward * (Time.deltaTime * speed * verticalInput);
        // does the math for the transform.Translate(rotate)
        rotate = Vector3.up * (Time.deltaTime * turnSpeed * horizontalInput);
        // these get the inputs
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        // moves the car forward based on forward math
        transform.Translate(forward);
        // rotates the car based on rotate math
        transform.Rotate(rotate);
    }
}
