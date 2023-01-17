using CalculatorLibrary;
using System.Windows.Forms;

namespace Calculator
{
    public partial class CalculatorForm : Form, IView
    {
        public CalculatorForm()
        {
            InitializeComponent();
            IModel model = new RNPModel();
            Presenter presenter = new Presenter(this, model);
            calculateButton.Click += (s, e) => presenter.Result();
            SetButtons();
        }

        private void SetButtons()
        {
            zeroButton.Click += (s, e) => inputTextBox.Text += "0";
            oneButton.Click += (s, e) => inputTextBox.Text += "1";
            twoButton.Click += (s, e) => inputTextBox.Text += "2";
            threeButton.Click += (s, e) => inputTextBox.Text += "3";
            fourButton.Click += (s, e) => inputTextBox.Text += "4";
            fiveButton.Click += (s, e) => inputTextBox.Text += "5";
            sixButton.Click += (s, e) => inputTextBox.Text += "6";
            sevenButton.Click += (s, e) => inputTextBox.Text += "7";
            eightButton.Click += (s, e) => inputTextBox.Text += "8";
            nineButton.Click += (s, e) => inputTextBox.Text += "9";
            sumButton.Click += (s, e) => inputTextBox.Text += "+";
            diffButton.Click += (s, e) => inputTextBox.Text += "-";
            divideButton.Click += (s, e) => inputTextBox.Text += "/";
            multiplyButton.Click += (s, e) => inputTextBox.Text += "*";
            dotButton.Click += (s, e) => inputTextBox.Text += ",";
            openBracketButton.Click += (s, e) => inputTextBox.Text += "(";
            closeBracketButton.Click += (s, e) => inputTextBox.Text += ")";
            clearButton.Click += (s, e) =>
            {
                inputTextBox.Text = string.Empty;
                outputTextBox.Text = string.Empty;
            };
        }

        public string Value { get => inputTextBox.Text; }

        public string Result { set => outputTextBox.Text = value; }

    }
}
