using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Stage.Generate
{
    public class StageContainer
    {
        private List<StageObject> _stages = new List<StageObject>();
        public int StageLength => _stages.Count;

        public void AddStage(StageObject stageObject)
        {
            _stages.Add(stageObject);
        }

        public void DestroyFirstStage(StageObject stageObject)
        {
            stageObject.Destroy();
            _stages.Remove(stageObject);
        }

        public StageObject GetFirstStage() => _stages.First();
    }
}
