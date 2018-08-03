using EasyTaskManager.Models;
using UseAbilities.IoC.Attributes;
using UseAbilities.IoC.Stores;
using UseAbilities.MVVM.Base;

namespace EasyTaskManager.ViewModels.MainViewModel
{
    public partial class MainViewModel : ViewModelBase
    {
        private bool _isVisible = true;

        public virtual bool IsVisible
        {
            get
            {
                return _isVisible;
            }
            set
            {
                _isVisible = value;
            }
        }

        [InjectedProperty]
        public IFileStore<Solution> SolutionStore
        {
            get;
            set;
        }

        private Solution _solution;

        public virtual Solution Solution
        {
            get
            {
                return _solution ?? (_solution = SolutionStore.Load());
            }
        }
    }
}
