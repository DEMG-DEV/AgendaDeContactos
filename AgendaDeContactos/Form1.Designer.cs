namespace AgendaDeContactos
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPuesto = new System.Windows.Forms.TextBox();
            this.contactoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsDetalleContactoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsDetalleContacto = new AgendaDeContactos.dsDetalleContacto();
            this.label5 = new System.Windows.Forms.Label();
            this.txtOrganizacion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtApeMaterno = new System.Windows.Forms.TextBox();
            this.txtApePaterno = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbTratamiento = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtTelMovil = new System.Windows.Forms.TextBox();
            this.txtTelFax = new System.Windows.Forms.TextBox();
            this.txtTelParticular = new System.Windows.Forms.TextBox();
            this.txtTelTrabajo = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.comboBox7 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idContactoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tratamientoContactoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreContactoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apePaternoContactoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apeMaternoContactoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.organizacionContactoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.puestoContactoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.contactoTableAdapter = new AgendaDeContactos.dsDetalleContactoTableAdapters.contactoTableAdapter();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.dsTelefonos = new AgendaDeContactos.dsTelefonos();
            this.telefonosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.telefonosTableAdapter = new AgendaDeContactos.dsTelefonosTableAdapters.telefonosTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contactoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDetalleContactoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDetalleContacto)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTelefonos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.telefonosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtPuesto);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtOrganizacion);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtApeMaterno);
            this.groupBox1.Controls.Add(this.txtApePaterno);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbTratamiento);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(860, 134);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Contacto";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(814, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Puesto";
            // 
            // txtPuesto
            // 
            this.txtPuesto.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contactoBindingSource, "puestoContacto", true));
            this.txtPuesto.Location = new System.Drawing.Point(383, 83);
            this.txtPuesto.Name = "txtPuesto";
            this.txtPuesto.ReadOnly = true;
            this.txtPuesto.Size = new System.Drawing.Size(471, 20);
            this.txtPuesto.TabIndex = 11;
            // 
            // contactoBindingSource
            // 
            this.contactoBindingSource.DataMember = "contacto";
            this.contactoBindingSource.DataSource = this.dsDetalleContactoBindingSource;
            // 
            // dsDetalleContactoBindingSource
            // 
            this.dsDetalleContactoBindingSource.DataSource = this.dsDetalleContacto;
            this.dsDetalleContactoBindingSource.Position = 0;
            // 
            // dsDetalleContacto
            // 
            this.dsDetalleContacto.DataSetName = "dsDetalleContacto";
            this.dsDetalleContacto.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(297, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Organizacion";
            // 
            // txtOrganizacion
            // 
            this.txtOrganizacion.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contactoBindingSource, "organizacionContacto", true));
            this.txtOrganizacion.Location = new System.Drawing.Point(7, 83);
            this.txtOrganizacion.Name = "txtOrganizacion";
            this.txtOrganizacion.ReadOnly = true;
            this.txtOrganizacion.Size = new System.Drawing.Size(359, 20);
            this.txtOrganizacion.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(768, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Apellido Materno";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(544, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Apellido Paterno";
            // 
            // txtApeMaterno
            // 
            this.txtApeMaterno.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contactoBindingSource, "apeMaternoContacto", true));
            this.txtApeMaterno.Location = new System.Drawing.Point(644, 19);
            this.txtApeMaterno.Name = "txtApeMaterno";
            this.txtApeMaterno.ReadOnly = true;
            this.txtApeMaterno.Size = new System.Drawing.Size(210, 20);
            this.txtApeMaterno.TabIndex = 6;
            // 
            // txtApePaterno
            // 
            this.txtApePaterno.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contactoBindingSource, "apePaternoContacto", true));
            this.txtApePaterno.Location = new System.Drawing.Point(418, 19);
            this.txtApePaterno.Name = "txtApePaterno";
            this.txtApePaterno.ReadOnly = true;
            this.txtApePaterno.Size = new System.Drawing.Size(210, 20);
            this.txtApePaterno.TabIndex = 5;
            // 
            // txtNombre
            // 
            this.txtNombre.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contactoBindingSource, "nombreContacto", true));
            this.txtNombre.Location = new System.Drawing.Point(192, 19);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ReadOnly = true;
            this.txtNombre.Size = new System.Drawing.Size(210, 20);
            this.txtNombre.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(347, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre(s)";
            // 
            // cbTratamiento
            // 
            this.cbTratamiento.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.contactoBindingSource, "tratamientoContacto", true));
            this.cbTratamiento.Enabled = false;
            this.cbTratamiento.FormattingEnabled = true;
            this.cbTratamiento.Items.AddRange(new object[] {
            "Sr.",
            "Sra.",
            "Srita."});
            this.cbTratamiento.Location = new System.Drawing.Point(7, 20);
            this.cbTratamiento.Name = "cbTratamiento";
            this.cbTratamiento.Size = new System.Drawing.Size(139, 21);
            this.cbTratamiento.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tratamiento";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtTelMovil);
            this.groupBox2.Controls.Add(this.txtTelFax);
            this.groupBox2.Controls.Add(this.txtTelParticular);
            this.groupBox2.Controls.Add(this.txtTelTrabajo);
            this.groupBox2.Location = new System.Drawing.Point(13, 154);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(402, 139);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Numeros de Telefono";
            // 
            // txtTelMovil
            // 
            this.txtTelMovil.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.telefonosBindingSource, "movilTelefono", true));
            this.txtTelMovil.Location = new System.Drawing.Point(192, 104);
            this.txtTelMovil.Name = "txtTelMovil";
            this.txtTelMovil.ReadOnly = true;
            this.txtTelMovil.Size = new System.Drawing.Size(204, 20);
            this.txtTelMovil.TabIndex = 7;
            // 
            // txtTelFax
            // 
            this.txtTelFax.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.telefonosBindingSource, "faxTelefono", true));
            this.txtTelFax.Location = new System.Drawing.Point(192, 77);
            this.txtTelFax.Name = "txtTelFax";
            this.txtTelFax.ReadOnly = true;
            this.txtTelFax.Size = new System.Drawing.Size(204, 20);
            this.txtTelFax.TabIndex = 5;
            // 
            // txtTelParticular
            // 
            this.txtTelParticular.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.telefonosBindingSource, "particularTelefono", true));
            this.txtTelParticular.Location = new System.Drawing.Point(192, 48);
            this.txtTelParticular.Name = "txtTelParticular";
            this.txtTelParticular.ReadOnly = true;
            this.txtTelParticular.Size = new System.Drawing.Size(204, 20);
            this.txtTelParticular.TabIndex = 3;
            // 
            // txtTelTrabajo
            // 
            this.txtTelTrabajo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.telefonosBindingSource, "trabajoTelefono", true));
            this.txtTelTrabajo.Location = new System.Drawing.Point(192, 20);
            this.txtTelTrabajo.Name = "txtTelTrabajo";
            this.txtTelTrabajo.ReadOnly = true;
            this.txtTelTrabajo.Size = new System.Drawing.Size(204, 20);
            this.txtTelTrabajo.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.textBox13);
            this.groupBox3.Controls.Add(this.textBox12);
            this.groupBox3.Controls.Add(this.textBox11);
            this.groupBox3.Controls.Add(this.textBox10);
            this.groupBox3.Controls.Add(this.comboBox6);
            this.groupBox3.Location = new System.Drawing.Point(422, 154);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(451, 139);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Internet";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 106);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Direccion de IM";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Pagina Web";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Mostrar Como";
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(194, 103);
            this.textBox13.Name = "textBox13";
            this.textBox13.ReadOnly = true;
            this.textBox13.Size = new System.Drawing.Size(251, 20);
            this.textBox13.TabIndex = 4;
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(194, 76);
            this.textBox12.Name = "textBox12";
            this.textBox12.ReadOnly = true;
            this.textBox12.Size = new System.Drawing.Size(251, 20);
            this.textBox12.TabIndex = 3;
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(194, 48);
            this.textBox11.Name = "textBox11";
            this.textBox11.ReadOnly = true;
            this.textBox11.Size = new System.Drawing.Size(251, 20);
            this.textBox11.TabIndex = 2;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(194, 20);
            this.textBox10.Name = "textBox10";
            this.textBox10.ReadOnly = true;
            this.textBox10.Size = new System.Drawing.Size(251, 20);
            this.textBox10.TabIndex = 1;
            // 
            // comboBox6
            // 
            this.comboBox6.Enabled = false;
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Items.AddRange(new object[] {
            "Correo electrónico",
            "Correo electrónico",
            "Correo electrónico",
            "Correo electrónico"});
            this.comboBox6.Location = new System.Drawing.Point(9, 20);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(170, 21);
            this.comboBox6.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBox14);
            this.groupBox4.Controls.Add(this.checkBox1);
            this.groupBox4.Controls.Add(this.comboBox7);
            this.groupBox4.Location = new System.Drawing.Point(13, 300);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(860, 100);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Domicilios";
            // 
            // textBox14
            // 
            this.textBox14.Location = new System.Drawing.Point(207, 20);
            this.textBox14.Multiline = true;
            this.textBox14.Name = "textBox14";
            this.textBox14.ReadOnly = true;
            this.textBox14.Size = new System.Drawing.Size(647, 74);
            this.textBox14.TabIndex = 2;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(7, 48);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(175, 17);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "Domicilio para Correspondencia";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // comboBox7
            // 
            this.comboBox7.Enabled = false;
            this.comboBox7.FormattingEnabled = true;
            this.comboBox7.Items.AddRange(new object[] {
            "Particular",
            "Trabajo"});
            this.comboBox7.Location = new System.Drawing.Point(7, 20);
            this.comboBox7.Name = "comboBox7";
            this.comboBox7.Size = new System.Drawing.Size(193, 21);
            this.comboBox7.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idContactoDataGridViewTextBoxColumn,
            this.tratamientoContactoDataGridViewTextBoxColumn,
            this.nombreContactoDataGridViewTextBoxColumn,
            this.apePaternoContactoDataGridViewTextBoxColumn,
            this.apeMaternoContactoDataGridViewTextBoxColumn,
            this.organizacionContactoDataGridViewTextBoxColumn,
            this.puestoContactoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.contactoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 407);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(983, 242);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // idContactoDataGridViewTextBoxColumn
            // 
            this.idContactoDataGridViewTextBoxColumn.DataPropertyName = "idContacto";
            this.idContactoDataGridViewTextBoxColumn.HeaderText = "idContacto";
            this.idContactoDataGridViewTextBoxColumn.Name = "idContactoDataGridViewTextBoxColumn";
            this.idContactoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tratamientoContactoDataGridViewTextBoxColumn
            // 
            this.tratamientoContactoDataGridViewTextBoxColumn.DataPropertyName = "tratamientoContacto";
            this.tratamientoContactoDataGridViewTextBoxColumn.HeaderText = "tratamientoContacto";
            this.tratamientoContactoDataGridViewTextBoxColumn.Name = "tratamientoContactoDataGridViewTextBoxColumn";
            this.tratamientoContactoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreContactoDataGridViewTextBoxColumn
            // 
            this.nombreContactoDataGridViewTextBoxColumn.DataPropertyName = "nombreContacto";
            this.nombreContactoDataGridViewTextBoxColumn.HeaderText = "nombreContacto";
            this.nombreContactoDataGridViewTextBoxColumn.Name = "nombreContactoDataGridViewTextBoxColumn";
            this.nombreContactoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // apePaternoContactoDataGridViewTextBoxColumn
            // 
            this.apePaternoContactoDataGridViewTextBoxColumn.DataPropertyName = "apePaternoContacto";
            this.apePaternoContactoDataGridViewTextBoxColumn.HeaderText = "apePaternoContacto";
            this.apePaternoContactoDataGridViewTextBoxColumn.Name = "apePaternoContactoDataGridViewTextBoxColumn";
            this.apePaternoContactoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // apeMaternoContactoDataGridViewTextBoxColumn
            // 
            this.apeMaternoContactoDataGridViewTextBoxColumn.DataPropertyName = "apeMaternoContacto";
            this.apeMaternoContactoDataGridViewTextBoxColumn.HeaderText = "apeMaternoContacto";
            this.apeMaternoContactoDataGridViewTextBoxColumn.Name = "apeMaternoContactoDataGridViewTextBoxColumn";
            this.apeMaternoContactoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // organizacionContactoDataGridViewTextBoxColumn
            // 
            this.organizacionContactoDataGridViewTextBoxColumn.DataPropertyName = "organizacionContacto";
            this.organizacionContactoDataGridViewTextBoxColumn.HeaderText = "organizacionContacto";
            this.organizacionContactoDataGridViewTextBoxColumn.Name = "organizacionContactoDataGridViewTextBoxColumn";
            this.organizacionContactoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // puestoContactoDataGridViewTextBoxColumn
            // 
            this.puestoContactoDataGridViewTextBoxColumn.DataPropertyName = "puestoContacto";
            this.puestoContactoDataGridViewTextBoxColumn.HeaderText = "puestoContacto";
            this.puestoContactoDataGridViewTextBoxColumn.Name = "puestoContactoDataGridViewTextBoxColumn";
            this.puestoContactoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(879, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 35);
            this.button1.TabIndex = 5;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(879, 65);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 35);
            this.button2.TabIndex = 6;
            this.button2.Text = "Eliminar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(879, 106);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(117, 35);
            this.button3.TabIndex = 7;
            this.button3.Text = "Modificar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(879, 318);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(117, 35);
            this.button4.TabIndex = 8;
            this.button4.Text = "Aceptar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(879, 359);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(117, 35);
            this.button5.TabIndex = 9;
            this.button5.Text = "Cancelar";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // contactoTableAdapter
            // 
            this.contactoTableAdapter.ClearBeforeFill = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(94, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Telefono Trabajo";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(86, 51);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(96, 13);
            this.label11.TabIndex = 9;
            this.label11.Text = "Telefono Particular";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(113, 80);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 13);
            this.label12.TabIndex = 10;
            this.label12.Text = "Telefono Fax";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(105, 106);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(77, 13);
            this.label13.TabIndex = 11;
            this.label13.Text = "Telefono Móvil";
            // 
            // dsTelefonos
            // 
            this.dsTelefonos.DataSetName = "dsTelefonos";
            this.dsTelefonos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // telefonosBindingSource
            // 
            this.telefonosBindingSource.DataMember = "telefonos";
            this.telefonosBindingSource.DataSource = this.dsTelefonos;
            // 
            // telefonosTableAdapter
            // 
            this.telefonosTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1008, 661);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agenda de Contactos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contactoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDetalleContactoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDetalleContacto)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTelefonos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.telefonosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtApeMaterno;
        private System.Windows.Forms.TextBox txtApePaterno;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbTratamiento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPuesto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtOrganizacion;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtTelMovil;
        private System.Windows.Forms.TextBox txtTelFax;
        private System.Windows.Forms.TextBox txtTelParticular;
        private System.Windows.Forms.TextBox txtTelTrabajo;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ComboBox comboBox7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.BindingSource dsDetalleContactoBindingSource;
        private dsDetalleContacto dsDetalleContacto;
        private System.Windows.Forms.BindingSource contactoBindingSource;
        private dsDetalleContactoTableAdapters.contactoTableAdapter contactoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idContactoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tratamientoContactoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreContactoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apePaternoContactoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apeMaternoContactoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn organizacionContactoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn puestoContactoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private dsTelefonos dsTelefonos;
        private System.Windows.Forms.BindingSource telefonosBindingSource;
        private dsTelefonosTableAdapters.telefonosTableAdapter telefonosTableAdapter;
    }
}

