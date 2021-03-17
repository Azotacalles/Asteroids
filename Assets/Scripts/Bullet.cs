using UnityEngine;

namespace Asteroids
{
    internal sealed class Bullet : MonoBehaviour
    {
        private Transform barrel;
        private float force = 10;
        [SerializeField] private Rigidbody2D rb;

        public float Force
        {
            get => force;
            set => force = value;
        }

        public Transform Barell
        { 
            get => barrel;
            set => barrel = value;
        }

        private void Update()
        {
            rb.AddForce(barrel.up * force);
        }

        private void OnCollisionExit2D(Collision2D collision)
        {
            Destroy(gameObject);
        }
    }
}
