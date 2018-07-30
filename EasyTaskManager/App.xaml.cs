using System.Diagnostics;
using System.Drawing;
using System.Net.Mime;
using System.Reflection;
using System.Threading;
using EasyTaskManager.ViewModels.MainViewModel;
using System.Windows;
using System.Windows.Forms;
using Microsoft.VisualBasic.Logging;
using UseAbilities.MVVM.Managers;
using UseAbilities.System.ApplicationHelper;

namespace EasyTaskManager
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        private NotifyIcon _notifyIcon;

        private void App_OnStartup(object sender, StartupEventArgs e)
        {
            InitLogger();

            SingleInstanceHelper.Make();

            //_notifyIcon = new NotifyIcon();
            //var iconHandle = EasyTaskManager.Properties.Resources.Sun.Handle;
            //_notifyIcon.Icon = Icon.FromHandle(iconHandle);
            //_notifyIcon.Visible = true;

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
