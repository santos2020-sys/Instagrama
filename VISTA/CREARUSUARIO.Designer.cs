
namespace PROYECTO_FINAL.VISTA
{
    partial class CREARUSUARIO
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNombre_Usuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dtimeFecha_Nacimiento = new System.Windows.Forms.DateTimePicker();
            this.txtNombre_completo = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_Crear_Uusario = new System.Windows.Forms.Button();
            this.btn_Regresar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombre_Usuario
            // 
            this.txtNombre_Usuario.Location = new System.Drawing.Point(146, 16);
            this.txtNombre_Usuario.Name = "txtNombre_Usuario";
            this.txtNombre_Usuario.Size = new System.Drawing.Size(164, 23);
            this.txtNombre_Usuario.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "NOMBRE DE USUARIO:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "NOMBRE COMPLETO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "FOTO DE PERFIL";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 308);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "FECHA DE NACIMIENTO";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(108, 127);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(202, 130);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(316, 234);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(58, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtimeFecha_Nacimiento
            // 
            this.dtimeFecha_Nacimiento.Location = new System.Drawing.Point(146, 308);
            this.dtimeFecha_Nacimiento.Name = "dtimeFecha_Nacimiento";
            this.dtimeFecha_Nacimiento.Size = new System.Drawing.Size(217, 23);
            this.dtimeFecha_Nacimiento.TabIndex = 7;
            // 
            // txtNombre_completo
            // 
            this.txtNombre_completo.Location = new System.Drawing.Point(138, 72);
            this.txtNombre_completo.Name = "txtNombre_completo";
            this.txtNombre_completo.Size = new System.Drawing.Size(172, 23);
            this.txtNombre_completo.TabIndex = 8;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 426);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "label5";
            this.label5.Visible = false;
            // 
            // btn_Crear_Uusario
            // 
            this.btn_Crear_Uusario.Location = new System.Drawing.Point(441, 307);
            this.btn_Crear_Uusario.Name = "btn_Crear_Uusario";
            this.btn_Crear_Uusario.Size = new System.Drawing.Size(127, 49);
            this.btn_Crear_Uusario.TabIndex = 10;
            this.btn_Crear_Uusario.Text = "CREAR USUARIO";
            this.btn_Crear_Uusario.UseVisualStyleBackColor = true;
            this.btn_Crear_Uusario.Click += new System.EventHandler(this.btn_Crear_Uusario_Click);
            // 
            // btn_Regresar
            // 
            this.btn_Regresar.Location = new System.Drawing.Point(604, 308);
            this.btn_Regresar.Name = "btn_Regresar";
            this.btn_Regresar.Size = new System.Drawing.Size(117, 48);
            this.btn_Regresar.TabIndex = 11;
            this.btn_Regresar.Text = "REGRESAR";
            this.btn_Regresar.UseVisualStyleBackColor = true;
            this.btn_Regresar.Click += new System.EventHandler(this.btn_Regresar_Click);
            // 
            // CREARUSUARIO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Regresar);
            this.Controls.Add(this.btn_Crear_Uusario);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNombre_completo);
            this.Controls.Add(this.dtimeFecha_Nacimiento);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNombre_Usuario);
            this.Name = "CREARUSUARIO";
            this.Text = "CREARUSUARIO";
            this.Load += new System.EventHandler(this.CREARUSUARIO_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre_Usuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dtimeFecha_Nacimiento;
        private System.Windows.Forms.TextBox txtNombre_completo;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_Crear_Uusario;
        private System.Windows.Forms.Button btn_Regresar;
    }
}