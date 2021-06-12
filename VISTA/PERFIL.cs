/*      -- TRABAJO FINAL EN GRUPO: -- 
 *  Santos Ismael Pinzón García (0900-19-4909) 
 *  Samuel Rodas Aroche (0900-19-6150) 
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using PROYECTO_FINAL.TABLAHASH;
using PROYECTO_FINAL.DATOS;
namespace PROYECTO_FINAL.VISTA
{
    public partial class PERFIL : Form
    {
        TABLADEDISPERSIONCL tablah = new TABLADEDISPERSIONCL();
        LISTAS tablahH = new LISTAS();
        public static string Usuario_Loggeado;
        public static string Imagen_Loogeado;
        public string ID_USUARIO = "";
        public string SEGUIDO = "";
        public string SEGUIDORES = "";
        public PERFIL()
        {
            InitializeComponent();
        }
        public void ObtenerUsuario(string usuario, string ruta_imagen) {
            Usuario_Loggeado = usuario;
            Imagen_Loogeado = ruta_imagen;
            label1.Text = Usuario_Loggeado;
            pictureBox1.ImageLocation = Imagen_Loogeado;
        }
        private void PERFIL_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CargarSeguidores();
        }
        public void CargarSeguidores() {
            XmlDocument doc = new XmlDocument();
            doc.Load("C:/temp/FollowerFollowingData.xml");
            XmlElement root = doc.DocumentElement;
            XmlNodeList SEGUIDo = root.GetElementsByTagName("FOLLOWER");
            XmlNodeList SEGUIDOREs = root.GetElementsByTagName("FOLLOWING");
            XmlNodeList Cumpleanos = root.GetElementsByTagName("BIRTHDATE");
            int i = 0;
            foreach (XmlNode node in doc.DocumentElement.ChildNodes)
            {
                //String id = node.Attributes["ID"].Value;
                ID_USUARIO = SEGUIDo[i].InnerText;
                SEGUIDO = SEGUIDo[i].InnerText;
                SEGUIDORES = SEGUIDOREs[i].InnerText;
                tablah.Insertar(new SEGUIDOR(SEGUIDO, SEGUIDORES),ID_USUARIO);
                i++;
            }
            if (label1.Text != null)
            {
               
                    listBox1.Items.Add(tablah.Buscar(label1.Text));
                

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Visible = false;
            LOGIN frmLogin = new LOGIN();
            frmLogin.CargarDatos();
            frmLogin.Show();
        }
    }
}
