

using System.ComponentModel;
using System.Diagnostics;
/* 项目“Xtremly.Core.Maui (net6.0-android)”的未合并的更改
在此之前:
using Container =   Xtremly.Core.Container;
在此之后:
using Container = Xtremly.Core.Container;
*/

/* 项目“Xtremly.Core.Maui (net6.0-ios)”的未合并的更改
在此之前:
using Container =   Xtremly.Core.Container;
在此之后:
using Container = Xtremly.Core.Container;
*/

/* 项目“Xtremly.Core.Maui (net6.0-maccatalyst)”的未合并的更改
在此之前:
using Container =   Xtremly.Core.Container;
在此之后:
using Container = Xtremly.Core.Container;
*/

/* 项目“Xtremly.Core.Maui (net6.0-windows10.0.19041.0)”的未合并的更改
在此之前:
using Container =   Xtremly.Core.Container;
在此之后:
using Container = Xtremly.Core.Container;
*/

namespace Xtremly.Core
{
    internal class ContainerRegistry : IContainerRegistry
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        internal Container Container = new();


        public IRegisteredType Register<Target>(Type type)
        {
            return Container.Register<Target>(type);
        }

        public IRegisteredType Register<TInterface, TImplementation>() where TImplementation : TInterface
        {
            return Container.Register<TInterface, TImplementation>();
        }

        public IRegisteredType Register<Target>(Func<Target> factory)
        {
            return Container.Register<Target>(factory);
        }

        public IRegisteredType Register<Target>()
        {
            return Container.Register<Target>();
        }

        public IRegisteredType Register(Type interfaceType, Type ImplementationType)
        {
            return Container.Register(interfaceType, ImplementationType);
        }

        public void RegisterInstance<Target>(Target instace)
        {
            Container.RegisterInstance<Target>(instace);
        }
    }


    internal class ContainerProvider : IContainerProvider
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        internal Container Container;

        internal ContainerProvider(ContainerRegistry containerRegistry)
        {
            Container = containerRegistry.Container;
        }

        public Target Resolve<Target>()
        {
            if (Container.Resolve(typeof(Target)) is Target target)
            {
                return target;
            }

            return default;
        }

        public object Resolve(Type type)
        {
            return Container.Resolve(type);
        }
    }
}
