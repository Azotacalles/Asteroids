using UnityEngine;

namespace Asteroids
{
    internal sealed class Health
    {
        public float Max { get; }
        public float Current { get; private set; }

        public Health(float max, float current)
        {
            Max = max;
            Current = current;
        }

        public void ChangeCurrentHEalth(float hp)
        {
            Current = hp;
        }
    }
}
