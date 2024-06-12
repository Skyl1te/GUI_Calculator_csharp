using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace GUI_Calculator_csharp
{
    public partial class Form1 : Form
    {
        double FirstNumber, SecondNumber, Result;
        string Operation;
        public Form1()
        {
            InitializeComponent();
            CustomizeForm();
        }

        private void CustomizeForm()
        {
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.ControlBox = true; 
            this.Text = "Calculator";  
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            n0.BorderStyle = BorderStyle.None;
            n0.ForeColor = System.Drawing.Color.White;

            n1.FlatStyle = FlatStyle.Flat;
            n1.FlatAppearance.BorderSize = 0;

            n2.FlatStyle = FlatStyle.Flat;
            n2.FlatAppearance.BorderSize = 0;

            n3.FlatStyle = FlatStyle.Flat;
            n3.FlatAppearance.BorderSize = 0;

            n4.FlatStyle = FlatStyle.Flat;
            n4.FlatAppearance.BorderSize = 0;

            n5.FlatStyle = FlatStyle.Flat;
            n5.FlatAppearance.BorderSize = 0;

            n6.FlatStyle = FlatStyle.Flat;
            n6.FlatAppearance.BorderSize = 0;

            n7.FlatStyle = FlatStyle.Flat;
            n7.FlatAppearance.BorderSize = 0;

            n8.FlatStyle = FlatStyle.Flat;
            n8.FlatAppearance.BorderSize = 0;

            n9.FlatStyle = FlatStyle.Flat;
            n9.FlatAppearance.BorderSize = 0;

            clear_btn.FlatStyle = FlatStyle.Flat;
            clear_btn.FlatAppearance.BorderSize = 0;

            symChange.FlatStyle = FlatStyle.Flat;
            symChange.FlatAppearance.BorderSize = 0;

            percentage.FlatStyle = FlatStyle.Flat;
            percentage.FlatAppearance.BorderSize = 0;

            zero.FlatStyle = FlatStyle.Flat;
            zero.FlatAppearance.BorderSize = 0;

            comma.FlatStyle = FlatStyle.Flat;
            comma.FlatAppearance.BorderSize = 0;

            divide.FlatStyle = FlatStyle.Flat;
            divide.FlatAppearance.BorderSize = 0;

            plus.FlatStyle = FlatStyle.Flat;
            plus.FlatAppearance.BorderSize = 0;

            multiply.FlatStyle = FlatStyle.Flat;
            multiply.FlatAppearance.BorderSize = 0;

            minus.FlatStyle = FlatStyle.Flat;
            minus.FlatAppearance.BorderSize = 0;

            equal.FlatStyle = FlatStyle.Flat;
            equal.FlatAppearance.BorderSize = 0;

        }

        private void n0_TextChanged(object sender, EventArgs e)
        {

        }

        private void n1_Click(object sender, EventArgs e)
        {
            if (n0.Text == "0" && n0.Text != null)
            {
                n0.Text = "1";
            }
            else
            {
                n0.Text = n0.Text + "1";
            }
        }

        private void n2_Click(object sender, EventArgs e)
        {
            if (n0.Text == "0" && n0.Text != null)
            {
                n0.Text = "2";
            }
            else
            {
                n0.Text = n0.Text + "2";
            }
        }

        private void n3_Click(object sender, EventArgs e)
        {
            if (n0.Text == "0" && n0.Text != null)
            {
                n0.Text = "3";
            }
            else
            {
                n0.Text = n0.Text + "3";
            }
        }

        private void n4_Click(object sender, EventArgs e)
        {
            if (n0.Text == "0" && n0.Text != null)
            {
                n0.Text = "4";
            }
            else
            {
                n0.Text = n0.Text + "4";
            }
        }

        private void n5_Click(object sender, EventArgs e)
        {
            if (n0.Text == "0" && n0.Text != null)
            {
                n0.Text = "5";
            }
            else
            {
                n0.Text = n0.Text + "5";
            }
        }

        private void n6_Click(object sender, EventArgs e)
        {
            if (n0.Text == "0" && n0.Text != null)
            {
                n0.Text = "6";
            }
            else
            {
                n0.Text = n0.Text + "6";
            }
        }

        private void n7_Click(object sender, EventArgs e)
        {
            if (n0.Text == "0" && n0.Text != null)
            {
                n0.Text = "7";
            }
            else
            {
                n0.Text = n0.Text + "7";
            }
        }

        private void n8_Click(object sender, EventArgs e)
        {
            if (n0.Text == "0" && n0.Text != null)
            {
                n0.Text = "8";
            }
            else
            {
                n0.Text = n0.Text + "8";
            }
        }

        private void n9_Click(object sender, EventArgs e)
        {
            if (n0.Text == "0" && n0.Text != null)
            {
                n0.Text = "9";
            }
            else
            {
                n0.Text = n0.Text + "9";
            }
        }

        private void zero_Click(object sender, EventArgs e)
        {
            if (n0.Text == "0" && n0.Text != null)
            {
                n0.Text = "0";
            }
            else
            {
                n0.Text = n0.Text + "0";
            }
        }
        private void comma_Click(object sender, EventArgs e)
        {
            if (n0.Text == "0" && n0.Text != null)
            {
                n0.Text = ",";
            }
            else
            {
                n0.Text = n0.Text + ",";
            }
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            n0.Clear();
        }

        private void divide_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(n0.Text);
            n0.Text = "0";
            Operation = "/";
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(n0.Text);
            n0.Text = "0";
            Operation = "*";
        }

        private void minus_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(n0.Text);
            n0.Text = "0";
            Operation = "-";
        }

        private void symChange_Click(object sender, EventArgs e)
        {
            double currentValue;
            if (double.TryParse(n0.Text, out currentValue))
            {
                currentValue *= -1;
                n0.Text = currentValue.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double currentValue;
            if (double.TryParse(n0.Text, out currentValue))
            {
                currentValue /= 100;
                n0.Text = currentValue.ToString();
            }
        }

        private void plus_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(n0.Text);
            n0.Text = "0";
            Operation = "+";
        }

        private void equal_Click(object sender, EventArgs e)
        {
            

            SecondNumber = Convert.ToDouble(n0.Text);

            switch (Operation) 
            {
                case "+":
                    Result = FirstNumber + SecondNumber;
                    break;

                case "-":
                    Result = FirstNumber - SecondNumber;
                    break;

                case "*":
                    Result = FirstNumber * SecondNumber;
                    break;

                case "/":
                    Result = FirstNumber / SecondNumber;
                    break;
            }
            n0.Text = Result.ToString();


        }
    }
}
