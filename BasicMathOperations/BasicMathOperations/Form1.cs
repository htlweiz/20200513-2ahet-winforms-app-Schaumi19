using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicMathOperations
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Summe_Click(object sender, EventArgs e)
        {
            int Zahl1 = 0;
            int Zahl2 = 0;

            try
            {
                Zahl1 = Convert.ToInt32(txt_Zahl1.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Bitte nur Ganzzahlen eingeben!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Zahl1.Focus();
                txt_Zahl1.SelectAll();
            }
            try
            {
                Zahl2 = Convert.ToInt32(txt_Zahl2.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Bitte nur Ganzzahlen eingeben!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Zahl1.Focus();
                txt_Zahl1.SelectAll();
            }
            txt_Ergebnis.Text = Convert.ToString(Zahl1 + Zahl2);
            lbl_Ergebnis.Text = "Summe:";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Zahl1 = 0;
            int Zahl2 = 0;

            try
            {
                Zahl1 = Convert.ToInt32(txt_Zahl1.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Bitte nur Ganzzahlen eingeben!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Zahl1.Focus();
                txt_Zahl1.SelectAll();
            }
            try
            {
                Zahl2 = Convert.ToInt32(txt_Zahl2.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Bitte nur Ganzzahlen eingeben!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Zahl1.Focus();
                txt_Zahl1.SelectAll();
            }
            txt_Ergebnis.Text = Convert.ToString(Zahl1 - Zahl2);
            lbl_Ergebnis.Text = "Differenz:";
        }

        private void btn_Produkt_Click(object sender, EventArgs e)
        {
            int Zahl1 = 0;
            int Zahl2 = 0;

            try
            {
                Zahl1 = Convert.ToInt32(txt_Zahl1.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Bitte nur Ganzzahlen eingeben!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Zahl1.Focus();
                txt_Zahl1.SelectAll();
            }
            try
            {
                Zahl2 = Convert.ToInt32(txt_Zahl2.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Bitte nur Ganzzahlen eingeben!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Zahl1.Focus();
                txt_Zahl1.SelectAll();
            }
            txt_Ergebnis.Text = Convert.ToString(Zahl1 * Zahl2);
            lbl_Ergebnis.Text = "Produkt:";
        }

        private void btn_Division_Click(object sender, EventArgs e)
        {
            int Zahl1 = 0;
            int Zahl2 = 0;

            try
            {
                Zahl1 = Convert.ToInt32(txt_Zahl1.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Bitte nur Ganzzahlen eingeben!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Zahl1.Focus();
                txt_Zahl1.SelectAll();
            }
            try
            {
                Zahl2 = Convert.ToInt32(txt_Zahl2.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Bitte nur Ganzzahlen eingeben!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Zahl1.Focus();
                txt_Zahl1.SelectAll();
            }
            if(Zahl2 == 0)
            {
                MessageBox.Show("0 Division", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Zahl2.Focus();
                txt_Zahl2.SelectAll();
            }
            else
            {
                txt_Ergebnis.Text = Convert.ToString(Zahl1 / Zahl2);
                lbl_Ergebnis.Text = "Quotientenwert:";
            }
            
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txt_Zahl1.Text = "0";
            txt_Zahl2.Text = "0";
            txt_Ergebnis.Text = "";
            lbl_Ergebnis.Text = "Ergebnis:";
            txt_Zahl1.Focus();
            txt_Zahl1.SelectAll();
        }
    }
}
