<<<<<<< Updated upstream
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
=======
﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;
>>>>>>> Stashed changes

public class CharacterMover : MonoBehaviour
{
    private CharacterController Controller;
	
    public float Gravity = 9.81f;
    public float MoveSpeed = 3.0f;
    public float JumpSpeed = 3.0f;
	
    private Vector3 position;
    private Vector3 rotation;
<<<<<<< Updated upstream
	
=======
    [SerializeField] private GameObject bulletPrefab;
>>>>>>> Stashed changes
    void Start ()
    {
        Controller = GetComponent<CharacterController>();
    }
	
    void Update ()
    {
<<<<<<< Updated upstream
        if (Controller.isGrounded)
        {
            position.Set(MoveSpeed*Input.GetAxis("Horizontal"), 0, 0);
            //rotation.Set(0, Input.GetAxis("Horizontal"), 0);
            //transform.Rotate(rotation);
            position = transform.TransformDirection(position);
			
            if (Input.GetButton("Jump"))
            {
                position.y = JumpSpeed;
            }
        }
        position.y -= Gravity * Time.deltaTime;
        Controller.Move(position * Time.deltaTime);
    }
=======
        position.Set(MoveSpeed*Input.GetAxis("Horizontal"), 0, MoveSpeed*Input.GetAxis("Vertical"));
            //rotation.Set(0, Input.GetAxis("Horizontal"), 0);
            //transform.Rotate(rotation);
        position = transform.TransformDirection(position);
            
        position.y -= Gravity * Time.deltaTime;
        Controller.Move(position * Time.deltaTime);
    }

    private void OnMouseDown()
    {
        Instantiate(bulletPrefab);
    }
>>>>>>> Stashed changes
}
