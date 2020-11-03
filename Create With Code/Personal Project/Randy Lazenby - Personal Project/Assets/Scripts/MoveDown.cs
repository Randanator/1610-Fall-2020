using UnityEngine;

public class MoveDown : MonoBehaviour
{
    public Rigidbody objectRb;
    public float speed = 5;
    // Start is called before the first frame update
    void Start()
    {
        objectRb.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        objectRb.AddForce(Vector3.forward * (-speed * Time.deltaTime));
    }
}
