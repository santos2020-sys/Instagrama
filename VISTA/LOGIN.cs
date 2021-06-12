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
using System.IO;
using PROYECTO_FINAL.ARBOLES;
using PROYECTO_FINAL.DATOS;

namespace PROYECTO_FINAL.VISTA
{
    public partial class LOGIN : Form
    {
        ARBOLAVL arbol = new ARBOLAVL();
        public string ID_USUARIO;
        public string NOMBRE_USUARIO;
        public string NOMBRE_COMPLETO;
        public string IMAGEN_PERFIL;
        public DateTime CUMPLEANOS;
        string[] lineas = new string[200];
        StreamWriter archivo = new StreamWriter(@"C:\temp\bitacora.txt");
        public LOGIN()
        {
            InitializeComponent();
        }

        private void BTNLOGIN_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text != "")
            {
                DATOS_USUARIO AutenticarUsuario = new DATOS_USUARIO("","", CUMPLEANOS, txtUsuario.Text);
                DATOS_USUARIO usuarioautentico = (DATOS_USUARIO)arbol.buscar(AutenticarUsuario).DatoNodo();
                if (usuarioautentico != null)
                {
                    PERFIL perfil = new PERFIL();
                    this.Hide();
                    perfil.Show();
                    perfil.ObtenerUsuario(txtUsuario.Text, usuarioautentico.IMAGEN_PERFIL) ;
                }
                else
                {
                    MessageBox.Show("USAURIO NO EXISTE");
                }
            }
            else {
                MessageBox.Show("POR FAVOR INGRESE EL NOMBRE DEL USUARIO");
            }
        }

        public void CargarDatos() {
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
                lineas[i] = arbol.obteners();
                i++;
            }
            
            int x = lineas.Length;
            for (int w = 0; w < x; w++) {
                archivo.WriteLine(lineas[w]); 
            }
            archivo.Close();
        }
        public void traerDatosRegistrados(string id, string nombreus, string nombrefull, string rtufoto, DateTime cumple ) {
            ID_USUARIO = id;
            NOMBRE_USUARIO = nombreus;
            NOMBRE_COMPLETO = nombrefull;
            IMAGEN_PERFIL = rtufoto;
            CUMPLEANOS = cumple;
        }
        public void GUARDARREGISTRO() {
            if (NOMBRE_COMPLETO != " " && IMAGEN_PERFIL != " " && CUMPLEANOS != null)
            {
                XmlDocument doc = new XmlDocument();
                doc.Load("C:/temp/UserData.xml");
                XmlElement USER = doc.CreateElement("USER");
                USER.SetAttribute("ID", ID_USUARIO);
                XmlElement USERNAME = doc.CreateElement("USERNAME");
                USERNAME.InnerText = NOMBRE_USUARIO;
                USER.AppendChild(USERNAME);
                XmlElement FULLNAME = doc.CreateElement("FULLNAME");
                FULLNAME.InnerText = NOMBRE_USUARIO;
                USER.AppendChild(FULLNAME);
                XmlElement PROFILEIMAGE = doc.CreateElement("PROFILEIMAGE");
                PROFILEIMAGE.InnerText = IMAGEN_PERFIL;
                USER.AppendChild(PROFILEIMAGE);
                XmlElement BIRTHDATE = doc.CreateElement("BIRTHDATE");
                BIRTHDATE.InnerText = Convert.ToString(CUMPLEANOS);
                USER.AppendChild(BIRTHDATE);
                doc.DocumentElement.InsertAfter(USER, doc.DocumentElement.LastChild);
                doc.Save("C:/temp/UserData.xml");
            }
            else {
                Console.WriteLine("NO Registra ningun Usuario");
            }
        }


    }
}
