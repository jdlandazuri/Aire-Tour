namespace Aire_Tour
{
    partial class Estudiante
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textidEs = new System.Windows.Forms.TextBox();
            this.textNombreEs = new System.Windows.Forms.TextBox();
            this.textApellidoEs = new System.Windows.Forms.TextBox();
            this.textCurso = new System.Windows.Forms.TextBox();
            this.textClave = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Identificación:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombres:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apellidos:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Curso:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Clave de Ingreso:";
            // 
            // textidEs
            // 
            this.textidEs.Location = new System.Drawing.Point(143, 17);
            this.textidEs.Name = "textidEs";
            this.textidEs.Size = new System.Drawing.Size(145, 20);
            this.textidEs.TabIndex = 5;
            // 
            // textNombreEs
            // 
            this.textNombreEs.Location = new System.Drawing.Point(143, 50);
            this.textNombreEs.Name = "textNombreEs";
            this.textNombreEs.Size = new System.Drawing.Size(145, 20);
            this.textNombreEs.TabIndex = 6;
            this.textNombreEs.TextChanged += new System.EventHandler(this.textNombreEs_TextChanged);
            // 
            // textApellidoEs
            // 
            this.textApellidoEs.Location = new System.Drawing.Point(143, 88);
            this.textApellidoEs.Name = "textApellidoEs";
            this.textApellidoEs.Size = new System.Drawing.Size(145, 20);
            this.textApellidoEs.TabIndex = 7;
            // 
            // textCurso
            // 
            this.textCurso.Location = new System.Drawing.Point(143, 121);
            this.textCurso.Name = "textCurso";
            this.textCurso.Size = new System.Drawing.Size(145, 20);
            this.textCurso.TabIndex = 8;
            this.textCurso.Text = "Estructura de Datos";
            // 
            // textClave
            // 
            this.textClave.Location = new System.Drawing.Point(143, 160);
            this.textClave.Name = "textClave";
            this.textClave.PasswordChar = '*';
            this.textClave.Size = new System.Drawing.Size(145, 20);
            this.textClave.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(128, 216);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Ingresar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Estudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 291);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textClave);
            this.Controls.Add(this.textCurso);
            this.Controls.Add(this.textApellidoEs);
            this.Controls.Add(this.textNombreEs);
            this.Controls.Add(this.textidEs);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Estudiante";
            this.Text = "AireTour";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textidEs;
        private System.Windows.Forms.TextBox textNombreEs;
        private System.Windows.Forms.TextBox textApellidoEs;
        private System.Windows.Forms.TextBox textCurso;
        private System.Windows.Forms.TextBox textClave;
        private System.Windows.Forms.Button button1;
    }
}