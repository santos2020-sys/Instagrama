
namespace PROYECTO_FINAL
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnCargarUsuariosXML = new System.Windows.Forms.Button();
            this.btnCrearUsuario = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(193, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(357, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "BIENVENIDO AL SISTEMA INSTA";
            // 
            // btnCargarUsuariosXML
            // 
            this.btnCargarUsuariosXML.Location = new System.Drawing.Point(121, 129);
            this.btnCargarUsuariosXML.Name = "btnCargarUsuariosXML";
            this.btnCargarUsuariosXML.Size = new System.Drawing.Size(159, 78);
            this.btnCargarUsuariosXML.TabIndex = 2;
            this.btnCargarUsuariosXML.Text = "CARGAR USUARIOS";
            this.btnCargarUsuariosXML.UseVisualStyleBackColor = true;
            this.btnCargarUsuariosXML.Click += new System.EventHandler(this.btnCargarUsuariosXML_Click);
            // 
            // btnCrearUsuario
            // 
            this.btnCrearUsuario.Location = new System.Drawing.Point(466, 129);
            this.btnCrearUsuario.Name = "btnCrearUsuario";
            this.btnCrearUsuario.Size = new System.Drawing.Size(149, 78);
            this.btnCrearUsuario.TabIndex = 3;
            this.btnCrearUsuario.Text = "CREAR USUARIO";
            this.btnCrearUsuario.UseVisualStyleBackColor = true;
            this.btnCrearUsuario.Click += new System.EventHandler(this.btnCrearUsuario_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 270);
            this.Controls.Add(this.btnCrearUsuario);
            this.Controls.Add(this.btnCargarUsuariosXML);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            //this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCargarUsuariosXML;
        private System.Windows.Forms.Button btnCrearUsuario;
    }
}

