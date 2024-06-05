using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Registro : Form
    {
        private D_cliente d_Cliente = new D_cliente();
        private E_cliente e_Cliente;
        public Registro()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form formulario = new Usuario();
            formulario.Show();
        }

        private void btn_registrarse_Click(object sender, EventArgs e)
        {
            try
            {
                E_cliente cliente = new E_cliente()
                {
                    Id = e_Cliente != null ? e_Cliente.Id : 0,
                    Nombre = txt_nombre.Text,
                    Contraseña = txt_contraseña.Text,
                    Telefono = txt_telefono.Text
                };
                MessageBox.Show("Cliente guardado exitosamente.");
                Form formulario = new El_cuerno();
                formulario.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
    }
}
