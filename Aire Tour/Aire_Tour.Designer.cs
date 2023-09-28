namespace Aire_Tour
{
    partial class Aire_Tour
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textid = new System.Windows.Forms.TextBox();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.textApellido = new System.Windows.Forms.TextBox();
            this.comboGenero = new System.Windows.Forms.ComboBox();
            this.comboEstrato = new System.Windows.Forms.ComboBox();
            this.comboOrigen = new System.Windows.Forms.ComboBox();
            this.comboDestino = new System.Windows.Forms.ComboBox();
            this.comboDia = new System.Windows.Forms.ComboBox();
            this.comboClase = new System.Windows.Forms.ComboBox();
            this.IngresarDatos = new System.Windows.Forms.Button();
            this.LimpiarDatos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Identificación:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(319, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apellido:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Genero:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(319, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Estrato:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ciudad de Origen:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(269, 164);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Ciudad de Destino:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(79, 189);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Clase:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(301, 189);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Día de viaje:";
            // 
            // textid
            // 
            this.textid.Location = new System.Drawing.Point(131, 54);
            this.textid.Name = "textid";
            this.textid.Size = new System.Drawing.Size(100, 20);
            this.textid.TabIndex = 9;
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(131, 84);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(100, 20);
            this.textNombre.TabIndex = 10;
            // 
            // textApellido
            // 
            this.textApellido.Location = new System.Drawing.Point(375, 84);
            this.textApellido.Name = "textApellido";
            this.textApellido.Size = new System.Drawing.Size(100, 20);
            this.textApellido.TabIndex = 11;
            // 
            // comboGenero
            // 
            this.comboGenero.FormattingEnabled = true;
            this.comboGenero.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.comboGenero.Location = new System.Drawing.Point(131, 120);
            this.comboGenero.Name = "comboGenero";
            this.comboGenero.Size = new System.Drawing.Size(121, 21);
            this.comboGenero.TabIndex = 12;
            this.comboGenero.SelectedIndexChanged += new System.EventHandler(this.comboGenero_SelectedIndexChanged);
            // 
            // comboEstrato
            // 
            this.comboEstrato.FormattingEnabled = true;
            this.comboEstrato.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.comboEstrato.Location = new System.Drawing.Point(375, 120);
            this.comboEstrato.Name = "comboEstrato";
            this.comboEstrato.Size = new System.Drawing.Size(121, 21);
            this.comboEstrato.TabIndex = 13;
            this.comboEstrato.SelectedIndexChanged += new System.EventHandler(this.comboEstrato_SelectedIndexChanged);
            // 
            // comboOrigen
            // 
            this.comboOrigen.FormattingEnabled = true;
            this.comboOrigen.Items.AddRange(new object[] {
            "Cúcuta",
            "Bucaramanga",
            "Medellín",
            "Bogotá",
            "Cali",
            "Cartagena",
            "Villavicencio",
            "Pasto",
            "Neiva",
            "Ibagué",
            "Florencia",
            "Pitalito"});
            this.comboOrigen.Location = new System.Drawing.Point(131, 156);
            this.comboOrigen.Name = "comboOrigen";
            this.comboOrigen.Size = new System.Drawing.Size(121, 21);
            this.comboOrigen.TabIndex = 14;
            // 
            // comboDestino
            // 
            this.comboDestino.FormattingEnabled = true;
            this.comboDestino.Items.AddRange(new object[] {
            "Bogotá",
            "Medellín",
            "Florencia",
            "Pitalito"});
            this.comboDestino.Location = new System.Drawing.Point(372, 156);
            this.comboDestino.Name = "comboDestino";
            this.comboDestino.Size = new System.Drawing.Size(121, 21);
            this.comboDestino.TabIndex = 15;
            // 
            // comboDia
            // 
            this.comboDia.FormattingEnabled = true;
            this.comboDia.Items.AddRange(new object[] {
            "Lunes",
            "Martes",
            "Miercoles",
            "Jueves",
            "Viernes",
            "Sábado",
            "Domingo"});
            this.comboDia.Location = new System.Drawing.Point(375, 186);
            this.comboDia.Name = "comboDia";
            this.comboDia.Size = new System.Drawing.Size(121, 21);
            this.comboDia.TabIndex = 16;
            // 
            // comboClase
            // 
            this.comboClase.FormattingEnabled = true;
            this.comboClase.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.comboClase.Location = new System.Drawing.Point(131, 186);
            this.comboClase.Name = "comboClase";
            this.comboClase.Size = new System.Drawing.Size(121, 21);
            this.comboClase.TabIndex = 17;
            // 
            // IngresarDatos
            // 
            this.IngresarDatos.Location = new System.Drawing.Point(177, 234);
            this.IngresarDatos.Name = "IngresarDatos";
            this.IngresarDatos.Size = new System.Drawing.Size(75, 39);
            this.IngresarDatos.TabIndex = 18;
            this.IngresarDatos.Text = "Ingresar Datos";
            this.IngresarDatos.UseVisualStyleBackColor = true;
            this.IngresarDatos.Click += new System.EventHandler(this.IngresarDatos_Click);
            // 
            // LimpiarDatos
            // 
            this.LimpiarDatos.Location = new System.Drawing.Point(322, 234);
            this.LimpiarDatos.Name = "LimpiarDatos";
            this.LimpiarDatos.Size = new System.Drawing.Size(75, 39);
            this.LimpiarDatos.TabIndex = 19;
            this.LimpiarDatos.Text = "Limpiar Datos";
            this.LimpiarDatos.UseVisualStyleBackColor = true;
            this.LimpiarDatos.Click += new System.EventHandler(this.LimpiarDatos_Click);
            // 
            // Aire_Tour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 323);
            this.Controls.Add(this.LimpiarDatos);
            this.Controls.Add(this.IngresarDatos);
            this.Controls.Add(this.comboClase);
            this.Controls.Add(this.comboDia);
            this.Controls.Add(this.comboDestino);
            this.Controls.Add(this.comboOrigen);
            this.Controls.Add(this.comboEstrato);
            this.Controls.Add(this.comboGenero);
            this.Controls.Add(this.textApellido);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.textid);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Aire_Tour";
            this.Text = "Aire_Tour";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textid;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.TextBox textApellido;
        private System.Windows.Forms.ComboBox comboGenero;
        private System.Windows.Forms.ComboBox comboEstrato;
        private System.Windows.Forms.ComboBox comboOrigen;
        private System.Windows.Forms.ComboBox comboDestino;
        private System.Windows.Forms.ComboBox comboDia;
        private System.Windows.Forms.ComboBox comboClase;
        private System.Windows.Forms.Button IngresarDatos;
        private System.Windows.Forms.Button LimpiarDatos;
    }
}

