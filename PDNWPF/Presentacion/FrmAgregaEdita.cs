using ConexionDatos;
using ConexionDatos.EDM;
using Newtonsoft.Json;
using PDNWPF.HttpHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ConexionDatos.Repositorio;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PDNWPF.Presentacion
{
    public partial class FrmAgregaEdita : Form
    {
        public int? id;
        public FrmAgregaEdita(int? id = null)
        {
            InitializeComponent();
            this.id = id;
            if (id != null)
            {
                CargaDatos();
            }
            txtSaldo.KeyPress += new KeyPressEventHandler(textBox2_KeyPress);

        }

        public async void CargaDatos()
        {
            try
            {
                HttpHelp hp = new HttpHelp();
                string resp = "";
                List<ExaTEmpleado> lst = new List<ExaTEmpleado>();
                resp = await hp.obtenEmpleados(string.Format("https://backendapipdn.azurewebsites.net/obtieneEmpleados/{0}", id));
                lst = JsonConvert.DeserializeObject<List<ExaTEmpleado>>(resp);
                ExaTEmpleado el = lst.FirstOrDefault();

                //Se llenan datos 
                dtmFechaN.Value = el.FechaNacimiento;
                dropArea.SelectedValue = el.Area;
                txtSaldo.Text = el.Sueldo.ToString();
                txtNombre.Text = el.Nombre;
                txtAp.Text = el.Apaterno;
                txtAm.Text = el.Amaterno;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);

            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void label6_Click(object sender, EventArgs e)
        {
        }

        public async Task<string> eliminaEmpleado(bool? est)
        {
            try
            {
                HttpHelp hp = new HttpHelp();
                string resp = "";
                List<ExaTEmpleado> lst = new List<ExaTEmpleado>();
                resp = await hp.obtenEmpleados(string.Format("https://backendapipdn.azurewebsites.net/obtieneEmpleados/{0}", id));
                lst = JsonConvert.DeserializeObject<List<ExaTEmpleado>>(resp);
                ExaTEmpleado el = lst.FirstOrDefault();
                el.Estatus = est;
                string res = await hp.enviaEmpleado("https://backendapipdn.azurewebsites.net/ingModEmpleado", el);
                return res;

            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }

        //Metodo para modificar 
        private async Task<string> modificaEmpleado(bool? est)
        {
            try
            {
                ExaTEmpleado emp = new ExaTEmpleado();
                emp.IdEmpleado = Convert.ToInt32(id);
                emp.FechaCreacion = DateTime.Now;
                emp.FechaNacimiento = dtmFechaN.Value;
                emp.Area = Convert.ToInt32(dropArea.SelectedValue);
                emp.Sueldo = Convert.ToDecimal(txtSaldo.Text);
                emp.Nombre = txtNombre.Text;
                emp.Apaterno = txtAp.Text;
                emp.Amaterno = txtAm.Text;
                emp.Estatus = est;
                HttpHelp hp = new HttpHelp();
                string res = await hp.enviaEmpleado("https://backendapipdn.azurewebsites.net/ingModEmpleado", emp);
                return res;

            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {

                ExaTEmpleado emp = new ExaTEmpleado();
                string res = await modificaEmpleado(true);

                this.Close();
                //PDNWPF.FormEmpleados.refeshW();
                MessageBox.Show(res, "Respuesta", MessageBoxButtons.OK);
                //refresw(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error: " + ex.Message, "Respuesta", MessageBoxButtons.OK);

            }

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // Si no es un número ni una tecla de control, ignora la tecla presionada
                e.Handled = true;
            }
        }

        private async void FrmAgregaEdita_Load(object sender, EventArgs e)
        {
            HttpHelp hp = new HttpHelp();
            string resp = "";
            List<ExaCArea> lst = new List<ExaCArea>();
            resp = await hp.obtenEmpleados("https://backendapipdn.azurewebsites.net/obtenAreas");
            lst = JsonConvert.DeserializeObject<List<ExaCArea>>(resp);
            dropArea.DataSource = lst;
            dropArea.DisplayMember = "Area";
            dropArea.ValueMember = "IdArea";
        }
    }
}
