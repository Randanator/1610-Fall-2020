using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    [SerializeField] Vector3 offset = new Vector3(0, 0, 0);
    // Update is called once per frame
    public void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}
