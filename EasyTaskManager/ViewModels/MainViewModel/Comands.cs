using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using UseAbilities.MVVM.Base;
using UseAbilities.MVVM.Command;

namespace EasyTaskManager.ViewModels.MainViewModel
{
    public partial class MainViewModel : ViewModelBase
    {
        private ICommand _testService;
        public ICommand TestService
        {
            get
            {
                return _testService ?? (_testService = new RelayCommand(param => OnTestService(), null));
            }
        }
    }
}
