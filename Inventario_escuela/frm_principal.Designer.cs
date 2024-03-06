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
            this.pnl_titulo = new System.Windows.Forms.Panel();
            this.lbl_minimizar = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_cerrar = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txt_id = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txt_cantidad_equipos = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txt_nombre_sala = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.cmb_estado_sala = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ptb_buscar = new System.Windows.Forms.PictureBox();
            this.ptb_salas = new System.Windows.Forms.PictureBox();
            this.ptb_registrar = new System.Windows.Forms.PictureBox();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.btn_salas = new System.Windows.Forms.Button();
            this.btn_registrar = new System.Windows.Forms.Button();
            this.lbl_fecha = new System.Windows.Forms.Label();
            this.btn_nuevo_sala = new System.Windows.Forms.Button();
            this.btn_guardar_sala = new System.Windows.Forms.Button();
            this.btn_consultar_sala = new System.Windows.Forms.Button();
            this.btn_actualizar_sala = new System.Windows.Forms.Button();
            this.tm_fecha = new System.Windows.Forms.Timer(this.components);
            this.pnl_salas = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnl_equipos = new System.Windows.Forms.Panel();
            this.btn_anhadir_especificacios_aplicaiones = new System.Windows.Forms.Button();
            this.ptb_foto = new System.Windows.Forms.PictureBox();
            this.txt_config_red = new System.Windows.Forms.TextBox();
            this.cmb_estado_equipo = new System.Windows.Forms.ComboBox();
            this.txt_serial = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btn_actualizar_equipo = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btn_consultar_equipo = new System.Windows.Forms.Button();
            this.btn_guardar_equipo = new System.Windows.Forms.Button();
            this.txt_nombre_equipo = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btn_nuevo_equipo = new System.Windows.Forms.Button();
            this.cmb_tipo = new System.Windows.Forms.ComboBox();
            this.pnl_titulo.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_buscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_salas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_registrar)).BeginInit();
            this.pnl_salas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnl_equipos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_foto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_titulo
            // 
            this.pnl_titulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.pnl_titulo.Controls.Add(this.lbl_minimizar);
            this.pnl_titulo.Controls.Add(this.lbl_cerrar);
            this.pnl_titulo.Controls.Add(this.materialLabel1);
            this.pnl_titulo.Location = new System.Drawing.Point(-3, -1);
            this.pnl_titulo.Name = "pnl_titulo";
            this.pnl_titulo.Size = new System.Drawing.Size(1010, 42);
            this.pnl_titulo.TabIndex = 0;
            this.pnl_titulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnl_titulo_MouseDown);
            this.pnl_titulo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnl_titulo_MouseMove);
            this.pnl_titulo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnl_titulo_MouseUp);
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
            this.txt_id.Hint = "ID de la sala:";
            this.txt_id.Location = new System.Drawing.Point(90, 17);
            this.txt_id.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_id.Name = "txt_id";
            this.txt_id.PasswordChar = '\0';
            this.txt_id.SelectedText = "";
            this.txt_id.SelectionLength = 0;
            this.txt_id.SelectionStart = 0;
            this.txt_id.Size = new System.Drawing.Size(250, 23);
            this.txt_id.TabIndex = 1;
            this.txt_id.UseSystemPasswordChar = false;
            this.txt_id.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_id_KeyUp);
            // 
            // txt_cantidad_equipos
            // 
            this.txt_cantidad_equipos.Depth = 0;
            this.txt_cantidad_equipos.Hint = "Cantidad de equipos:";
            this.txt_cantidad_equipos.Location = new System.Drawing.Point(229, 166);
            this.txt_cantidad_equipos.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_cantidad_equipos.Name = "txt_cantidad_equipos";
            this.txt_cantidad_equipos.PasswordChar = '\0';
            this.txt_cantidad_equipos.SelectedText = "";
            this.txt_cantidad_equipos.SelectionLength = 0;
            this.txt_cantidad_equipos.SelectionStart = 0;
            this.txt_cantidad_equipos.Size = new System.Drawing.Size(289, 23);
            this.txt_cantidad_equipos.TabIndex = 3;
            this.txt_cantidad_equipos.UseSystemPasswordChar = false;
            // 
            // txt_nombre_sala
            // 
            this.txt_nombre_sala.Depth = 0;
            this.txt_nombre_sala.Hint = "Nombre de la sala:";
            this.txt_nombre_sala.Location = new System.Drawing.Point(415, 17);
            this.txt_nombre_sala.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_nombre_sala.Name = "txt_nombre_sala";
            this.txt_nombre_sala.PasswordChar = '\0';
            this.txt_nombre_sala.SelectedText = "";
            this.txt_nombre_sala.SelectionLength = 0;
            this.txt_nombre_sala.SelectionStart = 0;
            this.txt_nombre_sala.Size = new System.Drawing.Size(289, 23);
            this.txt_nombre_sala.TabIndex = 4;
            this.txt_nombre_sala.UseSystemPasswordChar = false;
            // 
            // cmb_estado_sala
            // 
            this.cmb_estado_sala.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_estado_sala.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_estado_sala.FormattingEnabled = true;
            this.cmb_estado_sala.Items.AddRange(new object[] {
            "ACTIVO",
            "INACTIVO"});
            this.cmb_estado_sala.Location = new System.Drawing.Point(229, 228);
            this.cmb_estado_sala.Name = "cmb_estado_sala";
            this.cmb_estado_sala.Size = new System.Drawing.Size(289, 28);
            this.cmb_estado_sala.TabIndex = 5;
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
            this.ptb_salas.Click += new System.EventHandler(this.btn_salas_Click);
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
            this.ptb_registrar.Click += new System.EventHandler(this.btn_registrar_Click);
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
            this.btn_registrar.Click += new System.EventHandler(this.btn_registrar_Click);
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
            // btn_nuevo_sala
            // 
            this.btn_nuevo_sala.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(140)))), ((int)(((byte)(173)))));
            this.btn_nuevo_sala.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_nuevo_sala.ForeColor = System.Drawing.Color.White;
            this.btn_nuevo_sala.Location = new System.Drawing.Point(155, 351);
            this.btn_nuevo_sala.Name = "btn_nuevo_sala";
            this.btn_nuevo_sala.Size = new System.Drawing.Size(94, 36);
            this.btn_nuevo_sala.TabIndex = 13;
            this.btn_nuevo_sala.Text = "Nuevo";
            this.btn_nuevo_sala.UseVisualStyleBackColor = false;
            this.btn_nuevo_sala.Click += new System.EventHandler(this.btn_nuevo_sala_Click);
            // 
            // btn_guardar_sala
            // 
            this.btn_guardar_sala.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(140)))), ((int)(((byte)(173)))));
            this.btn_guardar_sala.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_guardar_sala.ForeColor = System.Drawing.Color.White;
            this.btn_guardar_sala.Location = new System.Drawing.Point(282, 351);
            this.btn_guardar_sala.Name = "btn_guardar_sala";
            this.btn_guardar_sala.Size = new System.Drawing.Size(94, 36);
            this.btn_guardar_sala.TabIndex = 14;
            this.btn_guardar_sala.Text = "Guardar";
            this.btn_guardar_sala.UseVisualStyleBackColor = false;
            this.btn_guardar_sala.Click += new System.EventHandler(this.btn_guardar_sala_Click);
            // 
            // btn_consultar_sala
            // 
            this.btn_consultar_sala.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(140)))), ((int)(((byte)(173)))));
            this.btn_consultar_sala.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_consultar_sala.ForeColor = System.Drawing.Color.White;
            this.btn_consultar_sala.Location = new System.Drawing.Point(406, 351);
            this.btn_consultar_sala.Name = "btn_consultar_sala";
            this.btn_consultar_sala.Size = new System.Drawing.Size(94, 36);
            this.btn_consultar_sala.TabIndex = 15;
            this.btn_consultar_sala.Text = "Consultar";
            this.btn_consultar_sala.UseVisualStyleBackColor = false;
            this.btn_consultar_sala.Click += new System.EventHandler(this.btn_consultar_sala_Click);
            // 
            // btn_actualizar_sala
            // 
            this.btn_actualizar_sala.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(140)))), ((int)(((byte)(173)))));
            this.btn_actualizar_sala.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_actualizar_sala.ForeColor = System.Drawing.Color.White;
            this.btn_actualizar_sala.Location = new System.Drawing.Point(529, 351);
            this.btn_actualizar_sala.Name = "btn_actualizar_sala";
            this.btn_actualizar_sala.Size = new System.Drawing.Size(94, 36);
            this.btn_actualizar_sala.TabIndex = 16;
            this.btn_actualizar_sala.Text = "Actualizar";
            this.btn_actualizar_sala.UseVisualStyleBackColor = false;
            this.btn_actualizar_sala.Click += new System.EventHandler(this.btn_actualizar_sala_Click);
            // 
            // tm_fecha
            // 
            this.tm_fecha.Enabled = true;
            this.tm_fecha.Tick += new System.EventHandler(this.tm_fecha_Tick);
            // 
            // pnl_salas
            // 
            this.pnl_salas.Controls.Add(this.txt_id);
            this.pnl_salas.Controls.Add(this.btn_actualizar_sala);
            this.pnl_salas.Controls.Add(this.pictureBox2);
            this.pnl_salas.Controls.Add(this.btn_consultar_sala);
            this.pnl_salas.Controls.Add(this.txt_cantidad_equipos);
            this.pnl_salas.Controls.Add(this.btn_guardar_sala);
            this.pnl_salas.Controls.Add(this.txt_nombre_sala);
            this.pnl_salas.Controls.Add(this.btn_nuevo_sala);
            this.pnl_salas.Controls.Add(this.cmb_estado_sala);
            this.pnl_salas.Location = new System.Drawing.Point(204, 47);
            this.pnl_salas.Name = "pnl_salas";
            this.pnl_salas.Size = new System.Drawing.Size(731, 470);
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
            this.pnl_equipos.Controls.Add(this.btn_anhadir_especificacios_aplicaiones);
            this.pnl_equipos.Controls.Add(this.ptb_foto);
            this.pnl_equipos.Controls.Add(this.txt_config_red);
            this.pnl_equipos.Controls.Add(this.cmb_estado_equipo);
            this.pnl_equipos.Controls.Add(this.txt_serial);
            this.pnl_equipos.Controls.Add(this.btn_actualizar_equipo);
            this.pnl_equipos.Controls.Add(this.pictureBox4);
            this.pnl_equipos.Controls.Add(this.btn_consultar_equipo);
            this.pnl_equipos.Controls.Add(this.btn_guardar_equipo);
            this.pnl_equipos.Controls.Add(this.txt_nombre_equipo);
            this.pnl_equipos.Controls.Add(this.btn_nuevo_equipo);
            this.pnl_equipos.Controls.Add(this.cmb_tipo);
            this.pnl_equipos.Location = new System.Drawing.Point(225, 91);
            this.pnl_equipos.Name = "pnl_equipos";
            this.pnl_equipos.Size = new System.Drawing.Size(28, 26);
            this.pnl_equipos.TabIndex = 19;
            this.pnl_equipos.Visible = false;
            // 
            // btn_anhadir_especificacios_aplicaiones
            // 
            this.btn_anhadir_especificacios_aplicaiones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(140)))), ((int)(((byte)(173)))));
            this.btn_anhadir_especificacios_aplicaiones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_anhadir_especificacios_aplicaiones.ForeColor = System.Drawing.Color.White;
            this.btn_anhadir_especificacios_aplicaiones.Location = new System.Drawing.Point(457, 351);
            this.btn_anhadir_especificacios_aplicaiones.Name = "btn_anhadir_especificacios_aplicaiones";
            this.btn_anhadir_especificacios_aplicaiones.Size = new System.Drawing.Size(314, 36);
            this.btn_anhadir_especificacios_aplicaiones.TabIndex = 20;
            this.btn_anhadir_especificacios_aplicaiones.Text = "Añadir especificaciones o aplicaciones";
            this.btn_anhadir_especificacios_aplicaiones.UseVisualStyleBackColor = false;
            // 
            // ptb_foto
            // 
            this.ptb_foto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ptb_foto.Location = new System.Drawing.Point(457, 106);
            this.ptb_foto.Name = "ptb_foto";
            this.ptb_foto.Size = new System.Drawing.Size(314, 239);
            this.ptb_foto.TabIndex = 19;
            this.ptb_foto.TabStop = false;
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
            // cmb_estado_equipo
            // 
            this.cmb_estado_equipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_estado_equipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_estado_equipo.FormattingEnabled = true;
            this.cmb_estado_equipo.Items.AddRange(new object[] {
            "Estado"});
            this.cmb_estado_equipo.Location = new System.Drawing.Point(75, 158);
            this.cmb_estado_equipo.Name = "cmb_estado_equipo";
            this.cmb_estado_equipo.Size = new System.Drawing.Size(320, 28);
            this.cmb_estado_equipo.TabIndex = 17;
            // 
            // txt_serial
            // 
            this.txt_serial.Depth = 0;
            this.txt_serial.Hint = "Serial:";
            this.txt_serial.Location = new System.Drawing.Point(21, 17);
            this.txt_serial.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_serial.Name = "txt_serial";
            this.txt_serial.PasswordChar = '\0';
            this.txt_serial.SelectedText = "";
            this.txt_serial.SelectionLength = 0;
            this.txt_serial.SelectionStart = 0;
            this.txt_serial.Size = new System.Drawing.Size(250, 23);
            this.txt_serial.TabIndex = 1;
            this.txt_serial.UseSystemPasswordChar = false;
            // 
            // btn_actualizar_equipo
            // 
            this.btn_actualizar_equipo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(140)))), ((int)(((byte)(173)))));
            this.btn_actualizar_equipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_actualizar_equipo.ForeColor = System.Drawing.Color.White;
            this.btn_actualizar_equipo.Location = new System.Drawing.Point(535, 452);
            this.btn_actualizar_equipo.Name = "btn_actualizar_equipo";
            this.btn_actualizar_equipo.Size = new System.Drawing.Size(94, 36);
            this.btn_actualizar_equipo.TabIndex = 16;
            this.btn_actualizar_equipo.Text = "Actualizar";
            this.btn_actualizar_equipo.UseVisualStyleBackColor = false;
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
            // btn_consultar_equipo
            // 
            this.btn_consultar_equipo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(140)))), ((int)(((byte)(173)))));
            this.btn_consultar_equipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_consultar_equipo.ForeColor = System.Drawing.Color.White;
            this.btn_consultar_equipo.Location = new System.Drawing.Point(412, 452);
            this.btn_consultar_equipo.Name = "btn_consultar_equipo";
            this.btn_consultar_equipo.Size = new System.Drawing.Size(94, 36);
            this.btn_consultar_equipo.TabIndex = 15;
            this.btn_consultar_equipo.Text = "Consultar";
            this.btn_consultar_equipo.UseVisualStyleBackColor = false;
            // 
            // btn_guardar_equipo
            // 
            this.btn_guardar_equipo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(140)))), ((int)(((byte)(173)))));
            this.btn_guardar_equipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_guardar_equipo.ForeColor = System.Drawing.Color.White;
            this.btn_guardar_equipo.Location = new System.Drawing.Point(288, 452);
            this.btn_guardar_equipo.Name = "btn_guardar_equipo";
            this.btn_guardar_equipo.Size = new System.Drawing.Size(94, 36);
            this.btn_guardar_equipo.TabIndex = 14;
            this.btn_guardar_equipo.Text = "Guardar";
            this.btn_guardar_equipo.UseVisualStyleBackColor = false;
            // 
            // txt_nombre_equipo
            // 
            this.txt_nombre_equipo.Depth = 0;
            this.txt_nombre_equipo.Hint = "Nombre del equipo:";
            this.txt_nombre_equipo.Location = new System.Drawing.Point(317, 17);
            this.txt_nombre_equipo.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_nombre_equipo.Name = "txt_nombre_equipo";
            this.txt_nombre_equipo.PasswordChar = '\0';
            this.txt_nombre_equipo.SelectedText = "";
            this.txt_nombre_equipo.SelectionLength = 0;
            this.txt_nombre_equipo.SelectionStart = 0;
            this.txt_nombre_equipo.Size = new System.Drawing.Size(422, 23);
            this.txt_nombre_equipo.TabIndex = 4;
            this.txt_nombre_equipo.UseSystemPasswordChar = false;
            // 
            // btn_nuevo_equipo
            // 
            this.btn_nuevo_equipo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(140)))), ((int)(((byte)(173)))));
            this.btn_nuevo_equipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_nuevo_equipo.ForeColor = System.Drawing.Color.White;
            this.btn_nuevo_equipo.Location = new System.Drawing.Point(161, 452);
            this.btn_nuevo_equipo.Name = "btn_nuevo_equipo";
            this.btn_nuevo_equipo.Size = new System.Drawing.Size(94, 36);
            this.btn_nuevo_equipo.TabIndex = 13;
            this.btn_nuevo_equipo.Text = "Nuevo";
            this.btn_nuevo_equipo.UseVisualStyleBackColor = false;
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
            // frm_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1005, 602);
            this.Controls.Add(this.pnl_equipos);
            this.Controls.Add(this.pnl_salas);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnl_titulo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_principal";
            this.Text = "frm_salas";
            this.pnl_titulo.ResumeLayout(false);
            this.pnl_titulo.PerformLayout();
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
            ((System.ComponentModel.ISupportInitialize)(this.ptb_foto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_titulo;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_id;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_cantidad_equipos;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_nombre_sala;
        private System.Windows.Forms.ComboBox cmb_estado_sala;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialLabel lbl_minimizar;
        private MaterialSkin.Controls.MaterialLabel lbl_cerrar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btn_nuevo_sala;
        private System.Windows.Forms.Button btn_guardar_sala;
        private System.Windows.Forms.Button btn_consultar_sala;
        private System.Windows.Forms.Button btn_actualizar_sala;
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
        private System.Windows.Forms.Button btn_actualizar_equipo;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button btn_consultar_equipo;
        private System.Windows.Forms.Button btn_guardar_equipo;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_nombre_equipo;
        private System.Windows.Forms.Button btn_nuevo_equipo;
        private System.Windows.Forms.ComboBox cmb_tipo;
        private System.Windows.Forms.TextBox txt_config_red;
        private System.Windows.Forms.ComboBox cmb_estado_equipo;
        private System.Windows.Forms.Button btn_anhadir_especificacios_aplicaiones;
        private System.Windows.Forms.PictureBox ptb_foto;
    }
}