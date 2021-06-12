/*      -- TRABAJO FINAL EN GRUPO: -- 
 *  Santos Ismael Pinzón García (0900-19-4909) 
 *  Samuel Rodas Aroche (0900-19-6150) 
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PROYECTO_FINAL.ARBOLES;
using PROYECTO_FINAL.DATOS;
using System.IO;
using System.Xml;
using PROYECTO_FINAL.VISTA;

namespace PROYECTO_FINAL
{
    public partial class Form1 : Form
    {

        ARBOLAVL arbol = new ARBOLAVL();
        DATOS_USUARIO Listado = new DATOS_USUARIO();
        string i = "";
        public string ID_USUARIO = "";
        public string NOMBRE_USUARIO = "";
        // public string 
        public string IMAGEN_PERFIL = "";
        public DateTime CUMPLEANOS;
        public Form1()
        {
            InitializeComponent();
        }
        private void btnCargarUsuariosXML_Click(object sender, EventArgs e)
        {
            CargarDatos();
            this.Visible = false;
            LOGIN frmLogin = new LOGIN();
            frmLogin.CargarDatos();
            frmLogin.Show();
            
        }
        public void CargarDatos()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("C:/temp/UserData.xml");
            XmlElement root = doc.DocumentElement;
            XmlNodeList Nombre_Usuario = root.GetElementsByTagName("USERNAME");
            XmlNodeList Imagen_Perfil = root.GetElementsByTagName("PROFILEIMAGE");
            XmlNodeList Cumpleanos = root.GetElementsByTagName("BIRTHDATE");
            int i = 0;
            foreach (XmlNode node in doc.DocumentElement.ChildNodes)
            {
                String id = node.Attributes["ID"].Value;
                ID_USUARIO = id;
                NOMBRE_USUARIO = Nombre_Usuario[i].InnerText;
                IMAGEN_PERFIL = Imagen_Perfil[i].InnerText;
                CUMPLEANOS = Convert.ToDateTime(Cumpleanos[i].InnerText);
                arbol.InsertarDato(new DATOS_USUARIO(ID_USUARIO, IMAGEN_PERFIL, CUMPLEANOS, NOMBRE_USUARIO));
                i++;
            }
        }
        private void btnCrearUsuario_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            CREARUSUARIO frmLogin = new CREARUSUARIO();
            frmLogin.Show();
        }
    } 
}
