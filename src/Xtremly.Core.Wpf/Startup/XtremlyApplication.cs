
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;

namespace Xtremly.Core
{
    /// <summary>
    /// XtremlyApplication
    /// </summary>
    public abstract class XtremlyApplication : System.Windows.Application
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never), EditorBrowsable(EditorBrowsableState.Never)]
        private Window window;

        public static new XtremlyApplication Current { get; private set; }
        public static new System.Windows.Threading.Dispatcher Dispatcher { get; private set; }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static IContainerRegistry Registry { get; private set; }
        public static IContainerProvider Provider { get; private set; }



        /// <summary>
        /// StartupUri
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never), EditorBrowsable(EditorBrowsableState.Never)]
        public new Uri StartupUri { get; set; }

        /// <summary>
        /// MainWindow
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never), EditorBrowsable(EditorBrowsableState.Never)]
        public new Window MainWindow => window;

        static XtremlyApplication()
        {
            ContainerRegistry registry = new();
            Provider = new ContainerProvider(registry);
            Registry = registry;

            registry.NavigationExtensionsRegister();

            registry.Register<INavigateManager, NavigateManager>().AsSingleton();
            registry.Register<IPopupManager, PopupManager>().AsSingleton();
            registry.Register<IMessenger, Messenger>().AsSingleton();
        }


        /// <summary>
        /// HiApplicationBase
        /// </summary>
        protected XtremlyApplication()
        {
            Current = this;
            Dispatcher = base.Dispatcher;
            IocContainerRegistry(Registry);
        }

        /// <summary>
        /// OnStartup
        /// </summary>
        /// <param name="e"></param>
        protected sealed override void OnStartup(StartupEventArgs e)
        {
            Xtremly.Core.Initialize.Init(this);
            base.OnStartup(e);
            Initialize();
        }

        /// <summary>
        /// Initialize
        /// </summary>
        protected virtual void Initialize()
        {
            window = CreateMainWindow(Provider);
            OnInitialized();
        }

        /// <summary>
        /// IocContainerRegistry
        /// </summary>
        /// <param name="registry"></param>
        protected abstract void IocContainerRegistry(IContainerRegistry registry);

        /// <summary>
        /// CreateMainWindow
        /// </summary>
        /// <returns></returns>
        protected abstract System.Windows.Window CreateMainWindow(IContainerProvider provider);

        /// <summary> 
        /// </summary>
        protected virtual void OnInitialized()
        {
            if (window is null)
            {
                Environment.Exit(0);
                return;
            }
            window.Show();
        }
    }
}
