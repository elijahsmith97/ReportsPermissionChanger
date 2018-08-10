using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using ReportsPermissionChanger.DataAccess;
using ReportsPermissionChanger.ViewModels;

namespace ReportsPermissionChanger.Models
{
    class MainWindowModel : ViewModelBase
    {
        private AESEntities db;
        private ObservableCollection<RULE> _UserList;
        private ObservableCollection<string> _AccessList;
        private ObservableCollection<tblReportsIndex> _ReportList;
        private tblReportsIndex _SelectedReport;
        private RULE _SelectedUser;
        private string _SelectedAccess;

        public MainWindowModel()
        {
            db = new AESEntities();
            _UserList = new ObservableCollection<RULE>();
            _AccessList = new ObservableCollection<string>();
            _ReportList = new ObservableCollection<tblReportsIndex>();
            BuildUserList();
            BuildReportList();
        }


        private void BuildReportList()
        {
            var reportList = (from report in db.tblReportsIndexes
                select report).ToList();
            foreach (var reportAccess in reportList)
                _ReportList.Add(reportAccess);
        }

        #region Properties

        public tblReportsIndex SelectedReport
        {
            get { return _SelectedReport; }
            set
            {
                if (_SelectedReport != value)
                {
                    _SelectedReport = value;
                    RaisePropertyChanged("UserList");
                    updateDistributionList();
                }
            }
        }

        private void updateDistributionList()
        {
            //this method will display the distribution list of the selected employees.
            string[] userNameArray = SelectedReport.Distribution.Split(';');
            _AccessList.Clear();
            foreach (var email in userNameArray)
                _AccessList.Add(email.Trim());

        }

        public void Save()
        {
            StringBuilder distributionList = new StringBuilder();

            for (int i = 0; i < AccessList.Count; i++)
            {
                distributionList.Append(AccessList[i]);
                if (i != AccessList.Count - 1 && AccessList.Count > 1)
                {
                        distributionList.Append("; ");
                }  
            }
            SelectedReport.Distribution = distributionList.ToString();
            db.SaveChanges();
        }

        public void AddUser()
        {
            if (SelectedUser != null && SelectedReport != null)
            {
                string emailAddress = string.Empty;
                string[] fullName = SelectedUser.STATUS.Split(' ');
                if (fullName.Length == 2)
                {
                    emailAddress = (fullName[0].ToCharArray()[0].ToString() + fullName[1] + "@aesintl.com").ToLower();
                    if (!(_AccessList.Contains(emailAddress)))
                    {
                        _AccessList.Add(emailAddress);
                    }
                }
            }
        }

        public void DeleteUser()
        {
            if (SelectedReport != null)
            {
                string emailAddress = SelectedAccess;
                _AccessList.Remove(emailAddress);
            }
        }

        public void AddMultiple()
        {
            MultipleWindow multWindow = new MultipleWindow();
            multWindow.Show();
        }

        public ObservableCollection<RULE> UserList
        {
            get { return _UserList; }
            set
            {
                if (_UserList != value)
                {
                    _UserList = value;
                    RaisePropertyChanged("UserList");
                }
            }
        }
        public ObservableCollection<string> AccessList
        {
            get { return _AccessList; }
            set
            {
                if (_AccessList != value)
                {
                    _AccessList = value;
                    RaisePropertyChanged("AccessList");
                }
            }
        }


        public ObservableCollection<tblReportsIndex> ReportsList
        {
            get { return _ReportList; }
            set
            {
                if (_ReportList != value)
                {
                    _ReportList = value;
                    RaisePropertyChanged("AccessList");
                }
            }
        }

        public RULE SelectedUser
        {
            get { return _SelectedUser; }
            set
            {
                if (_SelectedUser != value)
                {
                    _SelectedUser = value;
                    RaisePropertyChanged("SelectedUser");
                }
            }
        }

        public string SelectedAccess
        {
            get { return _SelectedAccess;  }
            set
            {
                if (_SelectedAccess != value)
                {
                    _SelectedAccess = value;
                    RaisePropertyChanged("SelectedAccess");
                }
            }
        }
        #endregion

        public void BuildUserList()
        {
            
            var userList = (from users in db.RULES
                            where users.Active == "Y"
                            orderby users.STATUS
                            select users).ToList();

           UserList.Clear();
            foreach (var userName in userList)
            {
                _UserList.Add(userName);
            }
        }
    }
}
