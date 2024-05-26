using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    
    public partial class Calculator : Form
    {

        double enterFirstValue, enterSecondValue;
        IOperation currentOperation;
        List<string> history = new List<string>();

        public Calculator()
        {
            InitializeComponent();
            this.MaximizeBox = false;
        }

        private void EnterNumbers(object sender, EventArgs e)
        {
            Button num = (Button)sender;

            if (txtResult.Text == "0")
                txtResult.Text = "";
            {
                if (num.Text == ".")
                {
                    if (!txtResult.Text.Contains("."))
                        txtResult.Text += num.Text;
                }
                else
                {
                    txtResult.Text += num.Text;
                }
            }
        }

        private void numberOper(object sender, EventArgs e)
        {
            Button num = (Button)sender;

            if (double.TryParse(txtResult.Text, out double result))
            {
                enterFirstValue = result;
                switch (num.Text)
                {
                    case "+":
                        currentOperation = new AdditionOperation();
                        break;
                    case "-":
                        currentOperation = new SubtractionOperation();
                        break;
                    case "*":
                        currentOperation = new MultiplicationOperation();
                        break;
                    case "/":
                        currentOperation = new DivisionOperation();
                        break;
                    case "exp":
                        currentOperation = new ExponentiationOperation();
                        break;
                    case "mod":
                        currentOperation = new ModulusOperation();
                        break;
                    default:
                        currentOperation = null;
                        break;
                }
                txtResult.Text = "";
            }
        }

        private void BtnEquals_Click(object sender, EventArgs e)
        {
            if (txtResult.Text != "")
                enterSecondValue = Convert.ToDouble(txtResult.Text);

            if (currentOperation != null)
            {
                double result = currentOperation.Execute(enterFirstValue, enterSecondValue);
                txtResult.Text = result.ToString();

                string historyEntry = $"{enterFirstValue} {currentOperation.OperatorSymbol} {enterSecondValue} = {txtResult.Text}";
                history.Add(historyEntry);
                UpdateHistoryTextBox();
            }
        }

        private void UpdateHistoryTextBox()
        {
            txtHistory.Text = string.Join(Environment.NewLine, history);
            txtHistory.SelectionStart = txtHistory.Text.Length;
            txtHistory.ScrollToCaret();

            btnClearHistory.Visible = history.Count > 0;
        }
        private void ClearHistory()
        {
            history.Clear();
            UpdateHistoryTextBox();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";
        }

        private void BtnClearEntry_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";
            enterFirstValue = 0;
            enterSecondValue = 0;
        }

        private void BtnPM_Click(object sender, EventArgs e)
        {
            double q = Convert.ToDouble(txtResult.Text);
            txtResult.Text = Convert.ToString(-1 * q);
        }

        private void BtnBS_Click(object sender, EventArgs e)
        {
            if (txtResult.Text.Length > 0)
            {
                txtResult.Text = txtResult.Text.Remove(txtResult.Text.Length - 1, 1);
            }

            if (txtResult.Text == "")
            {
                txtResult.Text = "0";
            }
        }

        
        private void standartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 606;
        }

        private void scientificToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 896; 
        }

        private void BtnPi_Click(object sender, EventArgs e)
        {
            txtResult.Text = "3.14159";
        }

        private void BtnLog_Click(object sender, EventArgs e)
        {
            double log = Convert.ToDouble(txtResult.Text);
            log = Math.Log10(log);
            txtResult.Text = Convert.ToString(log);
        }

        private void BtnSqrt_Click(object sender, EventArgs e)
        {
            double sqrt = Convert.ToDouble(txtResult.Text);
            sqrt = Math.Sqrt(sqrt);
            txtResult.Text = Convert.ToString(sqrt);
        }

        private void Btnx2_Click(object sender, EventArgs e)
        {
            double x;

            x = Convert.ToDouble(txtResult.Text) * Convert.ToDouble(txtResult.Text);
            txtResult.Text = Convert.ToString(x);

        }

        private void Btnx3_Click(object sender, EventArgs e)
        {
            double x;

            x = Convert.ToDouble(txtResult.Text) * Convert.ToDouble(txtResult.Text) * Convert.ToDouble(txtResult.Text);
            txtResult.Text = Convert.ToString(x);
        }

        private void BtnSinh_Click(object sender, EventArgs e)
        {
            double sinh = Convert.ToDouble(txtResult.Text);
            sinh = Math.Sinh(sinh);
            txtResult.Text = Convert.ToString(sinh);
        }

        private void BtnSin_Click(object sender, EventArgs e)
        {
            double sin = Convert.ToDouble(txtResult.Text);
            sin = Math.Sin(sin);
            txtResult.Text = Convert.ToString(sin);
        }

        private void BtnDec_Click(object sender, EventArgs e)
        {
            double dec = Convert.ToDouble(txtResult.Text);
            int idec = (int)dec;
            txtResult.Text = Convert.ToString(idec);
        }

        private void BtnCosh_Click(object sender, EventArgs e)
        {
            double cosh = Convert.ToDouble(txtResult.Text);
            cosh = Math.Cosh(cosh);
            txtResult.Text = Convert.ToString(cosh);
        }

        private void BtnCos_Click(object sender, EventArgs e)
        {
            double cos = Convert.ToDouble(txtResult.Text);
            cos = Math.Cos(cos);
            txtResult.Text = Convert.ToString(cos);
        }

        private void BtnBin_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtResult.Text);
            txtResult.Text = Convert.ToString(a, 2);
        }

        private void BtnTanh_Click(object sender, EventArgs e)
        {
            double tanh = Convert.ToDouble(txtResult.Text);
            tanh = Math.Tanh(tanh);
            txtResult.Text = Convert.ToString(tanh);
        }

        private void BtnTan_Click(object sender, EventArgs e)
        {
            double tan = Convert.ToDouble(txtResult.Text);
            tan = Math.Tan(tan);
            txtResult.Text = Convert.ToString(tan);
        }

        private void Btn1x_Click(object sender, EventArgs e)
        {
            double a;

            a = Convert.ToDouble(1.0 / Convert.ToDouble(txtResult.Text));

            txtResult.Text = Convert.ToString(a);
        }

        private void Btnlnx_Click(object sender, EventArgs e)
        {
            double lnx = Convert.ToDouble(txtResult.Text);
            lnx = Math.Log(lnx);
            txtResult.Text = Convert.ToString(lnx);
        }

        private void BtnPercent_Click(object sender, EventArgs e)
        {
            double a;

            a = Convert.ToDouble(txtResult.Text) / Convert.ToDouble(100);

            txtResult.Text = Convert.ToString(a);
        }

        private void BtnOct_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtResult.Text);
            txtResult.Text = Convert.ToString(a, 8);
        }

        private void BtnHex_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtResult.Text);
            txtResult.Text = Convert.ToString(a, 16);
        }

        private void btnClearHistory_Click(object sender, EventArgs e)
        {
            ClearHistory();
        }

        private void txtHistory_TextChanged(object sender, EventArgs e)
        {
            if (txtHistory.Text == "")
            {
                txtHistory.Text = "There's no history yet";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Width = 606;
            txtResult.Width = 368;
        }

    }
}
