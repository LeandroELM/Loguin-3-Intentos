using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace LoginUser_Prueba
{
    public partial class Forma2 : Form
    {
        
        public Forma2()
        {
            InitializeComponent();
        }
        public void clearFind() 
        {
            txtname.Text = String.Empty;
            txtlastname.Text = String.Empty;
            txtcode.Text = String.Empty;
            txtcedula.Text = String.Empty;
            txtcargo.Text = String.Empty;
            txtpuesto.Text = String.Empty;
            cbosex.Text = String.Empty;

            txtname.Focus();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnadd_Click(object sender, EventArgs e)
        {

            string name,lastn,code,cedula,cargo,sexo,puesto;
            if (txtname.Text == "" || txtlastname.Text == "" || txtcode.Text == "" || txtcedula.Text == "" || txtcargo.Text == "" || cbosex.Text == "" || txtpuesto.Text == "")
            {
                MessageBox.Show("Hay campos vacios, verifiquelos");
            }
            else
            {
                name = txtname.Text;
                lastn = txtlastname.Text;
                code = txtcode.Text;
                cedula = txtcedula.Text;
                cargo = txtcargo.Text;
                sexo = cbosex.Text;
                puesto = txtpuesto.Text;



                string[] datos = new string[100];
                datos[0] = txtcedula.Text;
                datos[1] = txtcode.Text;
                datos[2] = txtname.Text;
                datos[3] = txtlastname.Text;
                datos[4] = cbosex.Text;
                datos[5] = txtcargo.Text;
                datos[6] = txtpuesto.Text;

                dataGridView1.Rows.Add(datos);

                clearFind();
            }
           
        }

        private void Forma2_Load(object sender, EventArgs e)
        {

        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            clearFind();
           
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            
            
        }

        private void txtcode_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtbusqueda_TextChanged(object sender, EventArgs e)
        {
            txtbusqueda.Text = txtcode.Text.Trim();

            foreach (DataGridViewRow row in dataGridView1.Rows) 
            {

            }
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Esta seguro de querer salir?",
                                          "Empresa C.C.N",
                                          MessageBoxButtons.YesNo,
                                          MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
                this.Close();
        }
    }
}
