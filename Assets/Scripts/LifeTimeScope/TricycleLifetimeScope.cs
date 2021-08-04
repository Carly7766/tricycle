using Game;
using Tricycle;
using UnityEngine;
using VContainer;
using VContainer.Unity;

namespace LifeTimeScope
{
    public class TricycleLifetimeScope : LifetimeScope
    {
        [SerializeField] TricycleStatus ttricycleStatus;

        protected override void Configure(IContainerBuilder builder)
        {
            builder.RegisterComponentInHierarchy<KeyInputProvider>().As<IInputProvider>();
            builder.RegisterComponentInHierarchy<TricycleBehaviour>();
            builder.RegisterInstance(ttricycleStatus);
            builder.RegisterEntryPoint<WheelRotatePresenter>(Lifetime.Scoped);
        }
    }
}