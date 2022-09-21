
/* 项目“Xtremly.Core.Wpf (netcoreapp3.1)”的未合并的更改
在此之前:
using Xtremly.Core;
在此之后:
using System;
*/

/* 项目“Xtremly.Core.Wpf (net7.0-windows)”的未合并的更改
在此之前:
using Xtremly.Core;
在此之后:
using System;
*/

/* 项目“Xtremly.Core.Wpf (net6.0-windows)”的未合并的更改
在此之前:
using Xtremly.Core;
在此之后:
using System;
*/

/* 项目“Xtremly.Core.Wpf (net5.0-windows)”的未合并的更改
在此之前:
using Xtremly.Core;
在此之后:
using System;
*/

/* 项目“Xtremly.Core.Wpf (net48)”的未合并的更改
在此之前:
using Xtremly.Core;
在此之后:
using System;
*/
using
/* 项目“Xtremly.Core.Wpf (netcoreapp3.1)”的未合并的更改
在此之前:
using System;
在此之后:
using Xtremly.Core;
*/

/* 项目“Xtremly.Core.Wpf (net7.0-windows)”的未合并的更改
在此之前:
using System;
在此之后:
using Xtremly.Core;
*/

/* 项目“Xtremly.Core.Wpf (net6.0-windows)”的未合并的更改
在此之前:
using System;
在此之后:
using Xtremly.Core;
*/

/* 项目“Xtremly.Core.Wpf (net5.0-windows)”的未合并的更改
在此之前:
using System;
在此之后:
using Xtremly.Core;
*/

/* 项目“Xtremly.Core.Wpf (net48)”的未合并的更改
在此之前:
using System;
在此之后:
using Xtremly.Core;
*/
System;
namespace Xtremly.Core
{
    public interface IContainerRegistry
    {
        IRegisteredType Register<Target>(Type type);

        IRegisteredType Register(Type interfaceType, Type ImplementationType);

        IRegisteredType Register<TInterface, TImplementation>()
            where TImplementation : TInterface;

        IRegisteredType Register<Target>(Func<Target> factory);

        void RegisterInstance<Target>(Target instace);

        IRegisteredType Register<Target>();
    }

    public interface IContainerProvider
    {
        Target Resolve<Target>();

        object Resolve(Type type);
    }
}
