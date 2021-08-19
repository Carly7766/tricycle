namespace Tricycle
{
    public interface IWheelJumpable
    {
        void Jump(float power);
        bool IsGround { get; }
    }
}