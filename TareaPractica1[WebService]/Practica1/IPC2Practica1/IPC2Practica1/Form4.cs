﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IPC2Practica1
{
    public partial class Form4 : Form
    {
        ServicioWebCliente.ServicioWebSoapClient servicio = new ServicioWebCliente.ServicioWebSoapClient();
        private DataView dv;
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = servicio.Buscar(textBox1.Text);
            dataGridView1.DataMember = "Libro";

        }
    }
}
