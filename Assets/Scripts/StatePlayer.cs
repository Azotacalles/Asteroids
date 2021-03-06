using UnityEngine;

namespace Asteroids
{
    internal sealed class StatePlayer
    {
        public void ChangeHP(Collision2D collision , ref float hp)
        {
            if (hp <= 0) MonoBehaviour.Destroy(collision.gameObject);
            else hp--;
        }
    }
}
