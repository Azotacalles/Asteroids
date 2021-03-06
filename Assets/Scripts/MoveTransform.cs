using UnityEngine;

namespace Asteroids
{
    internal class MoveTransform : IMove
    {
        private readonly Transform transform;
        private Vector3 move;

        public float Speed { get; protected set; }

        public MoveTransform(Transform transform, float speed)
        {
            this.transform = transform;
            Speed = speed;
        }

        public void Move(float horizontal, float vertical, float deltaTime)
        {
            var speedTemp = deltaTime * Speed;
            move.Set(horizontal * speedTemp, vertical * speedTemp, 0.0f);
            transform.localPosition += move;
        }
    }
}
