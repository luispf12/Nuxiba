namespace ExamenNuxiba
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.BtAgregar = new System.Windows.Forms.Button();
            this.txBLogin = new System.Windows.Forms.TextBox();
            this.txBNombre = new System.Windows.Forms.TextBox();
            this.txBPaterno = new System.Windows.Forms.TextBox();
            this.txBMaterno = new System.Windows.Forms.TextBox();
            this.txBSueldo = new System.Windows.Forms.TextBox();
            this.txBSueldoNuevo = new System.Windows.Forms.TextBox();
            this.txBLoginSueldo = new System.Windows.Forms.TextBox();
            this.btModificar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.BtCsv = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.Top10 = new System.Windows.Forms.ListBox();
            this.btnListarTop10 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txBSueldo);
            this.groupBox1.Controls.Add(this.txBMaterno);
            this.groupBox1.Controls.Add(this.txBPaterno);
            this.groupBox1.Controls.Add(this.txBNombre);
            this.groupBox1.Controls.Add(this.txBLogin);
            this.groupBox1.Controls.Add(this.BtAgregar);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(322, 486);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nuevo usuario";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txBSueldoNuevo);
            this.groupBox2.Controls.Add(this.txBLoginSueldo);
            this.groupBox2.Controls.Add(this.btModificar);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(328, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(322, 486);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Actualizar sueldo";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnListarTop10);
            this.groupBox3.Controls.Add(this.Top10);
            this.groupBox3.Location = new System.Drawing.Point(656, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(322, 486);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Top 10 Usuarios";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.BtCsv);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Location = new System.Drawing.Point(984, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(187, 486);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "CSV";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Paterno";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Materno";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 289);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Sueldo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 362);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Agregar";
            // 
            // BtAgregar
            // 
            this.BtAgregar.Location = new System.Drawing.Point(145, 360);
            this.BtAgregar.Name = "BtAgregar";
            this.BtAgregar.Size = new System.Drawing.Size(104, 37);
            this.BtAgregar.TabIndex = 6;
            this.BtAgregar.Text = "Agregar";
            this.BtAgregar.UseVisualStyleBackColor = true;
            this.BtAgregar.Click += new System.EventHandler(this.BtAgregar_Click);
            // 
            // txBLogin
            // 
            this.txBLogin.Location = new System.Drawing.Point(145, 27);
            this.txBLogin.Name = "txBLogin";
            this.txBLogin.Size = new System.Drawing.Size(132, 22);
            this.txBLogin.TabIndex = 7;
            this.txBLogin.TextChanged += new System.EventHandler(this.txBLogin_TextChanged);
            // 
            // txBNombre
            // 
            this.txBNombre.Location = new System.Drawing.Point(145, 80);
            this.txBNombre.Name = "txBNombre";
            this.txBNombre.Size = new System.Drawing.Size(132, 22);
            this.txBNombre.TabIndex = 8;
            this.txBNombre.TextChanged += new System.EventHandler(this.txBNombre_TextChanged);
            // 
            // txBPaterno
            // 
            this.txBPaterno.Location = new System.Drawing.Point(145, 145);
            this.txBPaterno.Name = "txBPaterno";
            this.txBPaterno.Size = new System.Drawing.Size(132, 22);
            this.txBPaterno.TabIndex = 9;
            this.txBPaterno.TextChanged += new System.EventHandler(this.txBPaterno_TextChanged);
            // 
            // txBMaterno
            // 
            this.txBMaterno.Location = new System.Drawing.Point(145, 203);
            this.txBMaterno.Name = "txBMaterno";
            this.txBMaterno.Size = new System.Drawing.Size(132, 22);
            this.txBMaterno.TabIndex = 10;
            this.txBMaterno.TextChanged += new System.EventHandler(this.txBMaterno_TextChanged);
            // 
            // txBSueldo
            // 
            this.txBSueldo.Location = new System.Drawing.Point(145, 286);
            this.txBSueldo.Name = "txBSueldo";
            this.txBSueldo.Size = new System.Drawing.Size(132, 22);
            this.txBSueldo.TabIndex = 11;
            this.txBSueldo.TextChanged += new System.EventHandler(this.txBSueldo_TextChanged);
            // 
            // txBSueldoNuevo
            // 
            this.txBSueldoNuevo.Location = new System.Drawing.Point(157, 229);
            this.txBSueldoNuevo.Name = "txBSueldoNuevo";
            this.txBSueldoNuevo.Size = new System.Drawing.Size(132, 22);
            this.txBSueldoNuevo.TabIndex = 17;
            this.txBSueldoNuevo.TextChanged += new System.EventHandler(this.txBSueldoNuevo_TextChanged);
            // 
            // txBLoginSueldo
            // 
            this.txBLoginSueldo.Location = new System.Drawing.Point(157, 146);
            this.txBLoginSueldo.Name = "txBLoginSueldo";
            this.txBLoginSueldo.Size = new System.Drawing.Size(132, 22);
            this.txBLoginSueldo.TabIndex = 16;
            this.txBLoginSueldo.TextChanged += new System.EventHandler(this.txBLoginSueldo_TextChanged);
            // 
            // btModificar
            // 
            this.btModificar.Location = new System.Drawing.Point(171, 295);
            this.btModificar.Name = "btModificar";
            this.btModificar.Size = new System.Drawing.Size(104, 37);
            this.btModificar.TabIndex = 15;
            this.btModificar.Text = "Modificar";
            this.btModificar.UseVisualStyleBackColor = true;
            this.btModificar.Click += new System.EventHandler(this.btModificar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 305);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Actualizar";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(34, 232);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 16);
            this.label8.TabIndex = 13;
            this.label8.Text = "Sueldo";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(34, 152);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 16);
            this.label9.TabIndex = 12;
            this.label9.Text = "Login";
            // 
            // BtCsv
            // 
            this.BtCsv.Location = new System.Drawing.Point(46, 152);
            this.BtCsv.Name = "BtCsv";
            this.BtCsv.Size = new System.Drawing.Size(104, 37);
            this.BtCsv.TabIndex = 17;
            this.BtCsv.Text = "Generar CSV";
            this.BtCsv.UseVisualStyleBackColor = true;
            this.BtCsv.Click += new System.EventHandler(this.BtCsv_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(82, 80);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 16);
            this.label10.TabIndex = 16;
            this.label10.Text = "CSV";
            // 
            // Top10
            // 
            this.Top10.FormattingEnabled = true;
            this.Top10.ItemHeight = 16;
            this.Top10.Location = new System.Drawing.Point(22, 34);
            this.Top10.Name = "Top10";
            this.Top10.Size = new System.Drawing.Size(281, 356);
            this.Top10.TabIndex = 0;
            this.Top10.SelectedIndexChanged += new System.EventHandler(this.Top10_SelectedIndexChanged);
            // 
            // btnListarTop10
            // 
            this.btnListarTop10.Location = new System.Drawing.Point(71, 422);
            this.btnListarTop10.Name = "btnListarTop10";
            this.btnListarTop10.Size = new System.Drawing.Size(153, 36);
            this.btnListarTop10.TabIndex = 1;
            this.btnListarTop10.Text = "Generar Top 10";
            this.btnListarTop10.UseVisualStyleBackColor = true;
            this.btnListarTop10.Click += new System.EventHandler(this.btnListarTop10_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1183, 521);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Nuxiba";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txBSueldo;
        private System.Windows.Forms.TextBox txBMaterno;
        private System.Windows.Forms.TextBox txBPaterno;
        private System.Windows.Forms.TextBox txBNombre;
        private System.Windows.Forms.TextBox txBLogin;
        private System.Windows.Forms.Button BtAgregar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txBSueldoNuevo;
        private System.Windows.Forms.TextBox txBLoginSueldo;
        private System.Windows.Forms.Button btModificar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button BtCsv;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListBox Top10;
        private System.Windows.Forms.Button btnListarTop10;
    }
}

