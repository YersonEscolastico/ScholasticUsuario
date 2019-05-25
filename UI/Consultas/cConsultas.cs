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
    public partial class cConsultas : Form
    {
        public cConsultas()
        {
            InitializeComponent();
        }

        private void ConsultarButton_Click(object sender, EventArgs e)
        {
            var listado = new List<Cargo>();

            if (CriterioTextBox.Text.Trim().Length > 0)
            {
                switch (FiltrocomboBox.Text)
                {
                    case "Todo":
                        listado = CargosBLL.GetList(p => true);
                        break;

                    case "Id":
                        int id = Convert.ToInt32(CriterioTextBox.Text);
                        listado = CargosBLL.GetList(p => p.CargoId == id);
                        break;

                    case "Descripcion":
                        listado = CargosBLL.GetList(p => p.Descripcion.Contains(CriterioTextBox.Text));
                        break;
                }
            }
            else
            {
                listado = CargosBLL.GetList(p => true);
            }

            dataGridView.DataSource = null;
            dataGridView.DataSource = listado;
        }
    }
}
