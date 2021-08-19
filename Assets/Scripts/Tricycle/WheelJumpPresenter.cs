using Input;
using UniRx;
using VContainer;
using VContainer.Unity;

namespace Tricycle
{
    public class WheelJumpPresenter : IInitializable
    {
        private IInputProvider _inputProvider;
        private TricycleBehaviour _tricycleBehaviour;
        private TricycleStatus _tricycleStatus;

        [Inject]
        public WheelJumpPresenter(IInputProvider inputProvider, TricycleBehaviour tricycleBehaviour,
            TricycleStatus tricycleStatus)
        {
            _inputProvider = inputProvider;
            _tricycleBehaviour = tricycleBehaviour;
            _tricycleStatus = tricycleStatus;
        }

        public void Initialize()
        {
            IWheelJumpable frontWheelJumpable = _tricycleBehaviour.FrontWheelJumpable;
            _inputProvider.GetFrontWheelJump().Where(_ => frontWheelJumpable.IsGround)
                .Subscribe(_ => frontWheelJumpable.Jump(_tricycleStatus.frontWheelJumpPower));

            IWheelJumpable rearWheelJumpable = _tricycleBehaviour.RearWheelJumpable;
            _inputProvider.GetRearWheelJump().Where(_ => rearWheelJumpable.IsGround)
                .Subscribe(_ => rearWheelJumpable.Jump(_tricycleStatus.rearWheelJumpPower));
        }
    }
}