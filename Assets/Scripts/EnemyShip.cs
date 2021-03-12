using UnityEngine;

namespace Asteroids
{
    internal sealed class EnemyShip : Enemy, IMove
    {
        private float speed = 1;

        public float Speed { get; }

        private void Update()
        {
            Move(0f, speed, Time.deltaTime);
        }

        public void Move(float horizontal, float vertical, float deltaTime)
        {
            Vector3 move = Vector3.zero;
            var speedTemp = deltaTime * speed;
            move.Set(horizontal * speedTemp, vertical * speedTemp, 0.0f);
            transform.localPosition -= move;
        }

        public override void InitPosition()
        {
            transform.position = new Vector3(Random.Range(-spawnArea.x, spawnArea.x),
                spawnArea.y, spawnArea.z);
            transform.rotation = Quaternion.identity;
        }
    }
}
