using UnityEngine;
using UnityEngine.Serialization;

namespace Tricycle
{
    public class TricycleBehaviour : MonoBehaviour
    {
        public IWheelRotatable FrontWheelRotatable => frontWheel;
        public IWheelRotatable RearWheelRotatable => rearWheel;

        [SerializeField] private WheelBehaviour frontWheel;
        [SerializeField] private WheelBehaviour rearWheel;

        [SerializeField] private Rigidbody2D test;
        [SerializeField] private Vector3 centerMassPosition = Vector3.zero;

        private void OnValidate()
        {
            test.centerOfMass = centerMassPosition;
            // Start時に動いてない状態だとSleepになるので解除してあげる
            if (test.IsSleeping())
            {
                test.WakeUp();
            }
        }
    }
}