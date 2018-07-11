﻿using System.Diagnostics;
using System.Reflection;
using System.Threading;
using EasyTaskManager.ViewModels.MainViewModel;
using System.Windows;
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
        private void App_OnStartup(object sender, StartupEventArgs e)
        {
            InitLogger();

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
    }
}
