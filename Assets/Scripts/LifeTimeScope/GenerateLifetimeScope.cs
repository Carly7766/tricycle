using Stage.Generate;
using UnityEngine;
using VContainer;
using VContainer.Unity;

namespace LifeTimeScope
{
    public class GenerateLifetimeScope : LifetimeScope
    {
        [SerializeField] private GenerateSettings generateSettings;
        [SerializeField] private CameraPositionMonitor cameraPositionMonitor;

        protected override void Configure(IContainerBuilder builder)
        {
            builder.RegisterInstance(generateSettings);

            builder.RegisterInstance(cameraPositionMonitor);
            builder.UseEntryPoints(Lifetime.Scoped, pointsBuilder =>
            {
                pointsBuilder.Add<StageContainer>();
                pointsBuilder.Add<StageGenerator>();
                pointsBuilder.Add<StageDestroyer>();
            });
        }
    }
}
