﻿using SDA2035_WPF_HW20.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SDA2035_WPF_HW20.ViewModels
{
    class MainWindowViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        void OnPropertyChanged([CallerMemberName] string PropertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(PropertyName));
        }

        #region Поля
        private int typeOperation = 0;
        private int numberOfButton;

        private string activeText;
        private string activeTextTemprorary;
        private string historyText;

        private double activeDouble;
        private double historyDouble;
        private double historyDoubleTemprorary;
        #endregion 

        #region Свойства
        public string ActiveText
        {
            get => activeText;
            set
            {
                activeText = value;
                OnPropertyChanged();
            }
        }
        public string ActiveTextTemprorary
        {
            get => activeTextTemprorary;
            set
            {
                activeTextTemprorary = value;
                OnPropertyChanged();
            }
        }
        public string HistoryText
        {
            get => historyText;
            set
            {
                historyText = value;
                OnPropertyChanged();
            }
        }
        public double ActiveDouble
        {
            get => activeDouble;
            set
            {
                activeDouble = value;
                OnPropertyChanged();
            }
        }
        public double HistoryDouble
        {
            get => historyDouble;
            set
            {
                historyDouble = value;
                OnPropertyChanged();
            }
        }
        public double HistoryDoubleTemprorary
        {
            get => historyDoubleTemprorary;
            set
            {
                historyDoubleTemprorary = value;
                OnPropertyChanged();
            }
        }
        #endregion

        /*  1. При нажатии на кнопки 0-9: 
            1.1 - Образуется текст (ActiveText) - это значение переносится в txtbl_Active
            1.2 - Происходит конвертация ActiveText в число ActiveDouble
            2 - При выдаче какой-либо команды значение сначала обрабатывается в HistoryDoubleTemprorary 
            3 - После нажатия любой другой кнопки действия значения ActiveText и ActiveDouble 
            попадают в значения HistoryText и HistoryDouble, HistoryText переносится в txtbl_History*/

        #region Команда 1
        public ICommand Input1Command { get; }
        private void OnInput1CommandExecute(object p)
        {
            numberOfButton = 1;
            ActiveText += numberOfButton;
            ActiveDouble = Convert.ToDouble(ActiveText);
            //метод-switchcase генерирующий временное значение HistoryDoubleTemprorary в зависимости от вида операции
            typeOperationMethod(p, typeOperation);
        }
        private bool CanInput1CommandExecuted(object p)
        {
            return true;
        }
        #endregion

        #region Команда 2
        public ICommand Input2Command { get; }
        private void OnInput2CommandExecute(object p)
        {
            numberOfButton = 2;
            ActiveText += numberOfButton;
            ActiveDouble = Convert.ToDouble(ActiveText);
            typeOperationMethod(p, typeOperation);
        }
        private bool CanInput2CommandExecuted(object p)
        {
            return true;
        }
        #endregion

        #region Команда 3
        public ICommand Input3Command { get; }
        private void OnInput3CommandExecute(object p)
        {
            numberOfButton = 3;
            ActiveText += numberOfButton;
            ActiveDouble = Convert.ToDouble(ActiveText);
            typeOperationMethod(p, typeOperation);
        }
        private bool CanInput3CommandExecuted(object p)
        {
            return true;
        }
        #endregion

        #region Команда 4
        public ICommand Input4Command { get; }
        private void OnInput4CommandExecute(object p)
        {
            numberOfButton = 4;
            ActiveText += numberOfButton;
            ActiveDouble = Convert.ToDouble(ActiveText);
            typeOperationMethod(p, typeOperation);
        }
        private bool CanInput4CommandExecuted(object p)
        {
            return true;
        }
        #endregion

        #region Команда 5
        public ICommand Input5Command { get; }
        private void OnInput5CommandExecute(object p)
        {
            numberOfButton = 5;
            ActiveText += numberOfButton;
            ActiveDouble = Convert.ToDouble(ActiveText);
            typeOperationMethod(p, typeOperation);
        }
        private bool CanInput5CommandExecuted(object p)
        {
            return true;
        }
        #endregion

        #region Команда 6
        public ICommand Input6Command { get; }
        private void OnInput6CommandExecute(object p)
        {
            numberOfButton = 6;
            ActiveText += numberOfButton;
            ActiveDouble = Convert.ToDouble(ActiveText);
            typeOperationMethod(p, typeOperation);
        }
        private bool CanInput6CommandExecuted(object p)
        {
            return true;
        }
        #endregion

        #region Команда 7
        public ICommand Input7Command { get; }
        private void OnInput7CommandExecute(object p)
        {
            numberOfButton = 7;
            ActiveText += numberOfButton;
            ActiveDouble = Convert.ToDouble(ActiveText);
            typeOperationMethod(p, typeOperation);
        }
        private bool CanInput7CommandExecuted(object p)
        {
            return true;
        }
        #endregion

        #region Команда 8
        public ICommand Input8Command { get; }
        private void OnInput8CommandExecute(object p)
        {
            numberOfButton = 8;
            ActiveText += numberOfButton;
            ActiveDouble = Convert.ToDouble(ActiveText);
            typeOperationMethod(p, typeOperation);
        }
        private bool CanInput8CommandExecuted(object p)
        {
            return true;
        }
        #endregion

        #region Команда 9
        public ICommand Input9Command { get; }
        private void OnInput9CommandExecute(object p)
        {
            numberOfButton = 9;
            ActiveText += numberOfButton;
            ActiveDouble = Convert.ToDouble(ActiveText);
            typeOperationMethod(p, typeOperation);
        }
        private bool CanInput9CommandExecuted(object p)
        {
            return true;
        }
        #endregion

        #region Команда 0
        public ICommand Input0Command { get; }
        private void OnInput0CommandExecute(object p)
        {
            numberOfButton = 0;
            ActiveText += numberOfButton;
            ActiveDouble = Convert.ToDouble(ActiveText);
            typeOperationMethod(p, typeOperation);
        }
        private bool CanInput0CommandExecuted(object p)
        {
            return true;
        }
        #endregion

        #region Команда дробной части
        public ICommand InputDoubleCommand { get; }
        private void OnInputDoubleCommandExecute(object p)
        {
            //Ввожу знак разделения целого и дробного в строку
            ActiveText += ",";
            //Создаю временную строку с нулём в конце, т.к. текст "1," вызывает ошибку при переводе в double, в отличии от "1,0"
            ActiveTextTemprorary = ActiveText + "0";
            // Попытка перевода текущего текста в double 
            try
            {
                ActiveDouble = Convert.ToDouble(ActiveText);
            }
            // А если не получилось - берём модифицированный текст
            catch
            {
                ActiveDouble = Convert.ToDouble(ActiveTextTemprorary);
            }
        }
        private bool CanInputDoubleCommandExecuted(object p)
        {
            //Здесь не даём поставить знак деления целой и дробной части если один уже есть
            if ((ActiveText != null) && (ActiveText.Contains(",")))
                return false;
            else
                return true;
        }
        #endregion

        #region Команда сложения
        public ICommand InputPlusCommand { get; }
        private void OnInputPlusCommandExecute(object p)
        {
            typeOperation = 1;
            HistoryDouble = HistoryDoubleTemprorary;
            HistoryText = HistoryDouble + " + ";
            ActiveDouble = 0;
            ActiveText = null;
        }
        private bool CanInputPlusCommandExecuted(object p)
        {
            return true;
        }
        #endregion

        #region Команда вычитания
        public ICommand InputMinusCommand { get; }
        private void OnInputMinusCommandExecute(object p)
        {
            typeOperation = 2;
            HistoryDouble = HistoryDoubleTemprorary;
            HistoryText = HistoryDouble + " - ";
            ActiveDouble = 0;
            ActiveText = null;
        }
        private bool CanInputMinusCommandExecuted(object p)
        {
            return true;
        }
        #endregion

        #region Команда умножения
        public ICommand InputMultiplyCommand { get; }
        private void OnInputMultiplyCommandExecute(object p)
        {
            typeOperation = 3;
            HistoryDouble = HistoryDoubleTemprorary;
            HistoryText = HistoryDouble + " * ";
            ActiveDouble = 0;
            ActiveText = null;
        }
        private bool CanInputMultiplyCommandExecuted(object p)
        {
            return true;
        }
        #endregion

        #region Команда деления
        public ICommand InputDivisionCommand { get; }
        private void OnInputDivisionCommandExecute(object p)
        {
            typeOperation = 4;
            HistoryDouble = HistoryDoubleTemprorary;
            HistoryText = HistoryDouble + " / ";
            ActiveDouble = 0;
            ActiveText = null;
        }
        private bool CanInputDivisionCommandExecuted(object p)
        {
            return true;
        }
        #endregion

        #region Команда равенства
        public ICommand InputResultCommand { get; }
        private void OnInputResultCommandExecute(object p)
        {
            typeOperation = 0;
            HistoryDouble = HistoryDoubleTemprorary;
            HistoryText = "= " + HistoryDouble;
            ActiveDouble = 0;
            ActiveText = null;
            HistoryDouble = 0;

        }
        private bool CanInputResultCommandExecuted(object p)
        {
            return true;
        }
        #endregion

        public MainWindowViewModel()
        {
            Input1Command = new RelayCommand(OnInput1CommandExecute, CanInput1CommandExecuted);
            Input2Command = new RelayCommand(OnInput2CommandExecute, CanInput2CommandExecuted);
            Input3Command = new RelayCommand(OnInput3CommandExecute, CanInput3CommandExecuted);
            Input4Command = new RelayCommand(OnInput4CommandExecute, CanInput4CommandExecuted);
            Input5Command = new RelayCommand(OnInput5CommandExecute, CanInput5CommandExecuted);
            Input6Command = new RelayCommand(OnInput6CommandExecute, CanInput6CommandExecuted);
            Input7Command = new RelayCommand(OnInput7CommandExecute, CanInput7CommandExecuted);
            Input8Command = new RelayCommand(OnInput8CommandExecute, CanInput8CommandExecuted);
            Input9Command = new RelayCommand(OnInput9CommandExecute, CanInput9CommandExecuted);
            Input0Command = new RelayCommand(OnInput0CommandExecute, CanInput0CommandExecuted);

            InputDoubleCommand = new RelayCommand(OnInputDoubleCommandExecute, CanInputDoubleCommandExecuted);

            InputPlusCommand = new RelayCommand(OnInputPlusCommandExecute, CanInputPlusCommandExecuted);
            InputMinusCommand = new RelayCommand(OnInputMinusCommandExecute, CanInputMinusCommandExecuted);
            InputMultiplyCommand = new RelayCommand(OnInputMultiplyCommandExecute, CanInputMultiplyCommandExecuted);
            InputDivisionCommand = new RelayCommand(OnInputDivisionCommandExecute, CanInputDivisionCommandExecuted);

            InputResultCommand = new RelayCommand(OnInputResultCommandExecute, CanInputResultCommandExecuted);

        }

        private void typeOperationMethod(object p, int typeOperation)
        {
            switch (typeOperation)
            {
                case 0:
                    //0 - стартовое значение, когда не выбрана ни одна функция. В таком виде значения Active попадают в History насколько это возможно прямо.
                    HistoryText = ActiveText;
                    HistoryDoubleTemprorary = ActiveDouble;
                    break;
                case 1:
                    //1 - функция сложения. Здесь к старому числу надо прибавлять постоянно изменяющееся текущее. 
                    HistoryDoubleTemprorary = HistoryDouble + ActiveDouble;
                    break;
                case 2:
                    //2 - функция вычитания. Логика аналогична. 
                    HistoryDoubleTemprorary = HistoryDouble - ActiveDouble;
                    break;
                case 3:
                    //3 - функция умножения. Логика аналогична. 
                    HistoryDoubleTemprorary = HistoryDouble * ActiveDouble;
                    break;
                case 4:
                    /*4 - функция деления. Команда действия выполняется до введения числа, поэтому каким-либо образом запретить я её не могу 
                     Используется обходной путь - при делении на ноль происходит деление на 1, что не вызывает ошибки */
                    if (ActiveDouble == 0)
                        HistoryDoubleTemprorary = HistoryDouble / 1;
                    else
                        HistoryDoubleTemprorary = HistoryDouble / ActiveDouble;
                    break;
            }
        }
    }
}
