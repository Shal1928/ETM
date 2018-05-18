using System.Diagnostics;
using System.Reflection;
using System.Threading;
using EasyTaskManager.ViewModels.MainViewModel;
using System.Windows;
using Microsoft.VisualBasic.Logging;
using UseAbilities.MVVM.Managers;

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

            // Use the assembly GUID as the name of the mutex which we use to detect if an application instance is already running
            bool isApplicationRunning;
            var mutex = new Mutex(false, Assembly.GetExecutingAssembly().GetType().GUID.ToString(), out isApplicationRunning);
            Debug.WriteLine("isApplicationRunning = {0}", isApplicationRunning);
            if (!isApplicationRunning)
            {
                Debug.WriteLine(" Current.Shutdown()");
                // Only allow one instance
                Current.Shutdown();
            }

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
    }
}
