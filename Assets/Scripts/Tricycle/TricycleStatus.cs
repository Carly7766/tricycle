using UnityEngine;
using UnityEngine.Serialization;

namespace Tricycle
{
    [CreateAssetMenu(fileName = "Tricycle Status", menuName = "Tricycle/Tricycle Status")]
    public class TricycleStatus : ScriptableObject
    {
        [FormerlySerializedAs("rotateSpeed")] [SerializeField]
        public float frontWheelRotateSpeed;
        [SerializeField] public float rearWheelRotateSpeed;
    }
}