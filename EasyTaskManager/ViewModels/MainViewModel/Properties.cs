using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
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
    }
}
