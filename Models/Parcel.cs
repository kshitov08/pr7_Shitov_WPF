using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace pr7_Shitov_WPF.Models
{
    public class Parcel : INotifyPropertyChanged
    {
        private string _recipient;
        public string Recipient
        {
            get => _recipient;
            set
            {
                if (_recipient != value)
                {
                    _recipient = value;
                    OnPropertyChanged();
                }
            }
        }
        private float _weight;
        public float Weight
        {
            get => _weight;
            set
            {
                if (_weight != value)
                {
                    _weight = value;
                    OnPropertyChanged();
                    OnPropertyChanged(nameof(DeliveryCost));
                }
            }
        }
        private float _ratePerKg;
        public float RatePerKg
        {
            get => _ratePerKg;
            set
            {
                if (_ratePerKg != value)
                {
                    _ratePerKg = value;
                    OnPropertyChanged();
                    OnPropertyChanged(nameof(DeliveryCost));
                }
            }
        }
        private float _surcharge;
        public float Surcharge
        {
            get => _surcharge;
            set
            {
                if (_surcharge != value)
                {
                    _surcharge = value;
                    OnPropertyChanged();
                    OnPropertyChanged(nameof(DeliveryCost));
                }
            }
        }
        private float _deliveryCost => Weight * RatePerKg + Surcharge;

        public float DeliveryCost
        {
            get => _deliveryCost;
            set
            {
                if (_deliveryCost != value)
                {
                    OnPropertyChanged();
                    OnPropertyChanged(nameof(DeliveryCost));
                }
            }
        }


        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string? name = null)
        => PropertyChanged?.Invoke(this, new
        PropertyChangedEventArgs(name));
    }
}
