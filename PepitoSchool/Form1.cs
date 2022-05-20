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
                    Estadistica = (int)nudEstadistica.Value
                };
                estudianteservice.Create(estudiante);
                
                LlenarDGV();
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
    }
}
