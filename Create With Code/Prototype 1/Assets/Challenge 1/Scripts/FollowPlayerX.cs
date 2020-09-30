using UnityEngine;

namespace Challenge_1.Scripts
{
    public class FollowPlayerX : MonoBehaviour
    {
        public GameObject plane;
        private Vector3 offset = new Vector3(0, 5 , -10);
        // Update is called once per frame
        public void Update()
        {
            transform.position = plane.transform.position + offset;
        }
    }
}
