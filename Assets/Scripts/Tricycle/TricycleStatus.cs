using UnityEngine;
using UnityEngine.Serialization;

namespace Tricycle
{
    [CreateAssetMenu(fileName = "Tricycle Status", menuName = "Tricycle/Tricycle Status")]
    public class TricycleStatus : ScriptableObject
    { 
        [SerializeField] public float frontWheelRotateSpeed;
        [SerializeField] public float rearWheelRotateSpeed;
        [SerializeField] public float frontWheelJumpPower;
        [SerializeField] public float rearWheelJumpPower;
    }
}