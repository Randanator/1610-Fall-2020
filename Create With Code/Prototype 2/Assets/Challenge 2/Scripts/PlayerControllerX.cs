
using UnityEngine;

namespace Challenge_2.Scripts
{
    public class PlayerControllerX : MonoBehaviour
    {
        public GameObject dogPrefab;

        // Update is called once per frame
        void Update()
        {
            // On spacebar press, send dog
            if (Input.GetKeyDown(KeyCode.Space))
            {
                StartCoroutine("SendDog");
            }
        }

        void SendDog()
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
        }
    }
}