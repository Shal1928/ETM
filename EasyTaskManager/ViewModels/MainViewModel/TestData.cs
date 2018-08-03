using EasyTaskManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseAbilities.MVVM.Base;

namespace EasyTaskManager.ViewModels.MainViewModel
{
    public partial class MainViewModel : ViewModelBase
    {
        public MainViewModel()
        {
            Solution = new Solution()
            {
                Projects = new DispatchObservableCollection<Project>() {
                    new Project() { Title="Test Project 1", Path="Test Path 1" },
                    new Project() { Title="Test Project 2", Path="Test Path 2" },
                    new Project() { Title="Test Project 3", Path="Test Path 3" },
                    new Project() { Title="Test Project 4", Path="Test Path 4" },
                    new Project() { Title="Test Project 5", Path="Test Path 5" }
                },
                Title = "Test Data Solution"
            };
        }
    }
}
