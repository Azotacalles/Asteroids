using UnityEngine;

namespace Asteroids
{
    internal sealed class Player : MonoBehaviour
    {
        [SerializeField] private float speed;
        [SerializeField] private float acceleration;
        [SerializeField] private float hp;
        //[SerializeField] private Rigidbody2D bullet;
        [SerializeField] private Transform barrel;
        private Ship ship;
        private InputController inputController;

        public float HP
        {
            get { return hp; }
            set { hp = value; }
        }
        
        private void Start()
        {
            var moveTransform = new AccelerationMove(transform, speed, acceleration);
            var rotation = new RotationShip(transform);
            ship = new Ship(moveTransform, rotation);
            inputController = new InputController(ship, barrel);//, bullet);
        }

        private void Update()
        {
            inputController.Update();
        }

        private void OnCollisionEnter2D(Collision2D collision)
        {
            StatePlayer statePlayer = new StatePlayer();
            statePlayer.ChangeHP(collision, ref hp);
        }
    }
}
