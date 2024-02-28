namespace Inventario_escuela
{
    partial class frm_principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_principal));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_minimizar = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_cerrar = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txt_id = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialSingleLineTextField2 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialSingleLineTextField3 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.cmb_estado = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ptb_buscar = new System.Windows.Forms.PictureBox();
            this.ptb_salas = new System.Windows.Forms.PictureBox();
            this.ptb_registrar = new System.Windows.Forms.PictureBox();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.btn_salas = new System.Windows.Forms.Button();
            this.btn_registrar = new System.Windows.Forms.Button();
            this.lbl_fecha = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.tm_fecha = new System.Windows.Forms.Timer(this.components);
            this.pnl_salas = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnl_equipos = new System.Windows.Forms.Panel();
            this.txt_serial = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.button5 = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.txt_nombre_equipo = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.button8 = new System.Windows.Forms.Button();
            this.cmb_tipo = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txt_config_red = new System.Windows.Forms.TextBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.button9 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_buscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_salas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_registrar)).BeginInit();
            this.pnl_salas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnl_equipos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.panel1.Controls.Add(this.lbl_minimizar);
            this.panel1.Controls.Add(this.lbl_cerrar);
            this.panel1.Controls.Add(this.materialLabel1);
            this.panel1.Location = new System.Drawing.Point(-3, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1010, 42);
            this.panel1.TabIndex = 0;
            // 
            // lbl_minimizar
            // 
            this.lbl_minimizar.AutoSize = true;
            this.lbl_minimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_minimizar.Depth = 0;
            this.lbl_minimizar.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_minimizar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_minimizar.Location = new System.Drawing.Point(954, 14);
            this.lbl_minimizar.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_minimizar.Name = "lbl_minimizar";
            this.lbl_minimizar.Size = new System.Drawing.Size(17, 19);
            this.lbl_minimizar.TabIndex = 2;
            this.lbl_minimizar.Text = "--";
            this.lbl_minimizar.Click += new System.EventHandler(this.lbl_minimizar_Click);
            // 
            // lbl_cerrar
            // 
            this.lbl_cerrar.AutoSize = true;
            this.lbl_cerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_cerrar.Depth = 0;
            this.lbl_cerrar.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_cerrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_cerrar.Location = new System.Drawing.Point(978, 14);
            this.lbl_cerrar.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_cerrar.Name = "lbl_cerrar";
            this.lbl_cerrar.Size = new System.Drawing.Size(18, 19);
            this.lbl_cerrar.TabIndex = 1;
            this.lbl_cerrar.Text = "X";
            this.lbl_cerrar.Click += new System.EventHandler(this.lbl_cerrar_Click);
            this.lbl_cerrar.MouseEnter += new System.EventHandler(this.lbl_cerrar_MouseEnter);
            this.lbl_cerrar.MouseLeave += new System.EventHandler(this.lbl_cerrar_MouseLeave);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(11, 10);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(135, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Inventario de aulas";
            // 
            // txt_id
            // 
            this.txt_id.Depth = 0;
            this.txt_id.Hint = "";
            this.txt_id.Location = new System.Drawing.Point(90, 17);
            this.txt_id.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_id.Name = "txt_id";
            this.txt_id.PasswordChar = '\0';
            this.txt_id.SelectedText = "";
            this.txt_id.SelectionLength = 0;
            this.txt_id.SelectionStart = 0;
            this.txt_id.Size = new System.Drawing.Size(250, 23);
            this.txt_id.TabIndex = 1;
            this.txt_id.Text = "ID de la sala:";
            this.txt_id.UseSystemPasswordChar = false;
            // 
            // materialSingleLineTextField2
            // 
            this.materialSingleLineTextField2.Depth = 0;
            this.materialSingleLineTextField2.Hint = "";
            this.materialSingleLineTextField2.Location = new System.Drawing.Point(229, 166);
            this.materialSingleLineTextField2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField2.Name = "materialSingleLineTextField2";
            this.materialSingleLineTextField2.PasswordChar = '\0';
            this.materialSingleLineTextField2.SelectedText = "";
            this.materialSingleLineTextField2.SelectionLength = 0;
            this.materialSingleLineTextField2.SelectionStart = 0;
            this.materialSingleLineTextField2.Size = new System.Drawing.Size(289, 23);
            this.materialSingleLineTextField2.TabIndex = 3;
            this.materialSingleLineTextField2.Text = "Cantidad de equipos:";
            this.materialSingleLineTextField2.UseSystemPasswordChar = false;
            // 
            // materialSingleLineTextField3
            // 
            this.materialSingleLineTextField3.Depth = 0;
            this.materialSingleLineTextField3.Hint = "";
            this.materialSingleLineTextField3.Location = new System.Drawing.Point(415, 17);
            this.materialSingleLineTextField3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField3.Name = "materialSingleLineTextField3";
            this.materialSingleLineTextField3.PasswordChar = '\0';
            this.materialSingleLineTextField3.SelectedText = "";
            this.materialSingleLineTextField3.SelectionLength = 0;
            this.materialSingleLineTextField3.SelectionStart = 0;
            this.materialSingleLineTextField3.Size = new System.Drawing.Size(289, 23);
            this.materialSingleLineTextField3.TabIndex = 4;
            this.materialSingleLineTextField3.Text = "Nombre de la sala:";
            this.materialSingleLineTextField3.UseSystemPasswordChar = false;
            // 
            // cmb_estado
            // 
            this.cmb_estado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_estado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_estado.FormattingEnabled = true;
            this.cmb_estado.Items.AddRange(new object[] {
            "Seleccionar estado",
            "ACTIVO",
            "INACTIVO"});
            this.cmb_estado.Location = new System.Drawing.Point(229, 228);
            this.cmb_estado.Name = "cmb_estado";
            this.cmb_estado.Size = new System.Drawing.Size(289, 28);
            this.cmb_estado.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(140)))), ((int)(((byte)(173)))));
            this.panel2.Controls.Add(this.ptb_buscar);
            this.panel2.Controls.Add(this.ptb_salas);
            this.panel2.Controls.Add(this.ptb_registrar);
            this.panel2.Controls.Add(this.btn_buscar);
            this.panel2.Controls.Add(this.btn_salas);
            this.panel2.Controls.Add(this.btn_registrar);
            this.panel2.Controls.Add(this.lbl_fecha);
            this.panel2.Location = new System.Drawing.Point(-2, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 566);
            this.panel2.TabIndex = 11;
            // 
            // ptb_buscar
            // 
            this.ptb_buscar.Image = global::Inventario_escuela.Properties.Resources.icons8_buscar_50;
            this.ptb_buscar.Location = new System.Drawing.Point(4, 241);
            this.ptb_buscar.Name = "ptb_buscar";
            this.ptb_buscar.Size = new System.Drawing.Size(56, 48);
            this.ptb_buscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb_buscar.TabIndex = 21;
            this.ptb_buscar.TabStop = false;
            this.ptb_buscar.MouseEnter += new System.EventHandler(this.ptb_buscar_MouseEnter);
            this.ptb_buscar.MouseLeave += new System.EventHandler(this.ptb_buscar_MouseLeave);
            // 
            // ptb_salas
            // 
            this.ptb_salas.Image = global::Inventario_escuela.Properties.Resources.icons8_habitación_50;
            this.ptb_salas.Location = new System.Drawing.Point(4, 191);
            this.ptb_salas.Name = "ptb_salas";
            this.ptb_salas.Size = new System.Drawing.Size(56, 48);
            this.ptb_salas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb_salas.TabIndex = 20;
            this.ptb_salas.TabStop = false;
            this.ptb_salas.Click += new System.EventHandler(this.ptb_salas_Click);
            this.ptb_salas.MouseEnter += new System.EventHandler(this.ptb_salas_MouseEnter);
            this.ptb_salas.MouseLeave += new System.EventHandler(this.ptb_salas_MouseLeave);
            // 
            // ptb_registrar
            // 
            this.ptb_registrar.Image = global::Inventario_escuela.Properties.Resources.icons8_computadora_80;
            this.ptb_registrar.Location = new System.Drawing.Point(3, 141);
            this.ptb_registrar.Name = "ptb_registrar";
            this.ptb_registrar.Size = new System.Drawing.Size(56, 48);
            this.ptb_registrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb_registrar.TabIndex = 17;
            this.ptb_registrar.TabStop = false;
            this.ptb_registrar.MouseEnter += new System.EventHandler(this.ptb_registrar_MouseEnter);
            this.ptb_registrar.MouseLeave += new System.EventHandler(this.ptb_registrar_MouseLeave);
            // 
            // btn_buscar
            // 
            this.btn_buscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(140)))), ((int)(((byte)(173)))));
            this.btn_buscar.FlatAppearance.BorderSize = 0;
            this.btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscar.ForeColor = System.Drawing.Color.White;
            this.btn_buscar.Location = new System.Drawing.Point(4, 241);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(195, 48);
            this.btn_buscar.TabIndex = 19;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = false;
            this.btn_buscar.MouseEnter += new System.EventHandler(this.btn_buscar_MouseEnter);
            this.btn_buscar.MouseLeave += new System.EventHandler(this.btn_buscar_MouseLeave);
            // 
            // btn_salas
            // 
            this.btn_salas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(140)))), ((int)(((byte)(173)))));
            this.btn_salas.FlatAppearance.BorderSize = 0;
            this.btn_salas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salas.ForeColor = System.Drawing.Color.White;
            this.btn_salas.Location = new System.Drawing.Point(43, 191);
            this.btn_salas.Name = "btn_salas";
            this.btn_salas.Size = new System.Drawing.Size(155, 48);
            this.btn_salas.TabIndex = 18;
            this.btn_salas.Text = "Registro salas";
            this.btn_salas.UseVisualStyleBackColor = false;
            this.btn_salas.Click += new System.EventHandler(this.btn_salas_Click);
            this.btn_salas.MouseEnter += new System.EventHandler(this.btn_salas_MouseEnter);
            this.btn_salas.MouseLeave += new System.EventHandler(this.btn_salas_MouseLeave);
            // 
            // btn_registrar
            // 
            this.btn_registrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(140)))), ((int)(((byte)(173)))));
            this.btn_registrar.FlatAppearance.BorderSize = 0;
            this.btn_registrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_registrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_registrar.ForeColor = System.Drawing.Color.White;
            this.btn_registrar.Location = new System.Drawing.Point(59, 141);
            this.btn_registrar.Name = "btn_registrar";
            this.btn_registrar.Size = new System.Drawing.Size(133, 48);
            this.btn_registrar.TabIndex = 17;
            this.btn_registrar.Text = "Registrar equipo";
            this.btn_registrar.UseVisualStyleBackColor = false;
            this.btn_registrar.MouseEnter += new System.EventHandler(this.btn_registrar_MouseEnter);
            this.btn_registrar.MouseLeave += new System.EventHandler(this.btn_registrar_MouseLeave);
            // 
            // lbl_fecha
            // 
            this.lbl_fecha.AutoSize = true;
            this.lbl_fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fecha.ForeColor = System.Drawing.Color.White;
            this.lbl_fecha.Location = new System.Drawing.Point(28, 535);
            this.lbl_fecha.Name = "lbl_fecha";
            this.lbl_fecha.Size = new System.Drawing.Size(66, 18);
            this.lbl_fecha.TabIndex = 4;
            this.lbl_fecha.Text = "lbl_fecha";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(140)))), ((int)(((byte)(173)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(155, 351);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 36);
            this.button1.TabIndex = 13;
            this.button1.Text = "Nuevo";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(140)))), ((int)(((byte)(173)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(282, 351);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 36);
            this.button2.TabIndex = 14;
            this.button2.Text = "Guardar";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(140)))), ((int)(((byte)(173)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(406, 351);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 36);
            this.button3.TabIndex = 15;
            this.button3.Text = "Consultar";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(140)))), ((int)(((byte)(173)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(529, 351);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(94, 36);
            this.button4.TabIndex = 16;
            this.button4.Text = "Actualizar";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // tm_fecha
            // 
            this.tm_fecha.Enabled = true;
            this.tm_fecha.Tick += new System.EventHandler(this.tm_fecha_Tick);
            // 
            // pnl_salas
            // 
            this.pnl_salas.Controls.Add(this.txt_id);
            this.pnl_salas.Controls.Add(this.button4);
            this.pnl_salas.Controls.Add(this.pictureBox2);
            this.pnl_salas.Controls.Add(this.button3);
            this.pnl_salas.Controls.Add(this.materialSingleLineTextField2);
            this.pnl_salas.Controls.Add(this.button2);
            this.pnl_salas.Controls.Add(this.materialSingleLineTextField3);
            this.pnl_salas.Controls.Add(this.button1);
            this.pnl_salas.Controls.Add(this.cmb_estado);
            this.pnl_salas.Location = new System.Drawing.Point(852, 203);
            this.pnl_salas.Name = "pnl_salas";
            this.pnl_salas.Size = new System.Drawing.Size(46, 26);
            this.pnl_salas.TabIndex = 17;
            this.pnl_salas.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 51);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(813, 11);
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Inventario_escuela.Properties.Resources.background;
            this.pictureBox3.Location = new System.Drawing.Point(346, 149);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(415, 368);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 18;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-2, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1009, 10);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // pnl_equipos
            // 
            this.pnl_equipos.Controls.Add(this.button9);
            this.pnl_equipos.Controls.Add(this.pictureBox5);
            this.pnl_equipos.Controls.Add(this.txt_config_red);
            this.pnl_equipos.Controls.Add(this.comboBox1);
            this.pnl_equipos.Controls.Add(this.txt_serial);
            this.pnl_equipos.Controls.Add(this.button5);
            this.pnl_equipos.Controls.Add(this.pictureBox4);
            this.pnl_equipos.Controls.Add(this.button6);
            this.pnl_equipos.Controls.Add(this.button7);
            this.pnl_equipos.Controls.Add(this.txt_nombre_equipo);
            this.pnl_equipos.Controls.Add(this.button8);
            this.pnl_equipos.Controls.Add(this.cmb_tipo);
            this.pnl_equipos.Location = new System.Drawing.Point(196, 43);
            this.pnl_equipos.Name = "pnl_equipos";
            this.pnl_equipos.Size = new System.Drawing.Size(811, 563);
            this.pnl_equipos.TabIndex = 19;
            this.pnl_equipos.Visible = false;
            // 
            // txt_serial
            // 
            this.txt_serial.Depth = 0;
            this.txt_serial.Hint = "";
            this.txt_serial.Location = new System.Drawing.Point(21, 17);
            this.txt_serial.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_serial.Name = "txt_serial";
            this.txt_serial.PasswordChar = '\0';
            this.txt_serial.SelectedText = "";
            this.txt_serial.SelectionLength = 0;
            this.txt_serial.SelectionStart = 0;
            this.txt_serial.Size = new System.Drawing.Size(250, 23);
            this.txt_serial.TabIndex = 1;
            this.txt_serial.Text = "Serial:";
            this.txt_serial.UseSystemPasswordChar = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(140)))), ((int)(((byte)(173)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(535, 452);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(94, 36);
            this.button5.TabIndex = 16;
            this.button5.Text = "Actualizar";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(0, 51);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(813, 11);
            this.pictureBox4.TabIndex = 12;
            this.pictureBox4.TabStop = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(140)))), ((int)(((byte)(173)))));
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(412, 452);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(94, 36);
            this.button6.TabIndex = 15;
            this.button6.Text = "Consultar";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(140)))), ((int)(((byte)(173)))));
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Location = new System.Drawing.Point(288, 452);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(94, 36);
            this.button7.TabIndex = 14;
            this.button7.Text = "Guardar";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // txt_nombre_equipo
            // 
            this.txt_nombre_equipo.Depth = 0;
            this.txt_nombre_equipo.Hint = "";
            this.txt_nombre_equipo.Location = new System.Drawing.Point(317, 17);
            this.txt_nombre_equipo.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_nombre_equipo.Name = "txt_nombre_equipo";
            this.txt_nombre_equipo.PasswordChar = '\0';
            this.txt_nombre_equipo.SelectedText = "";
            this.txt_nombre_equipo.SelectionLength = 0;
            this.txt_nombre_equipo.SelectionStart = 0;
            this.txt_nombre_equipo.Size = new System.Drawing.Size(422, 23);
            this.txt_nombre_equipo.TabIndex = 4;
            this.txt_nombre_equipo.Text = "Nombre del equipo:";
            this.txt_nombre_equipo.UseSystemPasswordChar = false;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(140)))), ((int)(((byte)(173)))));
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.Location = new System.Drawing.Point(161, 452);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(94, 36);
            this.button8.TabIndex = 13;
            this.button8.Text = "Nuevo";
            this.button8.UseVisualStyleBackColor = false;
            // 
            // cmb_tipo
            // 
            this.cmb_tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_tipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_tipo.FormattingEnabled = true;
            this.cmb_tipo.Items.AddRange(new object[] {
            "Tipo"});
            this.cmb_tipo.Location = new System.Drawing.Point(75, 106);
            this.cmb_tipo.Name = "cmb_tipo";
            this.cmb_tipo.Size = new System.Drawing.Size(320, 28);
            this.cmb_tipo.TabIndex = 5;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Estado"});
            this.comboBox1.Location = new System.Drawing.Point(75, 158);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(320, 28);
            this.comboBox1.TabIndex = 17;
            // 
            // txt_config_red
            // 
            this.txt_config_red.Location = new System.Drawing.Point(75, 201);
            this.txt_config_red.Multiline = true;
            this.txt_config_red.Name = "txt_config_red";
            this.txt_config_red.Size = new System.Drawing.Size(320, 186);
            this.txt_config_red.TabIndex = 18;
            this.txt_config_red.Text = "Configuración de red:";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Location = new System.Drawing.Point(457, 106);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(314, 239);
            this.pictureBox5.TabIndex = 19;
            this.pictureBox5.TabStop = false;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(140)))), ((int)(((byte)(173)))));
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.ForeColor = System.Drawing.Color.White;
            this.button9.Location = new System.Drawing.Point(457, 351);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(314, 36);
            this.button9.TabIndex = 20;
            this.button9.Text = "Añadir especificaciones o aplicaciones";
            this.button9.UseVisualStyleBackColor = false;
            // 
            // frm_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1005, 602);
            this.Controls.Add(this.pnl_equipos);
            this.Controls.Add(this.pnl_salas);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_principal";
            this.Text = "frm_salas";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_buscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_salas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_registrar)).EndInit();
            this.pnl_salas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnl_equipos.ResumeLayout(false);
            this.pnl_equipos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_id;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField2;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField3;
        private System.Windows.Forms.ComboBox cmb_estado;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialLabel lbl_minimizar;
        private MaterialSkin.Controls.MaterialLabel lbl_cerrar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Timer tm_fecha;
        private System.Windows.Forms.Label lbl_fecha;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Button btn_salas;
        private System.Windows.Forms.Button btn_registrar;
        private System.Windows.Forms.PictureBox ptb_registrar;
        private System.Windows.Forms.PictureBox ptb_salas;
        private System.Windows.Forms.PictureBox ptb_buscar;
        private System.Windows.Forms.Panel pnl_salas;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel pnl_equipos;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_serial;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_nombre_equipo;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.ComboBox cmb_tipo;
        private System.Windows.Forms.TextBox txt_config_red;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.PictureBox pictureBox5;
    }
}