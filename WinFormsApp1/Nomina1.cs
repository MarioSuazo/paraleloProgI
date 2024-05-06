using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Nomina1 : Form
    {
        private int n = 0;
        public Nomina1()
        {
            InitializeComponent();
        }

        private void addB_Click(object sender, EventArgs e)
        {
            int n = dgvNom.Rows.Add();
            double ing, ant, antP, ingBr, InL, opBr, IR;
            double IngN, ano;
            try
            {
                ano = double.Parse(anIn.Text);
                ing = double.Parse(mIng.Text);

                dgvNom.Rows[n].Cells[0].Value = cedula.Text;
                dgvNom.Rows[n].Cells[1].Value = name.Text;
                dgvNom.Rows[n].Cells[2].Value = lname.Text;
                if (ing < 7000 || ing > 360000)
                {
                    MessageBox.Show("El Rango de Ingreso Valido está entre 7,000 y 360,000.");
                    if (n != -1)
                    {
                        dgvNom.Rows.RemoveAt(n);
                    }
                }
                else
                {
                    dgvNom.Rows[n].Cells[3].Value = mIng.Text;

                    ant = 2024 - ano;
                    antP = ((2 * ant) + 1) / 100;
                    ingBr = (antP * ing) + ing;
                    InL = ingBr * 0.07;
                    opBr = ingBr - InL;
                    IR = opBr * 0.1; ;
                    IngN = opBr - IR;

                    dgvNom.Rows[n].Cells[4].Value = ant;
                    dgvNom.Rows[n].Cells[5].Value = InL;
                    dgvNom.Rows[n].Cells[6].Value = IR;
                    dgvNom.Rows[n].Cells[7].Value = (antP * 100) + "%";
                    dgvNom.Rows[n].Cells[8].Value = IngN;

                    cedula.Clear();
                    name.Clear();
                    lname.Clear();
                    mIng.Clear();
                    anIn.Clear();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Los espacios deben ser rellenados excepcion", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                if (n != -1)
                {
                    dgvNom.Rows.RemoveAt(n);
                }
            }
        }

        private void mIng_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                MessageBox.Show("El ingreso de Letras es Inválido", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void anIn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                MessageBox.Show("El ingreso de Letras es Inválido", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void erB_Click(object sender, EventArgs e)
        {
            try
            {
                if (n != -1)
                {
                    dgvNom.Rows.RemoveAt(n);
                }

            }
            catch (Exception)
            {
                MessageBox.Show("No Hay Productos Para Borrar", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
        }

        private void exitB_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void dgvNom_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            n = e.RowIndex;

            if (n != -1)
            {
                infoL.Text = (string)dgvNom.Rows[n].Cells[1].Value;
            }
        }
    }
}
