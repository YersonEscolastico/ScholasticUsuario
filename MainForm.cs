using Registro.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Registro.BLL;

namespace Registro
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void RegistroToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void UsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrincipalForm frm = new PrincipalForm();
            frm.Show();
        }

        private void CargosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rCargos frm = new rCargos();
            frm.Show();
        }

        private void ConsultaCargosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cConsultas frm = new cConsultas();
            frm.Show();
        }
    }
}