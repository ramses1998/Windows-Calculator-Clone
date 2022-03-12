using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Calculator.Results;

namespace Calculator.Functions_For_Operations{
    class Operator{
        
        private double _first_Number;
        private double _second_Number;
        private Result _result;

        // Private with no corresponding Property ,
        // because other classes won't use 
        // id = 1   -> Division
        // id = 2   -> Multiplication
        // id = 3   -> Substraction
        // id = 4   -> Addition
        private int _id_For_Operator;
        public double First_Number{
            get => _first_Number;
            set { }
        }
        public double Second_Number{
            get => _second_Number;
            set{}
        }
        public Result Result{
            get => _result;
            set{}
        }
        /// <summary>
        /// Primary constructor
        /// </summary>
        /// <param name="first_Number"></param>
        /// <param name="second_Number"></param>
        public Operator(double first_Number, double second_Number){
            try{
                _first_Number = first_Number;
                _second_Number = second_Number;                
            }
            catch(Exception ext){
                MessageBox.Show("Error on Fetching the First and / or second digit for your Operation. " + 
                    ext.Message, "Error on Calculating...", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        /// <summary>
        /// Function for the Addtion Operation
        /// </summary>
        /// <returns></returns>
        public Result Addition(){
            double anz;
            string opr;
            anz = _first_Number + _second_Number;
            opr = $"{_first_Number.ToString()} + {_second_Number.ToString()}";
            return new Result(opr, anz);
        }
        /// <summary>
        ///  Function for the Substraction Operation
        /// </summary>
        /// <returns></returns>
        public Result Substraction(){
            double anz;
            string opr;
            anz = _first_Number - _second_Number;
            opr = $"{_first_Number.ToString()} - {_second_Number.ToString()}";
            return new Result(opr, anz);
        }
        /// <summary>
        /// Function for the Multiplication Operation
        /// </summary>
        /// <returns></returns>
        public Result Multiplication(){
            double anz;
            string opr;
            anz = _first_Number * _second_Number;
            opr = $"{_first_Number.ToString()} x {_second_Number.ToString()}";
            return new Result(opr, anz);
        }
        /// <summary>
        /// Function for the Division Operation
        /// </summary>
        /// <returns></returns>
        public Result Division(){
            double anz;
            string opr;
            anz = _first_Number / _second_Number;
            opr = $"{_first_Number.ToString()} ÷ {_second_Number.ToString()}";
            return new Result(opr, anz);
        }
    }
}
