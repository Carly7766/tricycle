using System;
using Input;
using VContainer;
using UniRx;
using VContainer.Unity;

namespace Tricycle
{
    public class WheelRotatePresenter : IInitializable
    {
        private IInputProvider _inputProvider;
        private TricycleBehaviour _tricycleBehaviour;
        private WheelRotateCalculator _wheelRotateCalculator;

        [Inject]
        public WheelRotatePresenter(IInputProvider inputProvider, TricycleBehaviour tricycleBehaviour,
            TricycleStatus tricycleStatus)
        {
            _inputProvider = inputProvider;
            _tricycleBehaviour = tricycleBehaviour;
            _wheelRotateCalculator = new WheelRotateCalculator(tricycleStatus);
        }

        public void Initialize()
        {
            _inputProvider.FrontWheelSpeed.Subscribe(input =>
                _tricycleBehaviour.FrontWheelRotatable.Rotate(_wheelRotateCalculator.CalculateFrontRotateSpeed(input)));

            _inputProvider.RearWheelSpeed.Subscribe(input =>
                _tricycleBehaviour.RearWheelRotatable.Rotate(_wheelRotateCalculator.CalculateRearRotateSpeed(input)));
        }
    }
}