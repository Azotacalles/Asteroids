using UnityEngine;

namespace Asteroids
{
    public static class BuilderExtensions
    {
        public static GameObject SetName(this GameObject gameObject, string name)
        {
            gameObject.name = name;
            return gameObject;
        }

        public static GameObject AddBoxCollider2D(this GameObject gameObject)
        {
            var component = GetOrAddComponent<BoxCollider2D>(gameObject);
            return gameObject;
        }

        private static T GetOrAddComponent<T>(this GameObject gameObject) where T : Component
        {
            var result = gameObject.GetComponent<T>();
            if (!result) result = gameObject.AddComponent<T>();
            return result;
        }
            
    }
}
