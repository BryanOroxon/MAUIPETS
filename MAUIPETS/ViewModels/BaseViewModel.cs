using System;
using MAUIPETS.Services;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using MvvmHelpers;

namespace MAUIPETS.ViewModels
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        public IDataService DataService { get; }
        public BaseViewModel()
        {
            DataService = DependencyService.Get<IDataService>();
        }

        bool isBusy;

        string title;
        public string Title
        {
            get => title;
            set
            {
                if (title == value)
                    return;
                title = value;
                OnPropertyChanged();
            }
        }
        public bool IsBusy
        {
            get => isBusy;
            set
            {
                if (isBusy == value)
                    return;

                isBusy = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(IsNotBusy));
            }
        }

        public bool IsNotBusy => !IsBusy;

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string name = null) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}
