using EasyTaskManager.Models;
using UseAbilities.MVVM.Base;

namespace EasyTaskManager.ViewModels.MainViewModel
{
    public partial class MainViewModel : ViewModelBase
    {
        private static Solution SOLUTION = new Solution()
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
