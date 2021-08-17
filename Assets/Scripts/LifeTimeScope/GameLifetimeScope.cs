using Game;
using UnityEngine;
using VContainer;
using VContainer.Unity;

namespace LifeTimeScope
{
    public class GameLifetimeScope : LifetimeScope
    {
        protected override void Configure(IContainerBuilder builder)
        {
            builder.Register<RetryController>(Lifetime.Scoped);
        }
    }
}