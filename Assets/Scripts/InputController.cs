using UnityEngine;

namespace Asteroids
{
    internal sealed class InputController
    {
        private Rigidbody2D bullet;
        private Transform barrel;
        private Ship ship;
        private Camera camera = Camera.main;
        
        public InputController(Ship ship, Transform barrel, Rigidbody2D bullet)
        {
            this.ship = ship;
            this.barrel = barrel;
            this.bullet = bullet;
        }

        public void Update()
        {
            var direction = Input.mousePosition - camera.WorldToScreenPoint(barrel.transform.position);
            ship.Rotation(direction);

            ship.Move(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), Time.deltaTime);

            if (Input.GetKeyDown(KeyCode.LeftShift))
            {
                ship.AddAcceleration();
            }

            if (Input.GetKeyUp(KeyCode.LeftShift))
            {
                ship.RemoveAcceleration();
            }

            if (Input.GetButtonDown("Fire1"))
            {
                ICreate create = new Bullet(barrel.transform, bullet);
                create.CreateObject();
            }
        }
    }
}
