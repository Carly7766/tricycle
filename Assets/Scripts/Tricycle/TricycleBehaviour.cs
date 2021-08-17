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

        public void Relocation(Vector2 position)
        {
            test.transform.position = position;
            frontWheel.transform.position = position + new Vector2(0.4596f, -0.3211f);
            rearWheel.transform.position = position + new Vector2(-0.457495f, -0.3705737f);
        }
    }
}