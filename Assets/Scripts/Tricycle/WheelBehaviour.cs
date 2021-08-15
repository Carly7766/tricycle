using UnityEngine;

namespace Tricycle
{
    public class WheelBehaviour : MonoBehaviour, IWheelRotatable
    {
        private WheelJoint2D _wheelJoint2D;
        public WheelJoint2D WheelJoint2D => _wheelJoint2D ??= GetComponent<WheelJoint2D>();

        [SerializeField] private Transform bodyTransform;

        public void Rotate(float rotateSpeed)
        {
            var motor = WheelJoint2D.motor;
            motor.motorSpeed = rotateSpeed * 150;
            WheelJoint2D.motor = motor;
        }

        void FixedUpdate()
        {
            //サスペンションを常に車体と垂直にする
            var suspension = WheelJoint2D.suspension;
            suspension.angle = 90f - transform.localEulerAngles.z + bodyTransform.localEulerAngles.z;
            WheelJoint2D.suspension = suspension;
        }
    }
}