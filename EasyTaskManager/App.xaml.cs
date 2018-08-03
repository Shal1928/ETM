using System.Diagnostics;
using EasyTaskManager.ViewModels.MainViewModel;
using System.Windows;
using Microsoft.VisualBasic.Logging;
using UseAbilities.MVVM.Managers;
using UseAbilities.System.ApplicationHelper;
using UseAbilities.IoC.Helpers;
using UseAbilities.IoC.Stores;
using EasyTaskManager.Models;
using UseAbilities.IoC.Core;
using EasyTaskManager.Core;

namespace EasyTaskManager
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        private void App_OnStartup(object sender, StartupEventArgs e)
        {
            InitLogger();
            Loader(IoCManager.Container);

            SingleInstanceHelper.Make();

            AdvancedViewManager.Instance.RegisterRelation<MainViewModel, Views.MainView>();
            AdvancedViewManager.Instance.ResolveAndShow<MainViewModel>();
        }

        private void InitLogger()
        {
            Debug.Listeners.Add(
                new FileLogTraceListener
                    {
                        Location = LogFileLocation.ExecutableDirectory,
                        BaseFileName = "etm_",
                        Append = true,
                        Delimiter = "|",
                        AutoFlush = true
                });
        }

        private void Loader(IoC ioc)
        {
            ioc.RegisterSingleton<IFileStore<Solution>, SolutionStore>();
        }
    }
}
