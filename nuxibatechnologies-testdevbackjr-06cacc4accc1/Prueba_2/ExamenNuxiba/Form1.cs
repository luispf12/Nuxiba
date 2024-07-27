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
using System.IO;



namespace ExamenNuxiba
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtAgregar_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Nuxiba"].ConnectionString))
            {
                connection.Open();
                string insertQuery = "INSERT INTO usuarios (Login, Nombre, Paterno, Materno) VALUES (@Login, @Nombre, @Paterno, @Materno);" +
                                     "INSERT INTO empleados (userId, Sueldo, FechaIngreso) VALUES ((SELECT MAX(userId) FROM usuarios), @Sueldo, @FechaIngreso);";
                SqlCommand command = new SqlCommand(insertQuery, connection);
                command.Parameters.AddWithValue("@Login", txBLogin.Text);
                command.Parameters.AddWithValue("@Nombre", txBNombre.Text);
                command.Parameters.AddWithValue("@Paterno", txBPaterno.Text);
                command.Parameters.AddWithValue("@Materno", txBMaterno.Text);
                command.Parameters.AddWithValue("@Sueldo", Convert.ToDouble(txBSueldo.Text));
                command.Parameters.AddWithValue("@FechaIngreso", DateTime.Today);
                command.ExecuteNonQuery();
                MessageBox.Show("Nuevo usuario agregado.");
            }
        }

        private void txBLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void txBNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txBPaterno_TextChanged(object sender, EventArgs e)
        {

        }

        private void txBMaterno_TextChanged(object sender, EventArgs e)
        {

        }

        private void txBSueldo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txBLoginSueldo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txBSueldoNuevo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btModificar_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Nuxiba"].ConnectionString))
            {
                connection.Open();
                string updateQuery = "UPDATE empleados SET Sueldo = @nuevoSueldo WHERE userId = @userId";
                SqlCommand command = new SqlCommand(updateQuery, connection);
                command.Parameters.AddWithValue("@nuevoSueldo", Convert.ToDouble(txBSueldoNuevo.Text));
                command.Parameters.AddWithValue("@userId", Convert.ToInt32(txBLoginSueldo.Text));
                command.ExecuteNonQuery();
                MessageBox.Show("Salario actualizado.");
            }
        }

        private void Top10_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtCsv_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Nuxiba"].ConnectionString))
            {
                connection.Open();
                string query = "SELECT u.Login, CONCAT(u.Nombre, ' ', u.Paterno, ' ', u.Materno) AS NombreCompleto, e.Sueldo, e.FechaIngreso FROM usuarios u JOIN empleados e ON u.userId = e.userId";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();
                using (StreamWriter writer = new StreamWriter("usuarios.csv"))
                {
                    writer.WriteLine("Login,NombreCompleto,Sueldo,FechaIngreso");
                    while (reader.Read())
                    {
                        writer.WriteLine($"{reader["Login"]},{reader["NombreCompleto"]},{reader["Sueldo"]},{reader["FechaIngreso"]}");
                    }
                }
            }
        }

        private void btnListarTop10_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Nuxiba"].ConnectionString))
            {
                connection.Open();
                string query = "SELECT TOP 10 * FROM usuarios";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();
                Top10.Items.Clear();
                while (reader.Read())
                {
                    Top10.Items.Add($"{reader["Login"]} - {reader["Nombre"]}");
                }
            }
        }
    }
}
