using UniRx;
using UnityEngine;

namespace Game
{
    public class KeyInputProvider : MonoBehaviour, IInputProvider
    {
        public IReadOnlyReactiveProperty<float> FrontWheelSpeed => _frontWheelSpeed;
        public IReadOnlyReactiveProperty<float> RearWheelSpeed => _rearWheelSpeed;

        private readonly ReactiveProperty<float> _frontWheelSpeed = new ReactiveProperty<float>();
        private readonly ReactiveProperty<float> _rearWheelSpeed = new ReactiveProperty<float>();

        private void Update()
        {
            _frontWheelSpeed.Value = Input.GetAxis("FrontWheel");
            _rearWheelSpeed.Value = Input.GetAxis("RearWheel");
        }
    }
}