using UniRx;
using UnityEngine;
using VContainer.Unity;

namespace Stage.Generate
{
    public class StageDestroyer : IPostInitializable
    {
        private readonly CameraPositionMonitor _positionMonitor;
        private GenerateSettings _generateSettings;
        private readonly StageContainer _stageContainer;

        public StageDestroyer(GenerateSettings generateSettings, CameraPositionMonitor positionMonitor,
            StageContainer stageContainer)
        {
            _generateSettings = generateSettings;
            _positionMonitor = positionMonitor;
            _stageContainer = stageContainer;
        }

        public void PostInitialize()
        {
            var destroyTarget = _stageContainer.GetFirstStage();

            _positionMonitor.OnPositionChangedLeft
                .Subscribe(posX =>
                {
                    Debug.Log($"{posX}, {destroyTarget.posX + destroyTarget.width / 2}");
                    if (posX > destroyTarget.posX + destroyTarget.width / 2)
                    {
                        destroyTarget.Destroy();
                        _stageContainer.DestroyFirstStage(destroyTarget);
                        destroyTarget = _stageContainer.GetFirstStage();
                    }
                });
        }
    }
}
