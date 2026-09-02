namespace Preferencias.A
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
            label1 = new Label();
            txtnombre = new TextBox();
            groupBox1 = new GroupBox();
            chkLectura = new CheckBox();
            chkProgramacion = new CheckBox();
            chkArte = new CheckBox();
            chkMusica = new CheckBox();
            chkDeportes = new CheckBox();
            groupBox2 = new GroupBox();
            rdEnlinea = new RadioButton();
            rdHibrida = new RadioButton();
            rdPresencial = new RadioButton();
            btn_resumen = new Button();
            btn_limpiar = new Button();
            txtresumen = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Palatino Linotype", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 35);
            label1.Name = "label1";
            label1.Size = new Size(212, 24);
            label1.TabIndex = 0;
            label1.Text = "Nombre del Estudiante:";
            label1.Click += label1_Click;
            // 
            // txtnombre
            // 
            txtnombre.Location = new Point(238, 35);
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new Size(202, 27);
            txtnombre.TabIndex = 1;
            txtnombre.TextChanged += textBox1_TextChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(chkLectura);
            groupBox1.Controls.Add(chkProgramacion);
            groupBox1.Controls.Add(chkArte);
            groupBox1.Controls.Add(chkMusica);
            groupBox1.Controls.Add(chkDeportes);
            groupBox1.Location = new Point(39, 88);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(314, 184);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Actividades favoritas (puedes elegir varias)";
            // 
            // chkLectura
            // 
            chkLectura.AutoSize = true;
            chkLectura.Location = new Point(9, 144);
            chkLectura.Name = "chkLectura";
            chkLectura.Size = new Size(79, 24);
            chkLectura.TabIndex = 4;
            chkLectura.Text = "Lectura";
            chkLectura.UseVisualStyleBackColor = true;
            // 
            // chkProgramacion
            // 
            chkProgramacion.AutoSize = true;
            chkProgramacion.Location = new Point(9, 114);
            chkProgramacion.Name = "chkProgramacion";
            chkProgramacion.Size = new Size(124, 24);
            chkProgramacion.TabIndex = 3;
            chkProgramacion.Text = "Programación";
            chkProgramacion.UseVisualStyleBackColor = true;
            // 
            // chkArte
            // 
            chkArte.AutoSize = true;
            chkArte.Location = new Point(9, 87);
            chkArte.Name = "chkArte";
            chkArte.Size = new Size(59, 24);
            chkArte.TabIndex = 2;
            chkArte.Text = "Arte";
            chkArte.UseVisualStyleBackColor = true;
            chkArte.CheckedChanged += checkBox3_CheckedChanged;
            // 
            // chkMusica
            // 
            chkMusica.AutoSize = true;
            chkMusica.Location = new Point(9, 60);
            chkMusica.Name = "chkMusica";
            chkMusica.Size = new Size(77, 24);
            chkMusica.TabIndex = 1;
            chkMusica.Text = "Música";
            chkMusica.UseVisualStyleBackColor = true;
            // 
            // chkDeportes
            // 
            chkDeportes.AutoSize = true;
            chkDeportes.Location = new Point(9, 32);
            chkDeportes.Name = "chkDeportes";
            chkDeportes.Size = new Size(92, 24);
            chkDeportes.TabIndex = 0;
            chkDeportes.Text = "Deportes";
            chkDeportes.UseVisualStyleBackColor = true;
            chkDeportes.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(rdEnlinea);
            groupBox2.Controls.Add(rdHibrida);
            groupBox2.Controls.Add(rdPresencial);
            groupBox2.Location = new Point(410, 88);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(314, 184);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = " Modalidad preferida (elige una)";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // rdEnlinea
            // 
            rdEnlinea.AutoSize = true;
            rdEnlinea.Location = new Point(22, 130);
            rdEnlinea.Name = "rdEnlinea";
            rdEnlinea.Size = new Size(85, 24);
            rdEnlinea.TabIndex = 2;
            rdEnlinea.TabStop = true;
            rdEnlinea.Text = "En Linea";
            rdEnlinea.UseVisualStyleBackColor = true;
            rdEnlinea.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // rdHibrida
            // 
            rdHibrida.AutoSize = true;
            rdHibrida.Location = new Point(22, 87);
            rdHibrida.Name = "rdHibrida";
            rdHibrida.Size = new Size(80, 24);
            rdHibrida.TabIndex = 1;
            rdHibrida.TabStop = true;
            rdHibrida.Text = "Hibrida";
            rdHibrida.UseVisualStyleBackColor = true;
            rdHibrida.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // rdPresencial
            // 
            rdPresencial.AutoSize = true;
            rdPresencial.Location = new Point(22, 43);
            rdPresencial.Name = "rdPresencial";
            rdPresencial.Size = new Size(96, 24);
            rdPresencial.TabIndex = 0;
            rdPresencial.TabStop = true;
            rdPresencial.Text = "Presencial";
            rdPresencial.UseVisualStyleBackColor = true;
            // 
            // btn_resumen
            // 
            btn_resumen.Location = new Point(186, 299);
            btn_resumen.Name = "btn_resumen";
            btn_resumen.Size = new Size(167, 29);
            btn_resumen.TabIndex = 4;
            btn_resumen.Text = "Mostrar Resumen";
            btn_resumen.UseVisualStyleBackColor = true;
            btn_resumen.Click += button1_Click;
            // 
            // btn_limpiar
            // 
            btn_limpiar.Location = new Point(387, 299);
            btn_limpiar.Name = "btn_limpiar";
            btn_limpiar.Size = new Size(167, 29);
            btn_limpiar.TabIndex = 5;
            btn_limpiar.Text = "Limpiar";
            btn_limpiar.UseVisualStyleBackColor = true;
            btn_limpiar.Click += button2_Click;
            // 
            // txtresumen
            // 
            txtresumen.Location = new Point(22, 350);
            txtresumen.Multiline = true;
            txtresumen.Name = "txtresumen";
            txtresumen.ReadOnly = true;
            txtresumen.ScrollBars = ScrollBars.Vertical;
            txtresumen.Size = new Size(663, 145);
            txtresumen.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(755, 531);
            Controls.Add(txtresumen);
            Controls.Add(btn_limpiar);
            Controls.Add(btn_resumen);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(txtnombre);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Preferencias de Actividades";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtnombre;
        private GroupBox groupBox1;
        private CheckBox chkLectura;
        private CheckBox chkProgramacion;
        private CheckBox chkArte;
        private CheckBox chkMusica;
        private CheckBox chkDeportes;
        private GroupBox groupBox2;
        private RadioButton rdEnlinea;
        private RadioButton rdHibrida;
        private RadioButton rdPresencial;
        private Button btn_resumen;
        private Button btn_limpiar;
        private TextBox txtresumen;
    }
}
