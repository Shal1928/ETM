using System.Windows.Input;
using UseAbilities.MVVM.Base;
using UseAbilities.MVVM.Command;

namespace EasyTaskManager.ViewModels.MainViewModel
{
    public partial class MainViewModel : ViewModelBase
    {
        private ICommand _loadedCommand;
        public ICommand LoadedCommand
        {
            get
            {
                return _loadedCommand ?? (_loadedCommand = new RelayCommand(param => OnLoadedHandler(), null));
            }
        }

        private ICommand _showHideCommand;
        public ICommand ShowHideCommand
        {
            get
            {
                return _showHideCommand ?? (_showHideCommand = new RelayCommand(param => OnShowHideHotKeyHandler(), null));
            }
        }
    }
}
