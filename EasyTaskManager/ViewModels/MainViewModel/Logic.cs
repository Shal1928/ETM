using EasyTaskManager.TestNameSpace;
using System;
using System.Windows.Input;
using UseAbilities.MVVM.Base;
using UseAbilities.MVVM.Command;

namespace EasyTaskManager.ViewModels.MainViewModel
{
    public partial class MainViewModel : ViewModelBase
    {
        private void OnTestService()
        {
            var calc = new CalculatorClient();
            Console.WriteLine(calc.Add(1, 1));
            Console.WriteLine(calc.Add(1, 2));
        }
    }
}
