using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Data.SqlClient;

namespace Conexion_Encryptada_SQLServer_SERPROINTEC.Conexion
{
    public partial class ConexionManual : Form
    {
        
        private Librerias.AES aes = new Librerias.AES();
        int idtabla;
        public ConexionManual()
        {
            InitializeComponent();
        }
        //ENCRYPTACION 
        public void SavetoXML(Object dbcnString)
        { 
            XmlDocument doc = new XmlDocument();
            doc.Load("ConnectionString.xml");
            XmlElement root = doc.DocumentElement;
            root.Attributes[0].Value = Convert.ToString(dbcnString);
            XmlTextWriter writer = new XmlTextWriter("ConnectionString.xml", null);
            writer.Formatting = Formatting.Indented;
            doc.Save(writer);
            writer.Close();
        }
        //DESENCRYPTACION
        string dbcnString;
        public void ReadfromXML() 
        {
            try
            {
                XmlDocument doc = new XmlDocument();
                doc.Load("ConnectionString.xml");
                XmlElement root = doc.DocumentElement;
                dbcnString = root.Attributes[0].Value;
                txtCnString.Text = (aes.Decrypt(dbcnString, Librerias.Desencryptacion.appPwdUnique, int.Parse("256")));
            }
            catch (System.Security.Cryptography.CryptographicException ex)
            {

            }
        }
        private void ConexionManual_Load(object sender, EventArgs e)
        {
          ReadfromXML();            
        }

        private void Btn_Conexion_Click(object sender, EventArgs e)
        {
            //SavetoXML(aes.Encrypt(txtCnString.Text,Librerias.Desencryptacion.appPwdUnique, int.Parse("256")));

            comprobar_conexion();
        }
        private void comprobar_conexion() 
        {
            SqlConnection con = new SqlConnection();
            try
            {
                con.ConnectionString = txtCnString.Text;    
                SqlCommand com = new SqlCommand ("Select * from Usuario", con);
                con.Open();
                idtabla = Convert.ToInt32(com.ExecuteScalar());
                con.Close();
                SavetoXML(aes.Encrypt(txtCnString.Text, Librerias.Desencryptacion.appPwdUnique, int.Parse("256")));
                MessageBox.Show("Coneccion realizada correctamente", "Conexion", MessageBoxButtons.OK,MessageBoxIcon.Information);
                Application.Exit();
            } 
            catch(Exception ex)
            {
                con.Close();
                MessageBox.Show("Sin Conexion", "Conexion Fallida",MessageBoxButtons.OK, MessageBoxIcon.Error);
               // MessageBox.Show(ex.Message);
            }
        }
    }
}
