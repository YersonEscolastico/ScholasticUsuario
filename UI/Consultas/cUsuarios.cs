using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Registro.Entidades;
using Registro.BLL;

namespace Registro
{
    public partial class cUsuarios : Form
    {
        public cUsuarios()
        {
            InitializeComponent();
        }

        private void ConsultarButton_Click(object sender, EventArgs e)
        {
            var listado = new List<Usuario>();

            if (CriterioTextBox.Text.Trim().Length > 0)
            {
                switch (FiltrocomboBox.Text)
                {
                    case "Todo":
                        listado = UsuariosBll.GetList(p => true);
                        break;

                    case "Id":
                        int id = Convert.ToInt32(CriterioTextBox.Text);
                        listado = UsuariosBll.GetList(p => p.UsuarioId == id);
                        break;

                    case "Nombre":
                        listado = UsuariosBll.GetList(p => p.Nombre.Contains(CriterioTextBox.Text));
                        break;

                    case "Email":
                        listado = UsuariosBll.GetList(p => p.Email.Contains(CriterioTextBox.Text));
                        break;

                    case "Usuarios":
                        listado = UsuariosBll.GetList(p => p.Usuarios.Contains(CriterioTextBox.Text));
                        break;

                    case "Nivel de usuarios":
                        listado = UsuariosBll.GetList(p => p.NivelUsuario.Contains(CriterioTextBox.Text));
                        break;
                }
            }
            else
            {
                listado = UsuariosBll.GetList(p => true);
            }

            dataGridView.DataSource = null;
            dataGridView.DataSource = listado;
        }
    }
}
