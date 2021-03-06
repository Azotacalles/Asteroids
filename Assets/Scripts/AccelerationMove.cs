using UnityEngine;

namespace Asteroids
{
    internal sealed class AccelerationMove : MoveTransform
    {
        private readonly float acceleration;

        public AccelerationMove(Transform transform, float speed, float acceleration) : base(transform, speed)
        {
            this.acceleration = acceleration;
        }

        public void AddAcceleration()
        {
            Speed += acceleration;
        }

        public void RemoveAcceleration()
        {
            Speed -= acceleration;
        }
    }
}
