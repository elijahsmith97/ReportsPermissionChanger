﻿
using System;
using System.ComponentModel;

namespace ReportsPermissionChanger.ViewModels
{
    public abstract class ViewModelBase: INotifyPropertyChanged, IDisposable
    {

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void RaisePropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = this.PropertyChanged;
            if (handler != null)
            {
                var e = new PropertyChangedEventArgs(propertyName);
                handler(this, e);
            }
        }

        public void Dispose()
        {
            this.Dispose();
        }

        protected virtual void OnDispose()
        {
            
        }


    }
}
