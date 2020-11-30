using UnityEngine;

namespace GAME_TEST_01.Item
{
    [RequireComponent(typeof(Collider))]
    public class Portal: MonoBehaviour
    {
        private Collider m_doorCollider;
        private bool m_isPassthrough;
        public void Start()
        {
            m_doorCollider = GetComponent<BoxCollider>();
        }
        private void OnCollisionEnter(Collision collision)
        {
            collision.transform.position = GameObject.Find("Green_Portal (1)").transform.position;

        }   
    }
}