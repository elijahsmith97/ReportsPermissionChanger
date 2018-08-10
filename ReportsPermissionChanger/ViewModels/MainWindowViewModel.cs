using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReportsPermissionChanger.Models;

namespace ReportsPermissionChanger.ViewModels
{
    class MainWindowViewModel: ViewModelBase
    {
        private MainWindowModel _Model;
        public DelegateCommand<object> CommandSave { get; set; }
        public DelegateCommand<object> CommandAdd { get; set; }
        public DelegateCommand<object> CommandDelete { get; set; }
        public DelegateCommand<object> CommandMultiple { get; set; }
        public MainWindowViewModel()
        {
            _Model = new MainWindowModel();
            CommandSave = new DelegateCommand<object>(CommandSave_Exec, CommandSave_CanExec);
            CommandAdd = new DelegateCommand<object>(CommandAdd_Exec, CommandAdd_CanExec);
            CommandDelete = new DelegateCommand<object>(CommandDelete_Exec, CommandDelete_CanExec);
            CommandMultiple = new DelegateCommand<object>(CommandMultiple_Exec, CommandMultiple_CanExec);
        }


        #region DelegateMethods
        private void CommandSave_Exec(object args)
        {
            Model.Save();
        }
        private bool CommandSave_CanExec(object ags)
        {
            return true;
        }
        private void CommandAdd_Exec(object args)
        {
            Model.AddUser();
        }
        private bool CommandAdd_CanExec(object ags)
        {
            return true;
        }
        private void CommandDelete_Exec(object args)
        {
            Model.DeleteUser();
        }
        private bool CommandDelete_CanExec(object ags)
        {
            return true;
        }
        private void CommandMultiple_Exec(object args)
        {
            Model.AddMultiple();
        }
        private bool CommandMultiple_CanExec(object ags)
        {
            return true;
        }



        #endregion

        #region Properties
        public MainWindowModel Model
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
        #endregion
    }
}
