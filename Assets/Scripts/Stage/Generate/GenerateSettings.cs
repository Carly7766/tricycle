using System;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Stage.Generate
{
    [CreateAssetMenu(fileName = "Generate Settings", menuName = "Settings/Create GenerateSettings")]
    public class GenerateSettings : ScriptableObject
    {
        public float aheadGenerateWidth;
        public Stage initialStage;
        public Stage[] stages;

        public Stage GetRandomStage()
        {
            return stages[Random.Range(0, stages.Length)];
        }
    }
}