using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReportsPermissionChanger.Models;

namespace ReportsPermissionChanger.ViewModels
{
    class MultipleWindowViewModel : ViewModelBase
    {
        private MultipleWindowModel _Model;
        public DelegateCommand<object> CommandAdd { get; set; }
        public MultipleWindowViewModel()
        {
            _Model = new MultipleWindowModel();
            CommandAdd = new DelegateCommand<object>(CommandAdd_Exec, CommandAdd_CanExec);
        }


        #region DelegateMethods
        public void CommandAdd_Exec(object args)
        {
            Model.Add();
        }

        public bool CommandAdd_CanExec(object agrs)
        {
            return true;
        }
        #endregion
        public MultipleWindowModel Model
        {
            get { return _Model; }
            set
            {
                if (_Model != value)
                {
                    _Model = value;
                    RaisePropertyChanged("Model");
                }
            }
        }
    }
}
