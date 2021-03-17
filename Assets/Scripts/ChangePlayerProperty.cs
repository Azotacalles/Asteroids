using UnityEngine;

namespace Asteroids
{
    internal sealed class ChangePlayerProperty
    {
        public static void MinusHP(Player player)
        {
            if (player.HP <= 0) Object.Destroy(player.gameObject);
            else player.HP--;
            Debug.Log(player.HP);
        }
    }
}
