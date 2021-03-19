using UnityEngine;

namespace Asteroids
{
    internal sealed class Ship : IMove, IRotation
    {
        private readonly IMove moveImplementation;
        private readonly IRotation rotationImplementation;

        public float Speed => moveImplementation.Speed;

        public Ship(IMove moveImplementation, IRotation rotationImplementation)
        {
            this.moveImplementation = moveImplementation;
            this.rotationImplementation = rotationImplementation;
        }

        public void Move(float horizontal, float vertical, float deltaTime)
        {
            moveImplementation.Move(horizontal, vertical, deltaTime);
        }

        public void Rotation(Vector3 direction)
        {
            rotationImplementation.Rotation(direction);
        }

        public void AddAcceleration()
        {
            if (moveImplementation is AccelerationMove accelerationMove) accelerationMove.AddAcceleration();
        }

        public void RemoveAcceleration()
        {
            if (moveImplementation is AccelerationMove accelerationMove) accelerationMove.RemoveAcceleration();
        }
    }
}
