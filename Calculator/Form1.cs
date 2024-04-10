using System.Web;

namespace Calculator
{
    public partial class Form1 : Form
    {

        double result = 0;
        string currentResult;
        string curropr;
        string preValue;
        bool isperformed;
        string test;
        bool flag;
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void buttonClick(object sender, EventArgs e)
        {
            if((resultTextBox.Text == "0") || (isperformed)) resultTextBox.Clear();
            isperformed = false;
            Button btn = (Button)sender;
            resultTextBox.Text += btn.Text;

            test += resultTextBox.Text + curropr;

           
        }
        private void removeButton_Click(object sender, EventArgs e)
        {
            resultTextBox.Text = resultTextBox.Text.Substring(0, resultTextBox.Text.Length - 1);
            if (resultTextBox.Text.Length == 0) { resultTextBox.Text = "0";  result = 0; }
        }
        private void clearButton_Click(object sender, EventArgs e)
        {
            resultTextBox.Text = "0";
            topLabel.Text = "";
            result = 0;
        }
        private void operation_Performed(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (curropr != null)
            {
                curropr = btn.Text;
                equalButton_Click(sender, new EventArgs());
                result = double.Parse(resultTextBox.Text);
                topLabel.Text += Math.Abs(double.Parse(resultTextBox.Text)) + " " + curropr;
                isperformed = true;
                
            }
            else
            {
                curropr = btn.Text;
                result =  double.Parse(resultTextBox.Text);
                topLabel.Text += Math.Abs(double.Parse(resultTextBox.Text)) + " " + curropr;
                isperformed = true;

            }




            //(curropr == "+") || (curropr == "-") || (curropr == "/") || (curropr == "x")

        }

        private void equalButton_Click(object sender, EventArgs e)
        {
            string txtValue = resultTextBox.Text;
            if (curropr == "+")
            {
                resultTextBox.Text = (result + double.Parse(resultTextBox.Text)).ToString();
            }
            else if (curropr == "-")
            {
                resultTextBox.Text = (result - double.Parse(resultTextBox.Text)).ToString();
            }
            else if (curropr == "/")
            {
                resultTextBox.Text = (result / double.Parse(resultTextBox.Text)).ToString();
            }
            else if (curropr == "x")
            {
                resultTextBox.Text = (result * double.Parse(resultTextBox.Text)).ToString();
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
    }
