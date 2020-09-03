using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class MoverScript : MonoBehaviour
{    public float speed = 5f;
    public float x, y, z;
    void Start()
    {
        Debug.Log("Avengers Assemble!");
    }
    void Update()
    {
        x = speed * Input.GetAxis("Horizontal") * Time.deltaTime;
        y = speed * Input.GetAxis("Vertical") * Time.deltaTime;
        transform.Translate(x,y,z);
    }
    public void Up()
    {
        transform.Translate(0, speed, 0);
    }
     public void Down()
    {
    transform.Translate(0, -speed, 0); }
)