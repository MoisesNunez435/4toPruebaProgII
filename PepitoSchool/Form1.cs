using AppCore.Services;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PepitoSchool
{
    public partial class Form1 : Form
    {
        private IEstudianteService estudianteservice;
        public Form1(IEstudianteService estudianteservice)
        {
            this.estudianteservice = estudianteservice;
            InitializeComponent();
        }

        public bool Verificar()
        {
            if (String.IsNullOrEmpty(txtNombres.Text) || String.IsNullOrEmpty(txtApellidos.Text) || String.IsNullOrEmpty(txtCarnet.Text) || String.IsNullOrEmpty(txtTelefono.Text)
             || String.IsNullOrEmpty(txtDireccion.Text) || String.IsNullOrEmpty(txtCorreo.Text))
            {
                return false;
            }
            return true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
           if(Verificar())
            {
                Estudiante estudiante = new Estudiante()
                {
                    Nombres = txtNombre.Text,
                    Apellidos = txtApellidos.Text,
                    Carnet = txtCarnet.Text,
                    Phone = txtTelefono.Text,
                    Correo = txtTelefono.Text,
                    Direccion = txtDireccion.Text,
                    Contabilidad = (int)nudContabilidad.Value,
                    Programacion = (int)nudProgramacion.Value,
                    Matematica = (int)nudMatematica.Value,
                    Estadistica = (int)nudEstadistica.Value,
                  //Falto implementar el metodo para calcular el promedio, no supe como, pero el metodo ahi esta kssksks
            };
                estudianteservice.Create(estudiante);
                LlenarDGV();
                ClearTextBoxes();
            }
            else
            {
                MessageBox.Show("Debe llenar todos los campos del formulario");
            }
            
        }

        //private void dgvEstudiantes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{

        //}

        public void LlenarDGV()
        {
            dgvEstudiantes.DataSource = estudianteservice.GetAll();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LlenarDGV();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int index = dgvEstudiantes.CurrentCell.RowIndex;
            if (index >= 0)
            {
                Estudiante estudiante = estudianteservice.GetAll()[index];
                estudianteservice.Delete(estudiante);
                dgvEstudiantes.DataSource = null;
                dgvEstudiantes.DataSource = estudianteservice.GetAll();
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (Verificar())
            {
                Estudiante estudiante = new Estudiante()
                {
                    Nombres = txtNombre.Text,
                    Apellidos = txtApellidos.Text,
                    Carnet = txtCarnet.Text,
                    Phone = txtTelefono.Text,
                    Direccion = txtDireccion.Text,
                    Correo = txtCorreo.Text,
                    Matematica = (int)nudMatematica.Value,
                    Estadistica = (int)nudEstadistica.Value,
                    Programacion = (int)nudProgramacion.Value,
                    Contabilidad = (int)nudContabilidad.Value,

                };
                estudianteservice.Update(estudiante);
                LlenarDGV();
                ClearTextBoxes();
            }
            else
            {
                MessageBox.Show("Tienes que llenar todos los formularios.");
            }
        }

        private void ClearTextBoxes()
        {
            txtNombre.Text = string.Empty;
            txtApellidos.Text = string.Empty;
            txtCarnet.Text = string.Empty;
            txtCorreo.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            nudContabilidad.Value = 0;
            nudEstadistica.Value = 0;
            nudMatematica.Value = 0;
            nudProgramacion.Value = 0;
        }
    }
}
