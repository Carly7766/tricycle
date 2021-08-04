using UniRx;
using Unity.Mathematics;
using UnityEngine;
using VContainer.Unity;
using Random = UnityEngine.Random;

namespace Stage.Generate
{
    public class StageGenerator : IInitializable
    {
        private readonly GenerateSettings _generateSettings;
        private readonly CameraPositionMonitor _positionMonitor;
        private readonly StageContainer _stageContainer;

        public StageGenerator(GenerateSettings generateSettings, CameraPositionMonitor positionMonitor,
            StageContainer stageContainer)
        {
            _generateSettings = generateSettings;
            _positionMonitor = positionMonitor;
            _stageContainer = stageContainer;
        }

        public void Initialize()
        {
            var initialStage = _generateSettings.initialStage;
            var initialgeneratePos = new Vector3(0, 0, 0);
            var initialStageGameObject =
                Object.Instantiate(initialStage.prefab, initialgeneratePos, quaternion.identity);

            var initialStageObject = new StageObject(initialStage, initialgeneratePos, initialStageGameObject);
            _stageContainer.AddStage(initialStageObject);

            var prevGeneratedStage = initialStage;
            var nextGenerateBorderX = prevGeneratedStage.width / 2;

            _positionMonitor.OnPositionChangedRight.Subscribe(
                posX =>
                {
                    if (posX + _generateSettings.aheadGenerateWidth > nextGenerateBorderX)
                    {
                        var generateStage = _generateSettings.GetRandomStage();
                        var generatePos = new Vector3(nextGenerateBorderX + generateStage.width / 2, 0);

                        var generatedGameObject =
                            Object.Instantiate(generateStage.prefab, generatePos, quaternion.identity);

                        var stageObject = new StageObject(generateStage, generatePos, generatedGameObject);
                        _stageContainer.AddStage(stageObject);

                        nextGenerateBorderX += generateStage.width;
                    }
                });
        }
    }
}
