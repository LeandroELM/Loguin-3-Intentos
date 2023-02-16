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
    public partial class Forma1 : Form
    {
        public Forma1()
        {
            InitializeComponent();
        }
        int a = 0;
        private void btnentrar_Click(object sender, EventArgs e)
        {
            string User = "FullAdmin";
            string Pass = "password*123";
            txtpass.Text.Equals(Pass);
            txtuser.Text.Equals(User);
            Forma2 obj = new Forma2();
            

                if (txtuser.Text.Equals(User) && txtpass.Text.Equals(Pass))
                {
                    obj.ShowDialog();
                    
                }
                else
                {
                    a = a + 1;
                    MessageBox.Show("Datos no encontrado, solo puede intentar 3 veces, lleva " + a + " intentos");
                    txtuser.Clear();
                    txtpass.Clear();
                    if (a == 3)
                    {
                        MessageBox.Show("Error, no se han encontrado sus datos, saldra del programa");
                        a = 0;
                        Application.Exit();

                    }
                }
            
        }
    }
}