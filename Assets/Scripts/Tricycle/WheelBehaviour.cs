using UnityEngine;

namespace Tricycle
{
    public class WheelBehaviour : MonoBehaviour, IWheelRotatable, IWheelJumpable
    {
        private WheelJoint2D _wheelJoint2D;
        private WheelJoint2D WheelJoint2D => _wheelJoint2D ??= GetComponent<WheelJoint2D>();

        private Rigidbody2D _rigidbody2D;
        private Rigidbody2D rigidbody2D => _rigidbody2D ??= GetComponent<Rigidbody2D>();

        [SerializeField] private Transform bodyTransform;
        [SerializeField] private ContactFilter2D filter2d;

        public bool IsGround => rigidbody2D.IsTouching(filter2d);

        void FixedUpdate()
        {
            //サスペンションを常に車体と垂直にする
            var suspension = WheelJoint2D.suspension;
            suspension.angle = 90f - transform.localEulerAngles.z + bodyTransform.localEulerAngles.z;
            WheelJoint2D.suspension = suspension;
        }

        public void Rotate(float rotateSpeed)
        {
            var motor = WheelJoint2D.motor;
            motor.motorSpeed = rotateSpeed * 150;
            WheelJoint2D.motor = motor;
        }

        public void Jump(float power)
        {
            Debug.Log(power);
            rigidbody2D.AddForce(Vector2.up * power);
        }
    }
}