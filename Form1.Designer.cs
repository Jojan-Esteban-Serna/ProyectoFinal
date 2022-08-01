
namespace ProyectoFinal
{
    partial class frmArtistas
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
            this.tpConsultas = new System.Windows.Forms.TabPage();
            this.pnlConsultas = new System.Windows.Forms.Panel();
            this.btnNumPintores = new System.Windows.Forms.Button();
            this.lblNumeroPintores = new System.Windows.Forms.Label();
            this.dgvSeleccionVinculacion = new System.Windows.Forms.DataGridView();
            this.btnConsultaPorFechaVinculacion1 = new System.Windows.Forms.Button();
            this.dtpConsFechaInicioVinculacion = new System.Windows.Forms.DateTimePicker();
            this.lblMensajeFechaInicioVinculacion = new System.Windows.Forms.Label();
            this.lblMensajeConsultas = new System.Windows.Forms.Label();
            this.tpRegistroVinculacion = new System.Windows.Forms.TabPage();
            this.pnlVinculacion = new System.Windows.Forms.Panel();
            this.chkFechaFin = new System.Windows.Forms.CheckBox();
            this.lblTituloDgvArtistas = new System.Windows.Forms.Label();
            this.labelTituloDgvAsociaciones = new System.Windows.Forms.Label();
            this.lblCodigoArtistaVincular = new System.Windows.Forms.Label();
            this.lblNitAsociacionVincular = new System.Windows.Forms.Label();
            this.lblCodigoArtistaSeleccionado = new System.Windows.Forms.Label();
            this.lblNitAsociacionSeleccionada = new System.Windows.Forms.Label();
            this.btnRegistrarVinculacion = new System.Windows.Forms.Button();
            this.lblFechaInicio = new System.Windows.Forms.Label();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.dgvSeleccionArtista = new System.Windows.Forms.DataGridView();
            this.dgvSeleccionAsociacion = new System.Windows.Forms.DataGridView();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.lblMensajeVinculacion1 = new System.Windows.Forms.Label();
            this.lblMensajeVinculacion2 = new System.Windows.Forms.Label();
            this.tpRegistroArtista = new System.Windows.Forms.TabPage();
            this.pnlRegistroArtista = new System.Windows.Forms.Panel();
            this.btnRegistrarArtista = new System.Windows.Forms.Button();
            this.dtpAnioNacimiento = new System.Windows.Forms.DateTimePicker();
            this.txtNombreArtistico = new System.Windows.Forms.TextBox();
            this.cbxTipoArte = new System.Windows.Forms.ComboBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblAnioNacimiento = new System.Windows.Forms.Label();
            this.lblNombreArtistico = new System.Windows.Forms.Label();
            this.lblTipoArte = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblMensajeArtista = new System.Windows.Forms.Label();
            this.tpRegistroAsociacionArtista = new System.Windows.Forms.TabPage();
            this.pnlRegistroAsociacion = new System.Windows.Forms.Panel();
            this.btnRegistrarAsociacion = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtNit = new System.Windows.Forms.TextBox();
            this.gboxModalidades = new System.Windows.Forms.GroupBox();
            this.rbSinAnimoDeLucro = new System.Windows.Forms.RadioButton();
            this.rbConAnimoDeLucro = new System.Windows.Forms.RadioButton();
            this.lblModalidad = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblNit = new System.Windows.Forms.Label();
            this.lblMensajeAsociacion = new System.Windows.Forms.Label();
            this.tbcGestion = new System.Windows.Forms.TabControl();
            this.tpConsultas.SuspendLayout();
            this.pnlConsultas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeleccionVinculacion)).BeginInit();
            this.tpRegistroVinculacion.SuspendLayout();
            this.pnlVinculacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeleccionArtista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeleccionAsociacion)).BeginInit();
            this.tpRegistroArtista.SuspendLayout();
            this.pnlRegistroArtista.SuspendLayout();
            this.tpRegistroAsociacionArtista.SuspendLayout();
            this.pnlRegistroAsociacion.SuspendLayout();
            this.gboxModalidades.SuspendLayout();
            this.tbcGestion.SuspendLayout();
            this.SuspendLayout();
            // 
            // tpConsultas
            // 
            this.tpConsultas.Controls.Add(this.pnlConsultas);
            this.tpConsultas.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpConsultas.Location = new System.Drawing.Point(4, 22);
            this.tpConsultas.Name = "tpConsultas";
            this.tpConsultas.Padding = new System.Windows.Forms.Padding(3);
            this.tpConsultas.Size = new System.Drawing.Size(999, 510);
            this.tpConsultas.TabIndex = 3;
            this.tpConsultas.Text = "Consultas";
            this.tpConsultas.UseVisualStyleBackColor = true;
            // 
            // pnlConsultas
            // 
            this.pnlConsultas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlConsultas.Controls.Add(this.btnNumPintores);
            this.pnlConsultas.Controls.Add(this.lblNumeroPintores);
            this.pnlConsultas.Controls.Add(this.dgvSeleccionVinculacion);
            this.pnlConsultas.Controls.Add(this.btnConsultaPorFechaVinculacion1);
            this.pnlConsultas.Controls.Add(this.dtpConsFechaInicioVinculacion);
            this.pnlConsultas.Controls.Add(this.lblMensajeFechaInicioVinculacion);
            this.pnlConsultas.Controls.Add(this.lblMensajeConsultas);
            this.pnlConsultas.Location = new System.Drawing.Point(0, 0);
            this.pnlConsultas.Name = "pnlConsultas";
            this.pnlConsultas.Size = new System.Drawing.Size(999, 510);
            this.pnlConsultas.TabIndex = 0;
            // 
            // btnNumPintores
            // 
            this.btnNumPintores.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNumPintores.Location = new System.Drawing.Point(295, 387);
            this.btnNumPintores.Name = "btnNumPintores";
            this.btnNumPintores.Size = new System.Drawing.Size(238, 23);
            this.btnNumPintores.TabIndex = 8;
            this.btnNumPintores.Text = "Consultar numero de pintores";
            this.btnNumPintores.UseVisualStyleBackColor = true;
            this.btnNumPintores.Click += new System.EventHandler(this.btnNumPintores_Click);
            // 
            // lblNumeroPintores
            // 
            this.lblNumeroPintores.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNumeroPintores.AutoSize = true;
            this.lblNumeroPintores.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroPintores.Location = new System.Drawing.Point(549, 387);
            this.lblNumeroPintores.Name = "lblNumeroPintores";
            this.lblNumeroPintores.Size = new System.Drawing.Size(48, 28);
            this.lblNumeroPintores.TabIndex = 7;
            this.lblNumeroPintores.Text = "----";
            // 
            // dgvSeleccionVinculacion
            // 
            this.dgvSeleccionVinculacion.AllowUserToAddRows = false;
            this.dgvSeleccionVinculacion.AllowUserToDeleteRows = false;
            this.dgvSeleccionVinculacion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvSeleccionVinculacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSeleccionVinculacion.Location = new System.Drawing.Point(142, 158);
            this.dgvSeleccionVinculacion.Name = "dgvSeleccionVinculacion";
            this.dgvSeleccionVinculacion.ReadOnly = true;
            this.dgvSeleccionVinculacion.Size = new System.Drawing.Size(724, 211);
            this.dgvSeleccionVinculacion.TabIndex = 6;
            // 
            // btnConsultaPorFechaVinculacion1
            // 
            this.btnConsultaPorFechaVinculacion1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnConsultaPorFechaVinculacion1.Location = new System.Drawing.Point(661, 118);
            this.btnConsultaPorFechaVinculacion1.Name = "btnConsultaPorFechaVinculacion1";
            this.btnConsultaPorFechaVinculacion1.Size = new System.Drawing.Size(75, 23);
            this.btnConsultaPorFechaVinculacion1.TabIndex = 5;
            this.btnConsultaPorFechaVinculacion1.Text = "Consultar";
            this.btnConsultaPorFechaVinculacion1.UseVisualStyleBackColor = true;
            this.btnConsultaPorFechaVinculacion1.Click += new System.EventHandler(this.btnConsultaPorFechaVinculacion1_Click);
            // 
            // dtpConsFechaInicioVinculacion
            // 
            this.dtpConsFechaInicioVinculacion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpConsFechaInicioVinculacion.CustomFormat = "dd/MM/yyyy";
            this.dtpConsFechaInicioVinculacion.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpConsFechaInicioVinculacion.Location = new System.Drawing.Point(539, 119);
            this.dtpConsFechaInicioVinculacion.Name = "dtpConsFechaInicioVinculacion";
            this.dtpConsFechaInicioVinculacion.Size = new System.Drawing.Size(101, 24);
            this.dtpConsFechaInicioVinculacion.TabIndex = 4;
            // 
            // lblMensajeFechaInicioVinculacion
            // 
            this.lblMensajeFechaInicioVinculacion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMensajeFechaInicioVinculacion.AutoSize = true;
            this.lblMensajeFechaInicioVinculacion.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensajeFechaInicioVinculacion.Location = new System.Drawing.Point(249, 118);
            this.lblMensajeFechaInicioVinculacion.Name = "lblMensajeFechaInicioVinculacion";
            this.lblMensajeFechaInicioVinculacion.Size = new System.Drawing.Size(284, 28);
            this.lblMensajeFechaInicioVinculacion.TabIndex = 3;
            this.lblMensajeFechaInicioVinculacion.Text = "Buscar for fecha inicio vinculacion";
            // 
            // lblMensajeConsultas
            // 
            this.lblMensajeConsultas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMensajeConsultas.AutoSize = true;
            this.lblMensajeConsultas.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensajeConsultas.Location = new System.Drawing.Point(377, 58);
            this.lblMensajeConsultas.Name = "lblMensajeConsultas";
            this.lblMensajeConsultas.Size = new System.Drawing.Size(218, 34);
            this.lblMensajeConsultas.TabIndex = 2;
            this.lblMensajeConsultas.Text = "Realize sus consultas";
            // 
            // tpRegistroVinculacion
            // 
            this.tpRegistroVinculacion.Controls.Add(this.pnlVinculacion);
            this.tpRegistroVinculacion.Location = new System.Drawing.Point(4, 22);
            this.tpRegistroVinculacion.Name = "tpRegistroVinculacion";
            this.tpRegistroVinculacion.Padding = new System.Windows.Forms.Padding(3);
            this.tpRegistroVinculacion.Size = new System.Drawing.Size(999, 510);
            this.tpRegistroVinculacion.TabIndex = 2;
            this.tpRegistroVinculacion.Text = "Registro Vinculacion Artista - Asociacion";
            this.tpRegistroVinculacion.UseVisualStyleBackColor = true;
            this.tpRegistroVinculacion.Enter += new System.EventHandler(this.tpRegistroVinculacion_Enter);
            this.tpRegistroVinculacion.Leave += new System.EventHandler(this.tpRegistroVinculacion_Leave);
            // 
            // pnlVinculacion
            // 
            this.pnlVinculacion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlVinculacion.Controls.Add(this.chkFechaFin);
            this.pnlVinculacion.Controls.Add(this.lblTituloDgvArtistas);
            this.pnlVinculacion.Controls.Add(this.labelTituloDgvAsociaciones);
            this.pnlVinculacion.Controls.Add(this.lblCodigoArtistaVincular);
            this.pnlVinculacion.Controls.Add(this.lblNitAsociacionVincular);
            this.pnlVinculacion.Controls.Add(this.lblCodigoArtistaSeleccionado);
            this.pnlVinculacion.Controls.Add(this.lblNitAsociacionSeleccionada);
            this.pnlVinculacion.Controls.Add(this.btnRegistrarVinculacion);
            this.pnlVinculacion.Controls.Add(this.lblFechaInicio);
            this.pnlVinculacion.Controls.Add(this.dtpFechaFin);
            this.pnlVinculacion.Controls.Add(this.dtpFechaInicio);
            this.pnlVinculacion.Controls.Add(this.dgvSeleccionArtista);
            this.pnlVinculacion.Controls.Add(this.dgvSeleccionAsociacion);
            this.pnlVinculacion.Controls.Add(this.txtId);
            this.pnlVinculacion.Controls.Add(this.lblId);
            this.pnlVinculacion.Controls.Add(this.lblMensajeVinculacion1);
            this.pnlVinculacion.Controls.Add(this.lblMensajeVinculacion2);
            this.pnlVinculacion.Location = new System.Drawing.Point(0, 0);
            this.pnlVinculacion.Name = "pnlVinculacion";
            this.pnlVinculacion.Size = new System.Drawing.Size(999, 510);
            this.pnlVinculacion.TabIndex = 0;
            // 
            // chkFechaFin
            // 
            this.chkFechaFin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chkFechaFin.AutoSize = true;
            this.chkFechaFin.Font = new System.Drawing.Font("Poppins", 9.75F);
            this.chkFechaFin.Location = new System.Drawing.Point(387, 469);
            this.chkFechaFin.Name = "chkFechaFin";
            this.chkFechaFin.Size = new System.Drawing.Size(87, 27);
            this.chkFechaFin.TabIndex = 22;
            this.chkFechaFin.Text = "Fecha fin";
            this.chkFechaFin.UseVisualStyleBackColor = true;
            // 
            // lblTituloDgvArtistas
            // 
            this.lblTituloDgvArtistas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTituloDgvArtistas.AutoSize = true;
            this.lblTituloDgvArtistas.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloDgvArtistas.Location = new System.Drawing.Point(709, 170);
            this.lblTituloDgvArtistas.Name = "lblTituloDgvArtistas";
            this.lblTituloDgvArtistas.Size = new System.Drawing.Size(60, 23);
            this.lblTituloDgvArtistas.TabIndex = 21;
            this.lblTituloDgvArtistas.Text = "Artistas";
            this.lblTituloDgvArtistas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTituloDgvAsociaciones
            // 
            this.labelTituloDgvAsociaciones.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTituloDgvAsociaciones.AutoSize = true;
            this.labelTituloDgvAsociaciones.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTituloDgvAsociaciones.Location = new System.Drawing.Point(227, 170);
            this.labelTituloDgvAsociaciones.Name = "labelTituloDgvAsociaciones";
            this.labelTituloDgvAsociaciones.Size = new System.Drawing.Size(96, 23);
            this.labelTituloDgvAsociaciones.TabIndex = 20;
            this.labelTituloDgvAsociaciones.Text = "Asociaciones";
            this.labelTituloDgvAsociaciones.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCodigoArtistaVincular
            // 
            this.lblCodigoArtistaVincular.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCodigoArtistaVincular.AutoSize = true;
            this.lblCodigoArtistaVincular.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoArtistaVincular.Location = new System.Drawing.Point(557, 428);
            this.lblCodigoArtistaVincular.Name = "lblCodigoArtistaVincular";
            this.lblCodigoArtistaVincular.Size = new System.Drawing.Size(126, 23);
            this.lblCodigoArtistaVincular.TabIndex = 19;
            this.lblCodigoArtistaVincular.Text = "Codigo a vincular:";
            this.lblCodigoArtistaVincular.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNitAsociacionVincular
            // 
            this.lblNitAsociacionVincular.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNitAsociacionVincular.AutoSize = true;
            this.lblNitAsociacionVincular.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNitAsociacionVincular.Location = new System.Drawing.Point(103, 428);
            this.lblNitAsociacionVincular.Name = "lblNitAsociacionVincular";
            this.lblNitAsociacionVincular.Size = new System.Drawing.Size(96, 23);
            this.lblNitAsociacionVincular.TabIndex = 18;
            this.lblNitAsociacionVincular.Text = "Nit A vincular:";
            this.lblNitAsociacionVincular.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCodigoArtistaSeleccionado
            // 
            this.lblCodigoArtistaSeleccionado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCodigoArtistaSeleccionado.AutoSize = true;
            this.lblCodigoArtistaSeleccionado.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoArtistaSeleccionado.Location = new System.Drawing.Point(709, 428);
            this.lblCodigoArtistaSeleccionado.Name = "lblCodigoArtistaSeleccionado";
            this.lblCodigoArtistaSeleccionado.Size = new System.Drawing.Size(38, 23);
            this.lblCodigoArtistaSeleccionado.TabIndex = 17;
            this.lblCodigoArtistaSeleccionado.Text = "----";
            this.lblCodigoArtistaSeleccionado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNitAsociacionSeleccionada
            // 
            this.lblNitAsociacionSeleccionada.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNitAsociacionSeleccionada.AutoSize = true;
            this.lblNitAsociacionSeleccionada.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNitAsociacionSeleccionada.Location = new System.Drawing.Point(227, 428);
            this.lblNitAsociacionSeleccionada.Name = "lblNitAsociacionSeleccionada";
            this.lblNitAsociacionSeleccionada.Size = new System.Drawing.Size(38, 23);
            this.lblNitAsociacionSeleccionada.TabIndex = 16;
            this.lblNitAsociacionSeleccionada.Text = "----";
            this.lblNitAsociacionSeleccionada.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRegistrarVinculacion
            // 
            this.btnRegistrarVinculacion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRegistrarVinculacion.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarVinculacion.Location = new System.Drawing.Point(750, 471);
            this.btnRegistrarVinculacion.Name = "btnRegistrarVinculacion";
            this.btnRegistrarVinculacion.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrarVinculacion.TabIndex = 15;
            this.btnRegistrarVinculacion.Text = "Registrar";
            this.btnRegistrarVinculacion.UseVisualStyleBackColor = true;
            this.btnRegistrarVinculacion.Click += new System.EventHandler(this.btnRegistrarVinculacion_Click);
            // 
            // lblFechaInicio
            // 
            this.lblFechaInicio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFechaInicio.AutoSize = true;
            this.lblFechaInicio.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaInicio.Location = new System.Drawing.Point(168, 471);
            this.lblFechaInicio.Name = "lblFechaInicio";
            this.lblFechaInicio.Size = new System.Drawing.Size(86, 23);
            this.lblFechaInicio.TabIndex = 12;
            this.lblFechaInicio.Text = "Fecha Inicio";
            this.lblFechaInicio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpFechaFin.CustomFormat = "dd/MM/yyyy";
            this.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaFin.Location = new System.Drawing.Point(480, 474);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(96, 20);
            this.dtpFechaFin.TabIndex = 11;
            this.dtpFechaFin.Value = new System.DateTime(2022, 7, 31, 14, 53, 25, 0);
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpFechaInicio.CustomFormat = "dd/MM/yyyy";
            this.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaInicio.Location = new System.Drawing.Point(260, 474);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(90, 20);
            this.dtpFechaInicio.TabIndex = 10;
            this.dtpFechaInicio.Value = new System.DateTime(2022, 8, 1, 0, 0, 0, 0);
            // 
            // dgvSeleccionArtista
            // 
            this.dgvSeleccionArtista.AllowUserToAddRows = false;
            this.dgvSeleccionArtista.AllowUserToDeleteRows = false;
            this.dgvSeleccionArtista.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvSeleccionArtista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSeleccionArtista.Location = new System.Drawing.Point(514, 196);
            this.dgvSeleccionArtista.Name = "dgvSeleccionArtista";
            this.dgvSeleccionArtista.ReadOnly = true;
            this.dgvSeleccionArtista.Size = new System.Drawing.Size(445, 229);
            this.dgvSeleccionArtista.TabIndex = 9;
            this.dgvSeleccionArtista.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvSeleccionArtista_CellMouseClick);
            // 
            // dgvSeleccionAsociacion
            // 
            this.dgvSeleccionAsociacion.AllowUserToAddRows = false;
            this.dgvSeleccionAsociacion.AllowUserToDeleteRows = false;
            this.dgvSeleccionAsociacion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvSeleccionAsociacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSeleccionAsociacion.Location = new System.Drawing.Point(37, 196);
            this.dgvSeleccionAsociacion.Name = "dgvSeleccionAsociacion";
            this.dgvSeleccionAsociacion.ReadOnly = true;
            this.dgvSeleccionAsociacion.Size = new System.Drawing.Size(450, 229);
            this.dgvSeleccionAsociacion.TabIndex = 8;
            this.dgvSeleccionAsociacion.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvSeleccionAsociacion_CellMouseClick);
            // 
            // txtId
            // 
            this.txtId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtId.Location = new System.Drawing.Point(424, 108);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(181, 20);
            this.txtId.TabIndex = 3;
            this.txtId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNit_KeyPress);
            // 
            // lblId
            // 
            this.lblId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(396, 107);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(22, 23);
            this.lblId.TabIndex = 2;
            this.lblId.Text = "ID";
            this.lblId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMensajeVinculacion1
            // 
            this.lblMensajeVinculacion1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMensajeVinculacion1.AutoSize = true;
            this.lblMensajeVinculacion1.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensajeVinculacion1.Location = new System.Drawing.Point(333, 59);
            this.lblMensajeVinculacion1.Name = "lblMensajeVinculacion1";
            this.lblMensajeVinculacion1.Size = new System.Drawing.Size(347, 34);
            this.lblMensajeVinculacion1.TabIndex = 1;
            this.lblMensajeVinculacion1.Text = "Ingrese los datos de la vinculacion";
            // 
            // lblMensajeVinculacion2
            // 
            this.lblMensajeVinculacion2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMensajeVinculacion2.AutoSize = true;
            this.lblMensajeVinculacion2.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensajeVinculacion2.Location = new System.Drawing.Point(168, 145);
            this.lblMensajeVinculacion2.Name = "lblMensajeVinculacion2";
            this.lblMensajeVinculacion2.Size = new System.Drawing.Size(657, 23);
            this.lblMensajeVinculacion2.TabIndex = 0;
            this.lblMensajeVinculacion2.Text = "Seleccione en las siguientes tablas cualquier  campo de la asociacion y el artist" +
    "a que desea vincular";
            this.lblMensajeVinculacion2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tpRegistroArtista
            // 
            this.tpRegistroArtista.Controls.Add(this.pnlRegistroArtista);
            this.tpRegistroArtista.Location = new System.Drawing.Point(4, 22);
            this.tpRegistroArtista.Name = "tpRegistroArtista";
            this.tpRegistroArtista.Padding = new System.Windows.Forms.Padding(3);
            this.tpRegistroArtista.Size = new System.Drawing.Size(999, 510);
            this.tpRegistroArtista.TabIndex = 1;
            this.tpRegistroArtista.Text = "Registro Artista";
            this.tpRegistroArtista.UseVisualStyleBackColor = true;
            // 
            // pnlRegistroArtista
            // 
            this.pnlRegistroArtista.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlRegistroArtista.Controls.Add(this.btnRegistrarArtista);
            this.pnlRegistroArtista.Controls.Add(this.dtpAnioNacimiento);
            this.pnlRegistroArtista.Controls.Add(this.txtNombreArtistico);
            this.pnlRegistroArtista.Controls.Add(this.cbxTipoArte);
            this.pnlRegistroArtista.Controls.Add(this.txtCodigo);
            this.pnlRegistroArtista.Controls.Add(this.lblAnioNacimiento);
            this.pnlRegistroArtista.Controls.Add(this.lblNombreArtistico);
            this.pnlRegistroArtista.Controls.Add(this.lblTipoArte);
            this.pnlRegistroArtista.Controls.Add(this.lblCodigo);
            this.pnlRegistroArtista.Controls.Add(this.lblMensajeArtista);
            this.pnlRegistroArtista.Location = new System.Drawing.Point(0, 0);
            this.pnlRegistroArtista.Name = "pnlRegistroArtista";
            this.pnlRegistroArtista.Size = new System.Drawing.Size(999, 510);
            this.pnlRegistroArtista.TabIndex = 0;
            // 
            // btnRegistrarArtista
            // 
            this.btnRegistrarArtista.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRegistrarArtista.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarArtista.Location = new System.Drawing.Point(594, 323);
            this.btnRegistrarArtista.Name = "btnRegistrarArtista";
            this.btnRegistrarArtista.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrarArtista.TabIndex = 10;
            this.btnRegistrarArtista.Text = "Registrar";
            this.btnRegistrarArtista.UseVisualStyleBackColor = true;
            this.btnRegistrarArtista.Click += new System.EventHandler(this.btnRegistrarArtista_Click);
            // 
            // dtpAnioNacimiento
            // 
            this.dtpAnioNacimiento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpAnioNacimiento.CustomFormat = "yyyy";
            this.dtpAnioNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpAnioNacimiento.Location = new System.Drawing.Point(431, 278);
            this.dtpAnioNacimiento.Name = "dtpAnioNacimiento";
            this.dtpAnioNacimiento.ShowUpDown = true;
            this.dtpAnioNacimiento.Size = new System.Drawing.Size(238, 20);
            this.dtpAnioNacimiento.TabIndex = 9;
            // 
            // txtNombreArtistico
            // 
            this.txtNombreArtistico.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNombreArtistico.Location = new System.Drawing.Point(431, 243);
            this.txtNombreArtistico.Name = "txtNombreArtistico";
            this.txtNombreArtistico.Size = new System.Drawing.Size(238, 20);
            this.txtNombreArtistico.TabIndex = 8;
            // 
            // cbxTipoArte
            // 
            this.cbxTipoArte.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbxTipoArte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTipoArte.FormattingEnabled = true;
            this.cbxTipoArte.Items.AddRange(new object[] {
            "pintura",
            "escultura",
            "danza",
            "teatro"});
            this.cbxTipoArte.Location = new System.Drawing.Point(431, 206);
            this.cbxTipoArte.Name = "cbxTipoArte";
            this.cbxTipoArte.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbxTipoArte.Size = new System.Drawing.Size(238, 21);
            this.cbxTipoArte.TabIndex = 7;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCodigo.Location = new System.Drawing.Point(431, 171);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(238, 20);
            this.txtCodigo.TabIndex = 6;
            this.txtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNit_KeyPress);
            // 
            // lblAnioNacimiento
            // 
            this.lblAnioNacimiento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAnioNacimiento.AutoSize = true;
            this.lblAnioNacimiento.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnioNacimiento.Location = new System.Drawing.Point(301, 280);
            this.lblAnioNacimiento.Name = "lblAnioNacimiento";
            this.lblAnioNacimiento.Size = new System.Drawing.Size(111, 23);
            this.lblAnioNacimiento.TabIndex = 4;
            this.lblAnioNacimiento.Text = "Año nacimiento";
            // 
            // lblNombreArtistico
            // 
            this.lblNombreArtistico.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNombreArtistico.AutoSize = true;
            this.lblNombreArtistico.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreArtistico.Location = new System.Drawing.Point(302, 243);
            this.lblNombreArtistico.Name = "lblNombreArtistico";
            this.lblNombreArtistico.Size = new System.Drawing.Size(118, 23);
            this.lblNombreArtistico.TabIndex = 3;
            this.lblNombreArtistico.Text = "Nombre Artistico";
            // 
            // lblTipoArte
            // 
            this.lblTipoArte.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTipoArte.AutoSize = true;
            this.lblTipoArte.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoArte.Location = new System.Drawing.Point(301, 206);
            this.lblTipoArte.Name = "lblTipoArte";
            this.lblTipoArte.Size = new System.Drawing.Size(67, 23);
            this.lblTipoArte.TabIndex = 2;
            this.lblTipoArte.Text = "Tipo arte";
            // 
            // lblCodigo
            // 
            this.lblCodigo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(301, 171);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(57, 23);
            this.lblCodigo.TabIndex = 1;
            this.lblCodigo.Text = "Codigo";
            // 
            // lblMensajeArtista
            // 
            this.lblMensajeArtista.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMensajeArtista.AutoSize = true;
            this.lblMensajeArtista.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensajeArtista.Location = new System.Drawing.Point(343, 97);
            this.lblMensajeArtista.Name = "lblMensajeArtista";
            this.lblMensajeArtista.Size = new System.Drawing.Size(280, 34);
            this.lblMensajeArtista.TabIndex = 0;
            this.lblMensajeArtista.Text = "Ingrese los datos del artista";
            // 
            // tpRegistroAsociacionArtista
            // 
            this.tpRegistroAsociacionArtista.Controls.Add(this.pnlRegistroAsociacion);
            this.tpRegistroAsociacionArtista.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpRegistroAsociacionArtista.Location = new System.Drawing.Point(4, 22);
            this.tpRegistroAsociacionArtista.Name = "tpRegistroAsociacionArtista";
            this.tpRegistroAsociacionArtista.Padding = new System.Windows.Forms.Padding(3);
            this.tpRegistroAsociacionArtista.Size = new System.Drawing.Size(999, 510);
            this.tpRegistroAsociacionArtista.TabIndex = 0;
            this.tpRegistroAsociacionArtista.Text = "Registro Asociacion Artistas";
            this.tpRegistroAsociacionArtista.UseVisualStyleBackColor = true;
            // 
            // pnlRegistroAsociacion
            // 
            this.pnlRegistroAsociacion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlRegistroAsociacion.Controls.Add(this.btnRegistrarAsociacion);
            this.pnlRegistroAsociacion.Controls.Add(this.txtNombre);
            this.pnlRegistroAsociacion.Controls.Add(this.txtNit);
            this.pnlRegistroAsociacion.Controls.Add(this.gboxModalidades);
            this.pnlRegistroAsociacion.Controls.Add(this.lblModalidad);
            this.pnlRegistroAsociacion.Controls.Add(this.lblNombre);
            this.pnlRegistroAsociacion.Controls.Add(this.lblNit);
            this.pnlRegistroAsociacion.Controls.Add(this.lblMensajeAsociacion);
            this.pnlRegistroAsociacion.Location = new System.Drawing.Point(0, 0);
            this.pnlRegistroAsociacion.Name = "pnlRegistroAsociacion";
            this.pnlRegistroAsociacion.Size = new System.Drawing.Size(1003, 510);
            this.pnlRegistroAsociacion.TabIndex = 0;
            // 
            // btnRegistrarAsociacion
            // 
            this.btnRegistrarAsociacion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRegistrarAsociacion.Location = new System.Drawing.Point(597, 368);
            this.btnRegistrarAsociacion.Name = "btnRegistrarAsociacion";
            this.btnRegistrarAsociacion.Size = new System.Drawing.Size(86, 29);
            this.btnRegistrarAsociacion.TabIndex = 7;
            this.btnRegistrarAsociacion.Text = "Registrar";
            this.btnRegistrarAsociacion.UseVisualStyleBackColor = true;
            this.btnRegistrarAsociacion.Click += new System.EventHandler(this.btnRegistrarAsociacion_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNombre.Location = new System.Drawing.Point(431, 211);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(252, 27);
            this.txtNombre.TabIndex = 6;
            // 
            // txtNit
            // 
            this.txtNit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNit.Location = new System.Drawing.Point(431, 172);
            this.txtNit.Name = "txtNit";
            this.txtNit.Size = new System.Drawing.Size(252, 27);
            this.txtNit.TabIndex = 5;
            this.txtNit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNit_KeyPress);
            // 
            // gboxModalidades
            // 
            this.gboxModalidades.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gboxModalidades.Controls.Add(this.rbSinAnimoDeLucro);
            this.gboxModalidades.Controls.Add(this.rbConAnimoDeLucro);
            this.gboxModalidades.Location = new System.Drawing.Point(431, 252);
            this.gboxModalidades.Name = "gboxModalidades";
            this.gboxModalidades.Size = new System.Drawing.Size(252, 100);
            this.gboxModalidades.TabIndex = 4;
            this.gboxModalidades.TabStop = false;
            this.gboxModalidades.Text = "modalidades";
            // 
            // rbSinAnimoDeLucro
            // 
            this.rbSinAnimoDeLucro.AutoSize = true;
            this.rbSinAnimoDeLucro.Location = new System.Drawing.Point(49, 59);
            this.rbSinAnimoDeLucro.Name = "rbSinAnimoDeLucro";
            this.rbSinAnimoDeLucro.Size = new System.Drawing.Size(145, 27);
            this.rbSinAnimoDeLucro.TabIndex = 1;
            this.rbSinAnimoDeLucro.Text = "sin animo de lucro";
            this.rbSinAnimoDeLucro.UseVisualStyleBackColor = true;
            // 
            // rbConAnimoDeLucro
            // 
            this.rbConAnimoDeLucro.AutoSize = true;
            this.rbConAnimoDeLucro.Checked = true;
            this.rbConAnimoDeLucro.Location = new System.Drawing.Point(49, 26);
            this.rbConAnimoDeLucro.Name = "rbConAnimoDeLucro";
            this.rbConAnimoDeLucro.Size = new System.Drawing.Size(151, 27);
            this.rbConAnimoDeLucro.TabIndex = 0;
            this.rbConAnimoDeLucro.TabStop = true;
            this.rbConAnimoDeLucro.Text = "con animo de lucro";
            this.rbConAnimoDeLucro.UseVisualStyleBackColor = true;
            // 
            // lblModalidad
            // 
            this.lblModalidad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblModalidad.AutoSize = true;
            this.lblModalidad.Location = new System.Drawing.Point(341, 252);
            this.lblModalidad.Name = "lblModalidad";
            this.lblModalidad.Size = new System.Drawing.Size(80, 23);
            this.lblModalidad.TabIndex = 3;
            this.lblModalidad.Text = "Modalidad";
            // 
            // lblNombre
            // 
            this.lblNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(341, 211);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(62, 23);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre";
            // 
            // lblNit
            // 
            this.lblNit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNit.AutoSize = true;
            this.lblNit.Location = new System.Drawing.Point(341, 172);
            this.lblNit.Name = "lblNit";
            this.lblNit.Size = new System.Drawing.Size(29, 23);
            this.lblNit.TabIndex = 1;
            this.lblNit.Text = "NIT";
            // 
            // lblMensajeAsociacion
            // 
            this.lblMensajeAsociacion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMensajeAsociacion.AutoSize = true;
            this.lblMensajeAsociacion.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensajeAsociacion.Location = new System.Drawing.Point(341, 117);
            this.lblMensajeAsociacion.Name = "lblMensajeAsociacion";
            this.lblMensajeAsociacion.Size = new System.Drawing.Size(342, 34);
            this.lblMensajeAsociacion.TabIndex = 0;
            this.lblMensajeAsociacion.Text = "Ingrese los datos de la asociacion";
            // 
            // tbcGestion
            // 
            this.tbcGestion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbcGestion.Controls.Add(this.tpRegistroAsociacionArtista);
            this.tbcGestion.Controls.Add(this.tpRegistroArtista);
            this.tbcGestion.Controls.Add(this.tpRegistroVinculacion);
            this.tbcGestion.Controls.Add(this.tpConsultas);
            this.tbcGestion.Location = new System.Drawing.Point(1, 1);
            this.tbcGestion.Name = "tbcGestion";
            this.tbcGestion.SelectedIndex = 0;
            this.tbcGestion.Size = new System.Drawing.Size(1007, 536);
            this.tbcGestion.TabIndex = 0;
            // 
            // frmArtistas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 536);
            this.Controls.Add(this.tbcGestion);
            this.Name = "frmArtistas";
            this.Text = "Gestion Artista";
            this.Load += new System.EventHandler(this.frmArtistas_Load);
            this.tpConsultas.ResumeLayout(false);
            this.pnlConsultas.ResumeLayout(false);
            this.pnlConsultas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeleccionVinculacion)).EndInit();
            this.tpRegistroVinculacion.ResumeLayout(false);
            this.pnlVinculacion.ResumeLayout(false);
            this.pnlVinculacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeleccionArtista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeleccionAsociacion)).EndInit();
            this.tpRegistroArtista.ResumeLayout(false);
            this.pnlRegistroArtista.ResumeLayout(false);
            this.pnlRegistroArtista.PerformLayout();
            this.tpRegistroAsociacionArtista.ResumeLayout(false);
            this.pnlRegistroAsociacion.ResumeLayout(false);
            this.pnlRegistroAsociacion.PerformLayout();
            this.gboxModalidades.ResumeLayout(false);
            this.gboxModalidades.PerformLayout();
            this.tbcGestion.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tpConsultas;
        private System.Windows.Forms.TabPage tpRegistroVinculacion;
        private System.Windows.Forms.TabPage tpRegistroArtista;
        private System.Windows.Forms.TabPage tpRegistroAsociacionArtista;
        private System.Windows.Forms.TabControl tbcGestion;
        private System.Windows.Forms.Panel pnlRegistroAsociacion;
        private System.Windows.Forms.Panel pnlVinculacion;
        private System.Windows.Forms.Panel pnlRegistroArtista;
        private System.Windows.Forms.Label lblMensajeAsociacion;
        private System.Windows.Forms.Label lblModalidad;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblNit;
        private System.Windows.Forms.GroupBox gboxModalidades;
        private System.Windows.Forms.RadioButton rbSinAnimoDeLucro;
        private System.Windows.Forms.RadioButton rbConAnimoDeLucro;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtNit;
        private System.Windows.Forms.Button btnRegistrarAsociacion;
        private System.Windows.Forms.Panel pnlConsultas;
        private System.Windows.Forms.Label lblAnioNacimiento;
        private System.Windows.Forms.Label lblNombreArtistico;
        private System.Windows.Forms.Label lblTipoArte;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblMensajeArtista;
        private System.Windows.Forms.ComboBox cbxTipoArte;
        private System.Windows.Forms.TextBox txtNombreArtistico;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.DateTimePicker dtpAnioNacimiento;
        private System.Windows.Forms.Button btnRegistrarArtista;
        private System.Windows.Forms.Label lblMensajeVinculacion2;
        private System.Windows.Forms.Label lblMensajeVinculacion1;
        private System.Windows.Forms.Button btnRegistrarVinculacion;
        private System.Windows.Forms.Label lblFechaInicio;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.DataGridView dgvSeleccionArtista;
        private System.Windows.Forms.DataGridView dgvSeleccionAsociacion;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.DataGridView dgvSeleccionVinculacion;
        private System.Windows.Forms.Button btnConsultaPorFechaVinculacion1;
        private System.Windows.Forms.DateTimePicker dtpConsFechaInicioVinculacion;
        private System.Windows.Forms.Label lblMensajeFechaInicioVinculacion;
        private System.Windows.Forms.Label lblMensajeConsultas;
        private System.Windows.Forms.Label lblCodigoArtistaSeleccionado;
        private System.Windows.Forms.Label lblNitAsociacionSeleccionada;
        private System.Windows.Forms.Button btnNumPintores;
        private System.Windows.Forms.Label lblNumeroPintores;
        private System.Windows.Forms.Label lblCodigoArtistaVincular;
        private System.Windows.Forms.Label lblNitAsociacionVincular;
        private System.Windows.Forms.Label lblTituloDgvArtistas;
        private System.Windows.Forms.Label labelTituloDgvAsociaciones;
        private System.Windows.Forms.CheckBox chkFechaFin;
    }
}

