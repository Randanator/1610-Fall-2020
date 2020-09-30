using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    private Vector3 camera;
    public Vector3 offset = new Vector3(0, 5, -10);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        camera = player.transform.position + offset;
        transform.position = camera;
    }
}
