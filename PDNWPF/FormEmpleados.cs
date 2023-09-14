using System.Net;
using System.Text.Encodings.Web;
using Newtonsoft.Json;
using PDNWPF.HttpHelper;
using ConexionDatos;
using System.Collections.Generic;
using ConexionDatos.EDM;
using static ConexionDatos.Repositorio;

namespace PDNWPF
{
    public partial class FormEmpleados : Form
    {
        public FormEmpleados()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }


        public async void refeshW()
        {
            HttpHelp hp = new HttpHelp();
            string resp = "";

            List<ExaTEmpleado2> lst = new List<ExaTEmpleado2>();
            resp = await hp.obtenEmpleados("https://backendapipdn.azurewebsites.net/obtieneEmpleados/0");

            lst = JsonConvert.DeserializeObject<List<ExaTEmpleado2>>(resp);
            dataGridView1.DataSource = lst;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Presentacion.FrmAgregaEdita frmAg = new Presentacion.FrmAgregaEdita(null);
            frmAg.ShowDialog();
            refeshW();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private int? obtenId()
        {
            try
            {
                int? id = int.Parse(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString());
                return id;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Selecciona un registro");
                return null;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int? id = obtenId();
            if (id != null)
            {
                Presentacion.FrmAgregaEdita frmAg = new Presentacion.FrmAgregaEdita(id);
                frmAg.ShowDialog();
            }
        }

        private void FormEmpleados_Load(object sender, EventArgs e)
        {
            refeshW();
        }


        private void FormEmpleados_Activated(object sender, EventArgs e)
        {
            refeshW();

        }

        private async void button3_Click(object sender, EventArgs e)
        {
            int? id = obtenId();
            if (id != null)
            {
                Presentacion.FrmAgregaEdita frmAg = new Presentacion.FrmAgregaEdita(id);
                string res = await frmAg.eliminaEmpleado(false);
                MessageBox.Show(res);
            }
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}