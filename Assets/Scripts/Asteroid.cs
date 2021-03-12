using UnityEngine;

namespace Asteroids
{
    internal sealed class Asteroid : Enemy, IRotation, IMove
    {
        private float speed = 2;
        public float Speed { get; }
        public override void InitPosition()
        {
            transform.position = new Vector3(Random.Range(-spawnArea.x, spawnArea.x),
                spawnArea.y, spawnArea.z);
            transform.rotation = Quaternion.identity;
        }

        private void Update()
        {
            Rotation(Vector3.forward);
            Move(0f, speed, Time.deltaTime);
        }

        public void Rotation(Vector3 direction)
        {
            transform.Rotate(direction);
        }

        public void Move(float horizontal, float vertical, float deltaTime)
        {
            Vector3 move = Vector3.zero;
            var speedTemp = deltaTime * speed;
            move.Set(horizontal * speedTemp, vertical * speedTemp, 0.0f);
            transform.localPosition -= move;
        }
    }
}
