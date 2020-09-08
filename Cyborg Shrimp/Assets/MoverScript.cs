
using UnityEngine;

public class MoverScript : MonoBehaviour
{
    public float speed = 5f;
    public float health = 100f;
    public int points = 60;
    public string password = "12345";
    public string playerName = "Randanator";
    private void Update()
    {
        var vInput = speed * Time.deltaTime * Input.GetAxis("Vertical");
        var hInput = speed * Time.deltaTime * Input.GetAxis("Horizontal");
        transform.Translate(hInput, vInput, 0);
    }

    public void Up()
    {
        transform.Translate(0, speed, 0);
    }

    public void Down()
    {
        transform.Translate(0, -speed, 0);
    }

    public void Left()
    {
        transform.Translate(-speed, 0, 0);
    }

    public void Right()
    {
        transform.Translate(speed, 0, 0);
    }
}