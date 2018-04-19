using EasyTaskManager.TestNameSpace;
using System;
using System.Windows.Input;
using UseAbilities.MVVM.Base;
using UseAbilities.MVVM.Command;

namespace EasyTaskManager.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private ICommand _testService;
        public ICommand TestService
        {
            get
            {
                return _testService ?? (_testService = new RelayCommand(param => OnTestService(), null));
            }
        }

        private void OnTestService()
        {
            var calc = new CalculatorClient();
            Console.WriteLine(calc.Add(1, 1));
            Console.WriteLine(calc.Add(1, 2));
        }
    }
}
