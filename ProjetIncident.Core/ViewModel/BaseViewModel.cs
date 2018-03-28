using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ProjetIncident.Core.ViewModel
{
    public abstract class BaseViewModel : INotifyPropertyChanged
    {
        public BaseViewModel()
        {
            PropertyValues = new Dictionary<string, object>(); 
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected Dictionary<string, object> PropertyValues;

        protected T GetProperty<T>([CallerMemberName]string pPropertyName = null)
        {
            if (PropertyValues.ContainsKey(pPropertyName)){
                return (T)PropertyValues[pPropertyName]; 
            }
            return default(T); 
        }


        protected bool SetProperty<T>(T pValue, [CallerMemberName]string pPropertyName = null){
            if (!EqualityComparer<T>.Default.Equals(GetProperty<T>(pPropertyName), pValue)){
                PropertyValues[pPropertyName] = pValue; 
                OnPropertyChanged(pPropertyName);
                return true; 
            }
            return false; 
        }

        protected void OnPropertyChanged([CallerMemberName]string pPropertyName = null){
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(pPropertyName)); 
        }
    }
}