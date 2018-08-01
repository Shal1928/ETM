using EasyTaskManager.TestNameSpace;
using System;
using System.Windows;
using System.Windows.Input;
using UseAbilities.MVVM.Base;
using UseAbilities.MVVM.Command;
using UseAbilities.System.ApplicationHelper;
using UseAbilities.System.Core.Enums;

namespace EasyTaskManager.ViewModels.MainViewModel
{
    /// <summary>
    /// Бизнес логика
    /// </summary>
    public partial class MainViewModel : ViewModelBase
    {
        private HotKeyHelper _showHideHotKey;

        private void OnShowHideHotKeyHandler()
        {
            IsVisible = !IsVisible;
        }

        private void OnLoadedHandler()
        {
            _showHideHotKey = new HotKeyHelper(Key.Escape, KeyModifier.None, OnShowHideHotKeyHandler);
        }
    }
}
