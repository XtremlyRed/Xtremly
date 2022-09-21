using System;
using System.Collections.Generic;
using System.Windows;

namespace Xtremly.Core
{
    public static class WpfContainerExtensions
    {
        public static void RegisterForNavigation<TView, TViewModel>(this IContainerRegistry registry, string navigationName = null)
            where TView : UIElement
            where TViewModel : class
        {
            if (registry is not ContainerRegistry container)
            {
                return;
            }
            ____containerForNavigation dict = container.Container.Resolve<____containerForNavigation>();

            Type viewType = typeof(TView);
            Type viewModelType = typeof(TViewModel);

            string name = string.IsNullOrWhiteSpace(navigationName) ? viewType.Name : navigationName;

            if (dict.TryGetValue(name, out ____View_ViewModel_Mapper mapper) == false)
            {
                dict[name] = mapper = new ____View_ViewModel_Mapper();
            }

            if (container.Container.IsRegistered(viewType) == false)
            {
                container.Register<TView>().AsSingleton();
            }
            if (container.Container.IsRegistered(viewModelType) == false)
            {
                container.Register<TViewModel>().AsSingleton();
            }
            mapper.ViewType = viewType;
            mapper.ViewModelType = viewModelType;
        }

        public static void RegisterForNavigation<TView>(this IContainerRegistry registry, string navigationName = null)
              where TView : UIElement
        {

            if (registry is not ContainerRegistry container)
            {
                return;
            }

            ____containerForNavigation dict = container.Container.Resolve<____containerForNavigation>();

            Type viewType = typeof(TView);
            string name = string.IsNullOrWhiteSpace(navigationName) ? viewType.Name : navigationName;

            if (dict.TryGetValue(name, out ____View_ViewModel_Mapper mapper) == false)
            {
                dict[name] = mapper = new ____View_ViewModel_Mapper();
            }

            if (container.Container.IsRegistered(viewType) == false)
            {
                container.Register<TView>().AsSingleton();
            }

            mapper.ViewType = viewType;
        }

        internal static void NavigationExtensionsRegister(this IContainerRegistry container)
        {
            ____containerForNavigation target = new();
            container.RegisterInstance(target);
        }

        internal static ____View_ViewModel_Mapper FindMapper(string targetHostName)
        {
            ____containerForNavigation mapper = XtremlyApplication.Provider.Resolve<____containerForNavigation>();

            return mapper.TryGetValue(targetHostName, out ____View_ViewModel_Mapper mapperType) ? mapperType : null;
        }

        private class ____containerForNavigation
            : Dictionary<string, ____View_ViewModel_Mapper>
        {

        }


        internal class ____View_ViewModel_Mapper
        {
            public Type ViewType { get; set; }
            public Type ViewModelType { get; set; }
        }
    }
}
