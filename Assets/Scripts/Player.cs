using UnityEngine;

namespace Asteroids
{
    delegate void Action(Player player);
    internal sealed class Player : MonoBehaviour
    {
        [SerializeField] private float speed;
        [SerializeField] private float acceleration;
        [SerializeField] private float hp;
        [SerializeField] private Transform barrel;
        private Ship ship;
        private InputController inputController;
        private Action changeProperty;
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
            inputController = new InputController(ship, barrel);
            changeProperty += new ChangePlayerProperty().MinusHP;
        }

        private void Update()
        {
            inputController.Update();
        }

        private void OnCollisionEnter2D(Collision2D collision)
        {
            changeProperty(this);
            Destroy(collision.gameObject);
        }
    }
}
