using UnityEngine;
using UnityEngine.Serialization;

namespace Tricycle
{
    public class TricycleBehaviour : MonoBehaviour
    {
        [SerializeField] private WheelBehaviour frontWheel;
        [SerializeField] private WheelBehaviour rearWheel;

        public IWheelRotatable FrontWheelRotatable => frontWheel;
        public IWheelRotatable RearWheelRotatable => rearWheel;

        public IWheelJumpable FrontWheelJumpable => frontWheel;
        public IWheelJumpable RearWheelJumpable => rearWheel;

        public void Relocation(Vector2 position)
        {
            transform.position = position;
            frontWheel.transform.position = position + new Vector2(0.4596f, -0.3211f);
            rearWheel.transform.position = position + new Vector2(-0.457495f, -0.3705737f);
        }
    }
}