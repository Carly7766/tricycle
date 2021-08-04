using System;
using UniRx;
using UnityEngine;

namespace Stage.Generate
{
    public class CameraPositionMonitor : MonoBehaviour
    {
        private new Camera _camera;
        public IObservable<float> OnPositionChangedLeft { get; private set; }
        public IObservable<float> OnPositionChangedRight { get; private set; }

        private void Awake()
        {
            _camera = GetComponent<Camera>();

            OnPositionChangedLeft = transform.ObserveEveryValueChanged(t => t.position)
                .Select(_ => _camera.ScreenToWorldPoint(Vector3.zero).x);

            OnPositionChangedRight = transform.ObserveEveryValueChanged(t => t.position)
                .Select(_ => _camera.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 0.0f)).x);
        }
    }
}
