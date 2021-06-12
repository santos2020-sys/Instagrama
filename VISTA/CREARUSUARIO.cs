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

namespace PROYECTO_FINAL.VISTA
{
    public partial class CREARUSUARIO : Form
    {
        Random numeroIdRandon = new Random();
        public CREARUSUARIO()
        {
            InitializeComponent();
        }

        private void CREARUSUARIO_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                label5.Text = openFileDialog1.FileName;
                pictureBox1.ImageLocation = label5.Text;
            }
            else {
                MessageBox.Show("POR FAVOR ELIJA UNA FOTO CON FORMATO .JPG / .PNG / .ICON");
            }

        }

        private void btn_Crear_Uusario_Click(object sender, EventArgs e)
        {
            string id = Convert.ToString(numeroIdRandon.Next(100,900));
            if (txtNombre_completo.Text != "" && txtNombre_Usuario.Text != ""&&dtimeFecha_Nacimiento.Value != null && label5.Text !="") { 
            this.Visible = false;
                LOGIN frmLogin = new LOGIN();
                frmLogin.traerDatosRegistrados(id, txtNombre_Usuario.Text, txtNombre_completo.Text, label5.Text, dtimeFecha_Nacimiento.Value);
                frmLogin.GUARDARREGISTRO();
                frmLogin.CargarDatos();
                frmLogin.Show();
            }
        }

        private void btn_Regresar_Click(object sender, EventArgs e)
        {
            Form1 frmInicio = new Form1();
            this.Visible = false;
            frmInicio.Show();
        }
    }
}
