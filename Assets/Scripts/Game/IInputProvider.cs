using UniRx;

namespace Game
{
    public interface IInputProvider
    {
        IReadOnlyReactiveProperty<float> FrontWheelSpeed { get; }
        IReadOnlyReactiveProperty<float> RearWheelSpeed { get; }
    }
}