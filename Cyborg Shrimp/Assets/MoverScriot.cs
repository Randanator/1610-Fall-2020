using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class MoverScript : MonoBehaviour
{    public float speed = 5f;
    public float x, y, z;
    Void Start()
    {
        Debug.Log("Avengers Assemble!");
    }
    Void Update()
    {
        x = speed * Input.GetAxis("Horizontal") * Time.deltaTime;
        y = speed * Input.GetAxis("Vertical") * Time.deltaTime;
        Transform.Translate(x,y,z);
    }
    public Void Up()
    {
        transform.Translate(0, speed, 0);
    }
     public Void Down()
    {
    Transform.Translate(0, -speed, 0); }
)