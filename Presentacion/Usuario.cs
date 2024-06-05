﻿using Negocios;
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
    public partial class Usuario : Form
    {
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnLogin;
        private Button btnExit;
        private UserService userService = new UserService();
        public Usuario()
        {
            InitializeComponent();
        }
        private void InitializeComponents()
        {
            txt_usuario = new TextBox { Text = "Username", Top = 10, Left = 10, Width = 200 };
            txt_contraseña = new TextBox { Text = "Password", UseSystemPasswordChar = true, Top = 40, Left = 10, Width = 200 };
            btn_registrarse = new Button { Text = "Login" };
            btn_salir = new Button { Text ="Exit" };


            btn_registrarse = new Button { Text = "Login", Top = 70, Left = 10 };
            btn_registrarse.Click += btn_registrarse_Click;

            Controls.Add(txt_usuario);
            Controls.Add(txt_contraseña);
            Controls.Add(btn_registrarse);
            Controls.Add(btnExit);

            btnExit = new Button { Text = "Exit", Top = 70, Left = 100 };
            btnExit.Click += btn_salir_Click;
        }

        private void btn_registrarse_Click(object sender, EventArgs e)
        {
            string username = txt_usuario.Text;
            string password = txt_contraseña.Text;
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Porfavor complete los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            bool isValid = userService.ValidateUser(username, password);
            if (isValid)
            {
                MessageBox.Show("Bienvenido otra vez 😁", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Form formulario = new El_cuerno();
                formulario.Show();
            }
            else
            {
                MessageBox.Show("Ups!, su nombre de usuario o contraseña son incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("oh,tan rapido te vas?😔", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form formulario = new Registro();
            formulario.Show();
        }
    }
}
