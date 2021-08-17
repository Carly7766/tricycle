using UniRx;

namespace Input
{
    public interface IInputProvider
    {
        IReadOnlyReactiveProperty<float> FrontWheelSpeed { get; }
        IReadOnlyReactiveProperty<float> RearWheelSpeed { get; }
    }
}