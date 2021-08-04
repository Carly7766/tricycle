using UnityEngine;

namespace Tricycle
{
    public class TricycleBehaviour : MonoBehaviour
    {
        public IWheelRotatable FrontWheelRotatable => frontWheel;
        public IWheelRotatable RearWheelRotatable => rearWheel;

        [SerializeField] private WheelBehaviour frontWheel;
        [SerializeField] private WheelBehaviour rearWheel;
    }
}