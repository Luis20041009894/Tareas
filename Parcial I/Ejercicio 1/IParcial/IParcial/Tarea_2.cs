using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IParcial
{
    public partial class Tarea_2 : Form
    {
        public Tarea_2()
        {
            InitializeComponent();
        }
                

        private async void CalcularButton_Click(object sender, EventArgs e)
        {

            // Validación:
            if (string.IsNullOrWhiteSpace(Nota1TextBox.Text) ||
                string.IsNullOrWhiteSpace(Nota2TextBox.Text) ||
                string.IsNullOrWhiteSpace(Nota3TextBox.Text) ||
                string.IsNullOrWhiteSpace(Nota4TextBox.Text))
            {
                MessageBox.Show("Por favor ingrese todas las notas");
                return;
            }

            decimal nota1 = Convert.ToDecimal(Nota1TextBox.Text);
            decimal nota2 = Convert.ToDecimal(Nota2TextBox.Text);
            decimal nota3 = Convert.ToDecimal(Nota3TextBox.Text);
            decimal nota4 = Convert.ToDecimal(Nota4TextBox.Text);
            
            decimal promediototal = await CalcularpromedioAsync(nota1, nota2, nota3, nota4);

            PromediofinalTextBox.Text = promediototal.ToString();

            //MessageBox.Show($"El promedio final es: {promediototal}");

        }
        
        private async Task<decimal> CalcularpromedioAsync(decimal n1, decimal n2, decimal n3, decimal n4)
        {
            decimal promedio = await Task.Run(() =>
            {
                return (n1 + n2 + n3 + n4) / 4;

            });
            return promedio;
                
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            Nota1TextBox.Clear();
            Nota2TextBox.Clear();
            Nota3TextBox.Clear();
            Nota4TextBox.Clear();
            PromediofinalTextBox.Clear();

                    }

        private void SalirButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Nota1TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 45) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se aceptan Números Enteros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;

                return;
            }

        }

        private void Nota2TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 45) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se aceptan Números Enteros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;

                return;
            }


        }

        private void Nota3TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 45) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se aceptan Números Enteros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;

                return;
            }
        }

        private void Nota4TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 45) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se aceptan Números Enteros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;

                return;
            }
        }
    }
}
