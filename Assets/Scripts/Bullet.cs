using UnityEngine;

namespace Asteroids
{
    internal sealed class Bullet : ICreate
    {
        private Transform barrel;
        private float force = 500;
        private Rigidbody2D bullet;

        public Bullet(Transform barrel, Rigidbody2D bullet)
        {
            this.barrel = barrel;
            this.bullet = bullet;
        }

        public void CreateObject()
        {
            var temAmmunition = MonoBehaviour.Instantiate(bullet, barrel.position, barrel.rotation);
            temAmmunition.AddForce(barrel.up * force);
        }

        
    }
}
