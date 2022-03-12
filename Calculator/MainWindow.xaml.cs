using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Calculator.Functions_For_Operations;
using Calculator.Results;


namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow(){
            InitializeComponent();
        }

        // Collection of Results For All Calculations to get a history later.   
        private ObservableCollection<Result> List_Of_Results = new ObservableCollection<Result>();                    

        // Value of the First Number, i.e Before the Value of the "Value- Textbox" changes.
        private double _firstNumber = 0.0;

        // Vaulue when it has changed...
        private double _secondNumber = 0.0;

        // Operator
        private string function;

        private void button45_Click(object sender, RoutedEventArgs e){

            if (value.Text == "0"){
                value.Clear();
            }
            if (temp_result.Text.Length == 0){
                value.AppendText(0.ToString());
            }
            else{
                temp_result.Clear();
                value.Text = 0.ToString();
            }
        }
        private void button40_Click(object sender, RoutedEventArgs e){           

            if(value.Text == "0"){
                value.Clear();            
            }
            if (temp_result.Text.Length == 0){
                value.AppendText(1.ToString());
            }
            else{
                temp_result.Clear();
                value.Text = 1.ToString();
            }
        }
        private void button41_Click(object sender, RoutedEventArgs e){

            if (value.Text == "0"){
                value.Clear();               
            }
            if (temp_result.Text.Length == 0){
                value.AppendText(2.ToString());
            }
            else{
                temp_result.Clear();
                value.Text = 2.ToString();
            }
        }
        private void button42_Click(object sender, RoutedEventArgs e){

            if (value.Text == "0"){
                value.Clear();               
            }
            if (temp_result.Text.Length == 0){
                value.AppendText(3.ToString());
            }
            else{
                temp_result.Clear();
                value.Text = 3.ToString();
            }
        }
        private void button36_Click(object sender, RoutedEventArgs e){

            if (value.Text == "0"){
                value.Clear();               
            }
            if (temp_result.Text.Length == 0){
                value.AppendText(4.ToString());
            }
            else{
                temp_result.Clear();
                value.Text = 4.ToString();
            }
        }
        private void button37_Click(object sender, RoutedEventArgs e){

            if(value.Text == "0"){
                value.Clear();               
            }
            if(temp_result.Text.Length == 0){
                value.AppendText(5.ToString());
            }
            else{
                temp_result.Clear();
                value.Text = 5.ToString();
            }
        }
        private void button38_Click(object sender, RoutedEventArgs e){

            if(value.Text == "0"){
                value.Clear();               
            }
            if(temp_result.Text.Length == 0){
                value.AppendText(6.ToString());
            }
            else{
                temp_result.Clear();
                value.Text = 6.ToString();
            }
        }
        private void button20_Click(object sender, RoutedEventArgs e){

            if(value.Text == "0"){
                value.Clear();               
            }
            if(temp_result.Text.Length == 0){
                value.AppendText(7.ToString());
            }
            else{
                temp_result.Clear();
                value.Text = 7.ToString();
            }
        }
        private void button21_Click(object sender, RoutedEventArgs e){

            if(value.Text == "0"){
                value.Clear();               
            }
            if(temp_result.Text.Length == 0){
                value.AppendText(8.ToString());
            }
            else{
                temp_result.Clear();
                value.Text = 8.ToString();
            }
        }
        private void button22_Click(object sender, RoutedEventArgs e){

            if (value.Text == "0"){
                value.Clear();               
            }
            if (temp_result.Text.Length == 0){
                value.AppendText(9.ToString());
            }
            else{
                temp_result.Clear();
                value.Text = 9.ToString();
            }
        }
        private void button15_Click(object sender, RoutedEventArgs e){

            if (value.Text.Count() > 1){
                
                List<char> deleted_value = new List<char>();
                StringBuilder st = new StringBuilder();
                deleted_value = value.Text.Take(value.Text.Count() - 1).ToList();
                for(int i = 0; i < deleted_value.Count(); i++){
                    st.Append(deleted_value[i]);
                }
                value.Text = st.ToString();                
            }
            else if (value.Text.Count() == 1){
                value.Text = 0.ToString();
            }            
        }
        private void button13_Click(object sender, RoutedEventArgs e){

            temp_result.Clear();
            value.Clear();
            value.Text = 0.ToString();
        }
        private void button14_Click(object sender, RoutedEventArgs e){

            temp_result.Clear();
            value.Clear();
            value.Text = 0.ToString();
        }
        private void button12_Click(object sender, RoutedEventArgs e){

            try{
                temp_result.Text = value.Text + " ÷ " + "100";
                value.Text = (double.Parse(value.Text) / 100).ToString();
            }
            catch (Exception ex){
                value.Text = ex.Message;
            }            
        }
        private void button46_Click(object sender, RoutedEventArgs e){

            value.AppendText(".");
        }
        private void button43_Click(object sender, RoutedEventArgs e){

            function = "+";
            _firstNumber = double.Parse(value.Text);
            temp_result.Text = value.Text + " + ";      
        }
        private void button47_Click(object sender, RoutedEventArgs e){

            try{
                Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;
                _secondNumber = double.Parse(value.Text.Replace(",", "."));

                Operator opt = new Operator(_firstNumber, _secondNumber);
                if (function == "+"){
                    temp_result.Text = opt.Addition().Operation + " = ";
                    value.Text = opt.Addition().Answer.ToString();
                    List_Of_Results.Add(opt.Addition());
                }
                if (function == "-"){
                    temp_result.Text = opt.Substraction().Operation + " = ";
                    value.Text = opt.Substraction().Answer.ToString();
                    List_Of_Results.Add(opt.Substraction());
                }
                if (function == "x"){
                    temp_result.Text = opt.Multiplication().Operation + " = ";
                    value.Text = opt.Multiplication().Answer.ToString();
                    List_Of_Results.Add(opt.Multiplication());
                }
                if (function == "÷"){
                    temp_result.Text = opt.Division().Operation + " = ";
                    value.Text = opt.Division().Answer.ToString();
                    List_Of_Results.Add(opt.Division());
                }
                _firstNumber = 0.0;
                _secondNumber = 0.0;
            }
            catch (Exception ex){
                value.Text = ex.Message;
            }
        }
        private void button39_Click(object sender, RoutedEventArgs e){

            function = "-";
            _firstNumber = double.Parse(value.Text);
            temp_result.Text = value.Text + " - ";
        }
        private void button23_Click(object sender, RoutedEventArgs e){

            function = "x";
            _firstNumber = double.Parse(value.Text);
            temp_result.Text = value.Text + " x ";
        }
        private void button19_Click(object sender, RoutedEventArgs e){

            function = "÷";
            _firstNumber = double.Parse(value.Text);
            temp_result.Text = value.Text + " ÷ ";
        }
        private void Image_MouseDown(object sender, MouseButtonEventArgs e){

            StringBuilder sb = new StringBuilder();
            foreach(Result r in List_Of_Results){
               sb.Append(r.Operation.ToString() + "\n" + r.Answer.ToString() + "\n\n");
            }
            MessageBox.Show(sb.ToString());
        }
        private void button16_Click(object sender, RoutedEventArgs e){

            if(value.Text == 0.ToString()){
                value.Text = "Dividing by Zero is not possible";
                return;
            }
            else{

                temp_result.Text = "1/(" + value.Text +")";
                value.Text = ( 1 / (double.Parse(value.Text))).ToString();
            } 
            List_Of_Results.Add(new Result(temp_result.Text, double.Parse(value.Text)));
        }
        private void button17_Click(object sender, RoutedEventArgs e){

            temp_result.Text = "sqr(" + value.Text + ")"; 
            value.Text = (Math.Pow(double.Parse(value.Text), 2.0)).ToString();
            List_Of_Results.Add(new Result(temp_result.Text, double.Parse(value.Text)));
        }
        private void button18_Click(object sender, RoutedEventArgs e){

            temp_result.Text = "√(" + value.Text + ")";
            value.Text = (Math.Sqrt(double.Parse(value.Text))).ToString();
            List_Of_Results.Add(new Result(temp_result.Text, double.Parse(value.Text)));
        }
        private void button44_Click(object sender, RoutedEventArgs e){

            if (value.Text == "0"){
                value.Clear();
            }
            if (value.Text == "-"){
                return;
            }
            if (temp_result.Text.Length == 0){
                value.AppendText("-");
            }
            else if (temp_result.Text.Length != 0) {
                temp_result.Clear();
                long tempval = 0;
                tempval = -1 * Convert.ToInt64(value.Text);
                value.Text = tempval.ToString();
            }
        }
    }
}