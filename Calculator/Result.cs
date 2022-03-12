using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Calculator.Results{
    class Result{
        private string _operation;
        private double _answer;
        public string Operation{
            get => _operation;         
            set{}
        }
        public double Answer{
            get => _answer;
            set{}
        }
        public Result(string operation, double answer){
            try{
                _operation = operation;
                _answer = answer;
            }
            catch(Exception ext){
                MessageBox.Show("Error on Fetching the Operation and / or the Answer. " + 
                    ext.Message, "Error Saving Result...", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
