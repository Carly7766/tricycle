using System;
using UniRx;
using UniRx.Triggers;
using UnityEngine;

namespace Input
{
    public class KeyInputProvider : MonoBehaviour, IInputProvider
    {
        public IReadOnlyReactiveProperty<float> FrontWheelSpeed => _frontWheelSpeed;
        public IReadOnlyReactiveProperty<float> RearWheelSpeed => _rearWheelSpeed;

        public IObservable<Unit> GetFrontWheelJump()
        {
            return this.UpdateAsObservable().Where(_ => UnityEngine.Input.GetButtonDown("FrontJump"));
        }

        public IObservable<Unit> GetRearWheelJump()
        {
            return this.UpdateAsObservable().Where(_ => UnityEngine.Input.GetButtonDown("RearJump"));
        }

        private readonly ReactiveProperty<float> _frontWheelSpeed = new ReactiveProperty<float>();
        private readonly ReactiveProperty<float> _rearWheelSpeed = new ReactiveProperty<float>();

        private void Awake()
        {
            this.UpdateAsObservable().Subscribe(_ =>
            {
                _frontWheelSpeed.Value = UnityEngine.Input.GetAxis("FrontWheel");
                _rearWheelSpeed.Value = UnityEngine.Input.GetAxis("RearWheel");
            });
        }
    }
}