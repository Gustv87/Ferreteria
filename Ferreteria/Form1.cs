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
using Oracle.ManagedDataAccess.Client;

namespace Ferreteria
{
    public partial class Form1 : Form
    {
        OracleConnection con = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Empleados nue = new Empleados();

            nue.Show();

            this.Hide();
        }

        private void coneccionBd()
        {
            String connectionString = ConfigurationManager.ConnectionStrings["ferreDB"].ConnectionString;
            con = new OracleConnection(connectionString);
            try
            {
                con.Open();
            }
            catch (Exception exp) { }


        }

    }
}
