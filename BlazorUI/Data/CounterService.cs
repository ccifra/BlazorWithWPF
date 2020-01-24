using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace BlazorUI.Data
{
    public class CounterService : INotifyPropertyChanged
    {
        private int _count;

        public CounterService()
        {
            if (DefaultService == null)
            {
                DefaultService = this;
            }
        }

        public static CounterService DefaultService { get; set; }

        public int Count
        {
            get => _count;
            set
            {
                _count = value;
                OnPropertyChanged();
            }
        }

        private void OnPropertyChanged([CallerMemberName] string name = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
