using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    private Vector3 camera;
    public Vector3 offset = new Vector3(0, 5, -10);
    // Update is called once per frame
    public void Update()
    {
        camera = player.transform.position + offset;
        transform.position = camera;
    }
}
