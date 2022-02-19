﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SDA2035_WPF_HW20.Models
{
    public class RelayCommand : ICommand
    {
        private readonly Action<object> fExecute;
        private readonly Func<object, bool> fCanExecute;

        public event EventHandler CanExecuteChanged
        {
            add => CommandManager.RequerySuggested += value;
            remove => CommandManager.RequerySuggested -= value;
        }

        public RelayCommand(Action<object> dExecute, Func<object, bool> dCanExecute)
        {
            fExecute = dExecute;
            fCanExecute = dCanExecute;

        }
        public bool CanExecute(object parameter) => fCanExecute(parameter);

        public void Execute(object parameter) => fExecute(parameter);

    }
}
