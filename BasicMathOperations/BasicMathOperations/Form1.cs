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
        private bool Error = false;

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Liest die Zahl 1 und überprüft auf Eingabefehler.
        /// </summary>
        /// <returns>Zahl 1</returns>
        private int GetNumberOne()
        {
            try
            {
                return Convert.ToInt32(txt_Zahl1.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Zahl 1: Bitte nur Ganzzahlen eingeben!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Zahl1.Focus();
                txt_Zahl1.SelectAll();
                Error = true;
            }
            return 0;
        }

        /// <summary>
        /// Liest die Zahl 2 und überprüft auf Eingabefehler.
        /// </summary>
        /// <returns>Zahl 2</returns>
        private int GetNumberTwo()
        {
            try
            {
                return Convert.ToInt32(txt_Zahl2.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Zahl 2: Bitte nur Ganzzahlen eingeben!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Zahl1.Focus();
                txt_Zahl1.SelectAll();
                Error = true;
            }
            return 0;
        }

        /// <summary>
        /// Gibt die Eingaben addiert aus und ändert den Ergebnisnamen auf Summe
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Summe_Click(object sender, EventArgs e)
        {
            
            txt_Ergebnis.Text = Convert.ToString(GetNumberOne() + GetNumberTwo());
            lbl_Ergebnis.Text = "Summe:";
        }

        /// <summary>
        /// Gibt die Eingaben subtrahiert aus und ändert den Ergebnisnamen auf Differenz
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            
            txt_Ergebnis.Text = Convert.ToString(GetNumberOne() - GetNumberTwo());
            lbl_Ergebnis.Text = "Differenz:";
        }

        /// <summary>
        /// Gibt die Eingaben multipliziert aus und ändert den Ergebnisnamen auf Produkt
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Produkt_Click(object sender, EventArgs e)
        {
            
            txt_Ergebnis.Text = Convert.ToString(GetNumberOne() * GetNumberTwo());
            lbl_Ergebnis.Text = "Produkt:";
        }

        /// <summary>
        /// Gibt die Eingaben dividiert aus und ändert den Ergebnisnamen auf Quotientenwert
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Division_Click(object sender, EventArgs e)
        {
            Error = false;
            int Zahl1 = 0;
            int Zahl2 = 0;

            Zahl1 = GetNumberOne();
            Zahl2 = GetNumberTwo();
            if (!Error)
            {
                if (Zahl2 == 0)
                {
                    MessageBox.Show("0 Division", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_Zahl2.Focus();
                    txt_Zahl2.SelectAll();
                    Error = true;
                }
                else
                {
                    txt_Ergebnis.Text = Convert.ToString(Zahl1 / Zahl2);
                    lbl_Ergebnis.Text = "Quotientenwert:";
                }
            }
            
            
        }

        /// <summary>
        /// Setzt die Eingabefelder auf den Start zurück und setzt den Focus auf Zahl1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txt_Zahl1.Text = "0";
            txt_Zahl2.Text = "0";
            txt_Ergebnis.Text = "";
            lbl_Ergebnis.Text = "Ergebnis:";
            txt_Zahl1.Focus();
            txt_Zahl1.SelectAll();
        }

        /// <summary>
        /// Gibt die Wurzel der Eingaben aus und ändert den Ergebnisnamen auf Wurzel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Wurzel_Click(object sender, EventArgs e)
        {
            Error = false;
            int Zahl1 = 0;
            int Zahl2 = 0;

            Zahl1 = GetNumberOne();
            Zahl2 = GetNumberTwo();

            if (!Error)
            {
                if (Zahl2 < 0)
                {
                    MessageBox.Show("Negative Wurzel ist nicht definiert", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_Zahl2.Focus();
                    txt_Zahl2.SelectAll();
                    Error = true;
                }
                else
                {
                    txt_Ergebnis.Text = Convert.ToString(Math.Pow(Zahl2, 1.0 / Zahl1));
                    lbl_Ergebnis.Text = "Wurzel:";
                }
            }
            
        }

        /// <summary>
        /// Gibt die Eingaben Potenziert aus und ändert den Ergebnisnamen auf Potenz
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Exponentieren_Click(object sender, EventArgs e)
        {
            txt_Ergebnis.Text = Convert.ToString(Math.Pow(GetNumberOne(), GetNumberTwo()));
            lbl_Ergebnis.Text = "Potenz:";
        }
    }
}
