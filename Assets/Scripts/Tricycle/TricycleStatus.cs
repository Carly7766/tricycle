using UnityEngine;

namespace Tricycle
{
    [CreateAssetMenu(fileName = "Tricycle Status", menuName = "Tricycle/Tricycle Status")]
    public class TricycleStatus : ScriptableObject
    {
        [SerializeField]
        public float rotateSpeed;
    }
}