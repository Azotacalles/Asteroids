using UnityEngine;

namespace Asteroids
{
    internal sealed class Bullet : MonoBehaviour
    {
        private Transform barrel;
        private float force = 500;
        [SerializeField] private Rigidbody2D rb;

        public Transform Barell
        { 
            get => barrel;
            set => barrel = value;
        }

        private void Update()
        {
            rb.AddForce(barrel.up * force);
        }
    }
}
