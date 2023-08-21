using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AZS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void AzsBenzinTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void AzsCellTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void AzsRadTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void AzsRadButTextBox2_TextChanged(object sender, EventArgs e)
        {
            
        }
        //AZS
        private void AzsAllLabel5_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Double All = Convert.ToDouble(AzsCellTextBox.Text) * Convert.ToDouble(AzsRadTextBox1.Text);
            AzsAllLabel5.Text = Convert.ToString(All);
            AzsRadButTextBox2.Text = Convert.ToString(All);
            if (radioButton1.Checked == false)
            {
                All = Convert.ToDouble(AzsCellTextBox.Text) * Convert.ToDouble(AzsRadTextBox1.Text);
                AzsAllLabel5.Text = Convert.ToString(All);
                AzsRadButTextBox2.Text = Convert.ToString(All);
            }
        }

        private void CafeCheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CafecheckBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CafeCheckBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CafeCheckBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CafePriceTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void CafePriceTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void CafePriceTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void CafePriceTextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void CafePriceQuantTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void CafePriceQuantTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void CafePriceQuantTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void CafePriceQuantTextBox4_TextChanged(object sender, EventArgs e)
        {

        }
        // Cafe
        private void CafePriceAlllabell_Click(object sender, EventArgs e)
        {
            Double All = 0;
            if(CafeCheckBox1.Checked)
            {
                All += Convert.ToDouble(CafePriceTextBox1.Text) * Convert.ToDouble(CafePriceQuantTextBox1.Text);
                
            }
            if(CafecheckBox2.Checked)
            {
                All += Convert.ToDouble(CafePriceTextBox2.Text) * Convert.ToDouble(CafePriceQuantTextBox2.Text);
                
            }
            if (CafeCheckBox3.Checked)
            {
                All += Convert.ToDouble(CafePriceTextBox3.Text) * Convert.ToDouble(CafePriceQuantTextBox3.Text);

            }
            if (CafeCheckBox4.Checked)
            {
                All += Convert.ToDouble(CafePriceTextBox4.Text) * Convert.ToDouble(CafePriceQuantTextBox4.Text);

            }
            CafePriceAlllabell.Text = Convert.ToString(All);

        }

        private void ButtAll_Click(object sender, EventArgs e)
        {
            Double All = 0;
            try
            {
                All = Convert.ToDouble(AzsAllLabel5.Text) + Convert.ToDouble(CafePriceAlllabell.Text);
            }
            catch (Exception ex)
            {
                if (AzsAllLabel5.Text == null || CafePriceAlllabell.Text == null)
                {
                    MessageBox.Show("Исключение!");
                }
            }
            finally
            {

            }
            AllPrice.Text = Convert.ToString(All);
        }

        private void AllPrice_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Без бензина")
            {
                AzsCellTextBox.Text = "0";
            }
            if (comboBox1.Text == "АИ-80")
            {
                AzsCellTextBox.Text = "30,24";
            }
            if (comboBox1.Text == "АИ-92")
            {
                AzsCellTextBox.Text = "33,45";
            }
            if (comboBox1.Text == "АИ-95")
            {
                AzsCellTextBox.Text = "36,34";
            }
            if (comboBox1.Text == "АИ-98")
            {
                AzsCellTextBox.Text = "40,24";
            }
            if (comboBox1.Text == "АИ-100")
            {
                AzsCellTextBox.Text = "42,79";
            }

        }
    }
}
