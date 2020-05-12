using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex5._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            formatComboBox.SelectedIndex = 0;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                double num1 = double.Parse(textBox1.Text);
                double num2 = double.Parse(textBox2.Text);
                double result = 0;
                char op = '+';
                formatComboBox.Enabled = true;


                if (addRadioButton.Checked)
                {
                    result = num1 + num2;
                    op = '+';
                }
                else if (subtractRadioButton.Checked)
                {
                    result = num1 - num2;
                    op = '-';
                }
                else if (multiplyRadioButton.Checked)
                {
                    result = num1 * num2;
                    op = '*';
                }
                else if (divideRadioButton.Checked)
                {
                    result = num1 / num2;
                    op = '/';
                }
                else if (moduloRadioButton.Checked)
                {
                    result = num1 % num2;
                    op = '%';
                }
                
                if (result % 1 == 0) // result is an integer
                {
                    switch (formatComboBox.SelectedItem)
                    {
                        case "Binary":
                            resultLabel.Text = Convert.ToString((int)result, 2);
                            break;
                        case "Hexadeciaml":
                            resultLabel.Text = Convert.ToString((int)result, 16);
                            break;
                        case "Decimal":
                        default:
                        case "binary":
                            resultLabel.Text = Convert.ToString((int)result);
                            break;
                    }
                }
                else
                {
                    formatComboBox.SelectedItem = "Decimal";
                    formatComboBox.Enabled = false;
                    resultLabel.Text = result.ToString();
                }
                expressionLabel.Text = $"{textBox1.Text} {op} {textBox2.Text} =";
            }
            catch (DivideByZeroException dbze)
            {
                MessageBox.Show(dbze.Message, "Division by zero", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch(FormatException)
            {
                MessageBox.Show("Inputs have to be numbers.", "Wrong format", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void formatComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
