namespace Tricycle
{
    public class WheelRotateCalculator
    {
        private TricycleStatus _tricycleStatus;

        public WheelRotateCalculator(TricycleStatus tricycleStatus)
        {
            _tricycleStatus = tricycleStatus;
        }

        public float CalculateFrontRotateSpeed(float input)
        {
            return input * _tricycleStatus.frontWheelRotateSpeed;
        }

        public float CalculateRearRotateSpeed(float input)
        {
            return input * _tricycleStatus.frontWheelRotateSpeed;
        }
    }
}