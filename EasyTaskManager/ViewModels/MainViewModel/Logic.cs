﻿using System.Windows.Input;
using UseAbilities.MVVM.Base;
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
            SolutionStore.Save(SOLUTION);
            _showHideHotKey = new HotKeyHelper(Key.Escape, KeyModifier.None, OnShowHideHotKeyHandler);
        }
    }
}
