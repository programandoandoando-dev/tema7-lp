using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace Tema7FP
{
    public partial class frmGestionEstudiante : Form
    {
        public frmGestionEstudiante()
        {
            InitializeComponent();
        }

        private void frmGestionEstudiante_Load(object sender, EventArgs e)
        {
            //Llamamos a nuestra cadena de conexion
            SqlConnection cnx = new SqlConnection(ConfigurationManager.ConnectionStrings["CONX"].ConnectionString);

            SqlCommand cmd = new SqlCommand("SELECT * FROM carrera", cnx);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgvListaCarreras.DataSource = dt;

            dgvListaCarreras.Columns[1].Width = 200;
            dgvListaCarreras.Columns[2].Width = 200;
        }
    }
}
