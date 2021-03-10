using UnityEngine;

namespace Asteroids
{
    internal sealed class EnemyShip : Enemy
    {
        private float speed = 1;

        private void Update()
        {
            Move(0f, speed, Time.deltaTime);
        }

        public void Move(float horizontal, float vertical, float deltaTime)
        {
            Vector3 move = Vector3.zero;
            var speedTemp = deltaTime * speed;
            move.Set(horizontal * speedTemp, vertical * speedTemp, 0.0f);
            transform.localPosition += move;
        }
    }
}
