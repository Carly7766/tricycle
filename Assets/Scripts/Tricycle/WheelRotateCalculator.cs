namespace Tricycle
{
    public class WheelRotateCalculator
    {
        private TricycleStatus _tricycleStatus;

        public WheelRotateCalculator(TricycleStatus tricycleStatus)
        {
            _tricycleStatus = tricycleStatus;
        }

        public float CalculateSpeed(float input)
        {
            return input * _tricycleStatus.rotateSpeed;
        }
    }
}