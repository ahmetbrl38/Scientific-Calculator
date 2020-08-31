using System;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        Double result = 0;
        String operationPerformed = "";
        bool isOperationPerformed = false;
        float iCelcius, iFahreneit, iKelvin;
        char iOperation;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            if ((txtResult.Text == "0") || (isOperationPerformed))
            {
                txtResult.Clear();
            }
            isOperationPerformed = false;
            Button btn = (Button)sender;
            if (btn.Text == ",")
            {
                if (!txtResult.Text.Contains(","))
                {
                    txtResult.Text = txtResult.Text + btn.Text;
                }
            }
            else
            {
               txtResult.Text = txtResult.Text + btn.Text;
            }
        }

        private void Operator_click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (result != 0)
            {
                btnEquals.PerformClick();
                operationPerformed = btn.Text;
                result = Double.Parse(txtResult.Text);
                lblCurrentOperation.Text = result + " " + operationPerformed;
                isOperationPerformed = true;
            }
            else
            {
                operationPerformed = btn.Text;
                result = Double.Parse(txtResult.Text);
                lblCurrentOperation.Text = result + " " + operationPerformed;
                isOperationPerformed = true;
            }
            
        }



        private void btnEquals_Click(object sender, EventArgs e)
        {
            switch (operationPerformed)
            {
                case "+": txtResult.Text = (result + Double.Parse(txtResult.Text)).ToString(); break;
                case "-": txtResult.Text = (result - Double.Parse(txtResult.Text)).ToString(); break;
                case "×": txtResult.Text = (result * Double.Parse(txtResult.Text)).ToString(); break;
                case "÷": txtResult.Text = (result / Double.Parse(txtResult.Text)).ToString(); break;
                case "mod": txtResult.Text = (result % Double.Parse(txtResult.Text)).ToString(); break;
                case "EXP":
                    double i = Double.Parse(txtResult.Text);
                    double q;
                    q = (result);
                    txtResult.Text = Math.Exp(i * Math.Log(q * 4)).ToString();
                    break;


                default:
                    break;
            }
            
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            double Log = Double.Parse(txtResult.Text);
            lblCurrentOperation.Text = System.Convert.ToString("log" + "(" + (txtResult.Text) + ")");
            Log = Math.Log10(Log);
            txtResult.Text = System.Convert.ToString(Log);
        }

        private void btnSquareRoot_Click(object sender, EventArgs e)
        {
            double sqrt = Double.Parse(txtResult.Text);
            lblCurrentOperation.Text = System.Convert.ToString("√" + (txtResult.Text));
            sqrt = Math.Sqrt(sqrt);
            txtResult.Text = System.Convert.ToString(sqrt);
        }

        private void standardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 324;
            this.Height = 370;
            txtResult.Width = 289;
        }

        private void scientificToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 625;
            this.Height = 370;
            txtResult.Width = 590;
        }

        private void temperatureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 625;
            this.Height = 620;
            txtResult.Width = 590;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void btnCE_Click(object sender, EventArgs e)
        {
            result = 0;
            lblCurrentOperation.Text = "";
            txtResult.Text = "0";
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            result = 0;
            lblCurrentOperation.Text = "";
            txtResult.Text = "0";
        }

        private void btnBackspace_Click(object sender, EventArgs e)
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

        private void btnPi_Click(object sender, EventArgs e)
        {
            txtResult.Text = "3,141592653589793";
        }

        private void btnSin_Click(object sender, EventArgs e)
        {
            double sin = Double.Parse(txtResult.Text);
            lblCurrentOperation.Text = System.Convert.ToString("Sin" + (txtResult.Text));
            sin = Math.Sin(sin);
            txtResult.Text = System.Convert.ToString(sin);
        }

        private void btnCos_Click(object sender, EventArgs e)
        {
            double cos = Double.Parse(txtResult.Text);
            lblCurrentOperation.Text = System.Convert.ToString("Cos" + (txtResult.Text));
            cos = Math.Cos(cos);
            txtResult.Text = System.Convert.ToString(cos);
        }

        private void btnTan_Click(object sender, EventArgs e)
        {
            double tan = Double.Parse(txtResult.Text);
            lblCurrentOperation.Text = System.Convert.ToString("Tan" + (txtResult.Text));
            tan = Math.Tan(tan);
            txtResult.Text = System.Convert.ToString(tan);
        }

        private void btnBin_Click(object sender, EventArgs e)
        {
            lblCurrentOperation.Text = System.Convert.ToString("Bin" + "(" + (txtResult.Text) + ")");
            int a = int.Parse(txtResult.Text);
            txtResult.Text = System.Convert.ToString(a,2);

        }

        private void btnHex_Click(object sender, EventArgs e)
        {
            lblCurrentOperation.Text = System.Convert.ToString("Hex" + (txtResult.Text));
            int a = int.Parse(txtResult.Text);
            txtResult.Text = System.Convert.ToString(a, 16);
        }

        private void btnOct_Click(object sender, EventArgs e)
        {
            lblCurrentOperation.Text = System.Convert.ToString("Oct" + "(" + (txtResult.Text) + ")");
            int a = int.Parse(txtResult.Text);
            txtResult.Text = System.Convert.ToString(a, 8);
        }

        private void btnDec_Click(object sender, EventArgs e)
        {
            lblCurrentOperation.Text = System.Convert.ToString("Dec" + "(" + (txtResult.Text) + ")");
            int a = int.Parse(txtResult.Text);
            txtResult.Text = System.Convert.ToString(a);
        }

        private void btnPrimeTwo_Click(object sender, EventArgs e)
        {
            lblCurrentOperation.Text = System.Convert.ToString((txtResult.Text) + "²");
            Double a = Convert.ToDouble(txtResult.Text) * Convert.ToDouble(txtResult.Text);
            txtResult.Text = System.Convert.ToString(a);
        }

        private void btnPrimeThree_Click(object sender, EventArgs e)
        {
            lblCurrentOperation.Text = System.Convert.ToString((txtResult.Text) + "³");
            Double a = Convert.ToDouble(txtResult.Text) * Convert.ToDouble(txtResult.Text) * Convert.ToDouble(txtResult.Text);
            txtResult.Text = System.Convert.ToString(a);
        }

        private void btnOneOver_Click(object sender, EventArgs e)
        {
            lblCurrentOperation.Text = System.Convert.ToString("1/" + (txtResult.Text));
            Double a = Convert.ToDouble(1.0 / Convert.ToDouble(txtResult.Text));
            txtResult.Text = System.Convert.ToString(a);
        }

        private void btnLN_Click(object sender, EventArgs e)
        {
            double Log = Double.Parse(txtResult.Text);
            lblCurrentOperation.Text = System.Convert.ToString("ln" + "(" + (txtResult.Text) + ")");
            Log = Math.Log(Log);
            txtResult.Text = System.Convert.ToString(Log);
        }

        private void rdCtoF_CheckedChanged(object sender, EventArgs e)
        {
            iOperation = 'C';

        }

        private void rdFtoC_CheckedChanged(object sender, EventArgs e)
        {
            iOperation = 'F';
        }

        private void rdKelvin_CheckedChanged(object sender, EventArgs e)
        {
            iOperation = 'K';

        }

        private void btnResetTemp_Click(object sender, EventArgs e)
        {
            txtConvert.Clear();
            txtTemp.Text = "";
            rdCtoF.Checked = false;
            rdFtoC.Checked = false;
            rdKelvin.Checked = false;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnPercent_Click(object sender, EventArgs e)
        {
            lblCurrentOperation.Text = System.Convert.ToString((txtResult.Text) + "/100");
            Double a = Convert.ToDouble(txtResult.Text) / Convert.ToDouble(100);
            txtResult.Text = System.Convert.ToString(a);
        }

        private void btnConvertTemp_Click(object sender, EventArgs e)
        {
            switch (iOperation)
            {
                case 'C':
                    // Celcius to Fahreneit
                    iCelcius = float.Parse(txtConvert.Text);
                    txtTemp.Text = (((9 * iCelcius) / 5) + 32).ToString();
                    break;
                case 'F':
                    // Fahreneit to Celcius
                    iFahreneit = float.Parse(txtConvert.Text);
                    txtTemp.Text = (((iFahreneit - 32) * 5) / 9).ToString();
                    break;
                case 'K':
                    // Convert to Kelvin
                    iKelvin = float.Parse(txtConvert.Text);
                    txtTemp.Text = (iKelvin+ 273.15).ToString();
                    break;


            }


        }
    }          
}
