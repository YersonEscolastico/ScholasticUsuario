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
using System.Text.RegularExpressions;

namespace Registro
{
    public partial class rCargos : Form
    {
        public rCargos()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            IDNumericUpDown.Value = 0;
            DescripcionTextBox.Text = string.Empty;
            MyErrorProvider.Clear();
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private Cargo LlenaClase()
        {
            Cargo cargos = new Cargo();
            cargos.CargoId = Convert.ToInt32(IDNumericUpDown.Value);
            cargos.Descripcion = DescripcionTextBox.Text;
            return cargos;
        }

        private void LlenaCampo(Cargo cargos)
        {
            IDNumericUpDown.Value = cargos.CargoId;
            DescripcionTextBox.Text = cargos.Descripcion;
        }


        private bool Validar()
        {
            bool paso = true;
            MyErrorProvider.Clear();

            if (DescripcionTextBox.Text == string.Empty)
            {
                MyErrorProvider.SetError(DescripcionTextBox, "Este campo no puede estar vacio");
                DescripcionTextBox.Focus();
                paso = false;
            }
            return paso;
        }


        private void BuscarButton_Click(object sender, EventArgs e)
        {
            int CargoId;
            Cargo cargos = new Cargo();
            int.TryParse(IDNumericUpDown.Text, out CargoId);

            Limpiar();

            cargos = CargosBLL.Buscar(CargoId);

            if (cargos != null)
            {
                MessageBox.Show("Usuario Encontrado");
                LlenaCampo(cargos);
            }
            else
            {
                MessageBox.Show("Usuario no Encontada");
            }
        }

        private bool ExisteEnLaBaseDeDatos()
        {
            Cargo cargos = CargosBLL.Buscar((int)IDNumericUpDown.Value);

            return (cargos != null);
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            Cargo cargos;
            bool paso = false;

            if (Validar())
                return;

            cargos = LlenaClase();
            Limpiar();

            //Determinar si es guardar o modificar
            if (IDNumericUpDown.Value == 0)
                paso = CargosBLL.Guardar(cargos);
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se puede modificar una persona que no existe", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                paso = CargosBLL.Modificar(cargos);
            }

            //Informar el resultado
            if (paso)
                MessageBox.Show("Guardado!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("No se pudo guardar!!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            MyErrorProvider.Clear();
            int CargoId;
            int.TryParse(IDNumericUpDown.Text, out CargoId);


            if (!ExisteEnLaBaseDeDatos())
                return;
            if (CargosBLL.Eliminar(CargoId))
            {
                MessageBox.Show("Eliminado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar();
            }

            else
                MyErrorProvider.SetError(IDNumericUpDown, "No se puede eliminar una persona que no existe");
        }
    }
}
