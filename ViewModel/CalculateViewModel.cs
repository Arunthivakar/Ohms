using OhmsLaw.Command;
using OhmsLaw.Native;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;

namespace OhmsLaw.ViewModel
{
    internal class CalculateViewModel : INotifyPropertyChanged
    {
        private int voltage;
        public int Voltage
        {
            get { return voltage; }
            set
            {
                voltage = value;
                OnPropertyChanged();
            }
        }

        private int current;
        public int Current { 
            get { return current; } 
            set 
            { 
                current = value;
                OnPropertyChanged();
                CalculateVoltage();
            } 
        }

        private int resistance;
        public int Resistance { 
            get { return resistance; } 
            set 
            { 
                resistance = value;
                OnPropertyChanged();
                CalculateVoltage();
            } 
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(
                this,
                new PropertyChangedEventArgs(propertyName));
        }

        public CalculateViewModel()
        {

        }

        private int CalculateVoltage()
        {
            // Calling C++ DLL function
            if(current>0 && resistance>0)
                Voltage = NativeMethods.Voltage(current, resistance);
            return Voltage;
        }
        private int CalculateCurrent()
        {
            // Calling C++ DLL function
            if (voltage > 0 && resistance > 0)
                Current = NativeMethods.Current(voltage, resistance);
            return Current;
        }
        private int CalculateResistance()
        {
            // Calling C++ DLL function
            if (voltage > 0 && current > 0)
                Resistance = NativeMethods.Resistance(voltage, current);
            return Resistance;
        }
    }
}
