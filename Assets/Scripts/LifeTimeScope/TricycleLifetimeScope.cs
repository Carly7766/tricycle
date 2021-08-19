using Input;
using Tricycle;
using UnityEngine;
using VContainer;
using VContainer.Unity;

namespace LifeTimeScope
{
    public class TricycleLifetimeScope : LifetimeScope
    {
        [SerializeField] TricycleStatus tricycleStatus;

        protected override void Configure(IContainerBuilder builder)
        {
            builder.RegisterComponentInHierarchy<KeyInputProvider>().As<IInputProvider>();
            builder.RegisterComponentInHierarchy<TricycleBehaviour>();
            builder.RegisterInstance(tricycleStatus);
            builder.RegisterEntryPoint<WheelRotatePresenter>(Lifetime.Scoped);
            builder.RegisterEntryPoint<WheelJumpPresenter>(Lifetime.Scoped);
        }
    }
}