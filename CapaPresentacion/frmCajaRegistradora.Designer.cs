﻿
namespace CapaPresentacion
{
    partial class frmCajaRegistradora
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDocAsociado = new System.Windows.Forms.TextBox();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.txtHora = new System.Windows.Forms.TextBox();
            this.cboTipoMovimiento = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.btnSeleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.idCajaRegistradora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idTransaccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.concepto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoTransaccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.formaPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cajaAsociada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.docAsociado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioTransaccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtIndice = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new FontAwesome.Sharp.IconButton();
            this.btnBuscar = new FontAwesome.Sharp.IconButton();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.cboBusqueda = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtIdTransaccion = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnCerrarCaja = new FontAwesome.Sharp.IconButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnGuardar = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.txtSaldoInicial = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cboFormaPago = new System.Windows.Forms.ComboBox();
            this.Tipo = new System.Windows.Forms.Label();
            this.txtSaldoInicialMP = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSaldoMP = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtSaldoInicialUSS = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtSaldoUSS = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtSaldoInicialGalicia = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtSaldoGalicia = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.cboCajaAsociada = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.btnEliminar = new FontAwesome.Sharp.IconButton();
            this.btnLimpiarDatos = new FontAwesome.Sharp.IconButton();
            this.txtIdCompra = new System.Windows.Forms.TextBox();
            this.txtIdVenta = new System.Windows.Forms.TextBox();
            this.cboConcepto = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(83)))), ((int)(((byte)(150)))));
            this.label10.Location = new System.Drawing.Point(502, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(848, 729);
            this.label10.TabIndex = 78;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.label9.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label9.Location = new System.Drawing.Point(12, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(265, 32);
            this.label9.TabIndex = 76;
            this.label9.Text = "CAJA REGISTRADORA";
            // 
            // txtDocAsociado
            // 
            this.txtDocAsociado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDocAsociado.Location = new System.Drawing.Point(171, 295);
            this.txtDocAsociado.Name = "txtDocAsociado";
            this.txtDocAsociado.Size = new System.Drawing.Size(178, 20);
            this.txtDocAsociado.TabIndex = 75;
            // 
            // txtMonto
            // 
            this.txtMonto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMonto.Location = new System.Drawing.Point(172, 230);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(178, 20);
            this.txtMonto.TabIndex = 74;
            // 
            // txtHora
            // 
            this.txtHora.Enabled = false;
            this.txtHora.Location = new System.Drawing.Point(172, 88);
            this.txtHora.Name = "txtHora";
            this.txtHora.Size = new System.Drawing.Size(178, 20);
            this.txtHora.TabIndex = 72;
            this.txtHora.Visible = false;
            // 
            // cboTipoMovimiento
            // 
            this.cboTipoMovimiento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoMovimiento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboTipoMovimiento.FormattingEnabled = true;
            this.cboTipoMovimiento.Location = new System.Drawing.Point(172, 127);
            this.cboTipoMovimiento.Name = "cboTipoMovimiento";
            this.cboTipoMovimiento.Size = new System.Drawing.Size(178, 21);
            this.cboTipoMovimiento.TabIndex = 71;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(180)))), ((int)(((byte)(140)))));
            this.label5.Location = new System.Drawing.Point(15, 295);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 17);
            this.label5.TabIndex = 69;
            this.label5.Text = "Detalle";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(180)))), ((int)(((byte)(140)))));
            this.label4.Location = new System.Drawing.Point(12, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 68;
            this.label4.Text = "Monto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(180)))), ((int)(((byte)(140)))));
            this.label3.Location = new System.Drawing.Point(12, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 17);
            this.label3.TabIndex = 67;
            this.label3.Text = "Tipo Movimiento";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(180)))), ((int)(((byte)(140)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(502, 729);
            this.label1.TabIndex = 65;
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.AllowUserToDeleteRows = false;
            this.dgvData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvData.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.dgvData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnSeleccionar,
            this.idCajaRegistradora,
            this.idTransaccion,
            this.hora,
            this.concepto,
            this.tipoTransaccion,
            this.monto,
            this.formaPago,
            this.cajaAsociada,
            this.docAsociado,
            this.usuarioTransaccion,
            this.idCompra,
            this.idVenta});
            this.dgvData.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvData.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvData.GridColor = System.Drawing.Color.White;
            this.dgvData.Location = new System.Drawing.Point(514, 156);
            this.dgvData.MultiSelect = false;
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvData.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(83)))), ((int)(((byte)(150)))));
            this.dgvData.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvData.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgvData.RowTemplate.Height = 28;
            this.dgvData.Size = new System.Drawing.Size(824, 373);
            this.dgvData.TabIndex = 82;
            this.dgvData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellContentClick);
            this.dgvData.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvData_CellPainting);
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.btnSeleccionar.HeaderText = "";
            this.btnSeleccionar.MinimumWidth = 30;
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.ReadOnly = true;
            this.btnSeleccionar.Width = 30;
            // 
            // idCajaRegistradora
            // 
            this.idCajaRegistradora.HeaderText = "ID CAJA";
            this.idCajaRegistradora.Name = "idCajaRegistradora";
            this.idCajaRegistradora.ReadOnly = true;
            this.idCajaRegistradora.Visible = false;
            this.idCajaRegistradora.Width = 83;
            // 
            // idTransaccion
            // 
            this.idTransaccion.HeaderText = "ID TRANSACCION";
            this.idTransaccion.Name = "idTransaccion";
            this.idTransaccion.ReadOnly = true;
            this.idTransaccion.Visible = false;
            this.idTransaccion.Width = 140;
            // 
            // hora
            // 
            this.hora.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.hora.HeaderText = "FECHA Y HORA";
            this.hora.Name = "hora";
            this.hora.ReadOnly = true;
            this.hora.Width = 125;
            // 
            // concepto
            // 
            this.concepto.HeaderText = "CONCEPTO";
            this.concepto.Name = "concepto";
            this.concepto.ReadOnly = true;
            // 
            // tipoTransaccion
            // 
            this.tipoTransaccion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.tipoTransaccion.HeaderText = "MOVIMIENTO";
            this.tipoTransaccion.Name = "tipoTransaccion";
            this.tipoTransaccion.ReadOnly = true;
            // 
            // monto
            // 
            this.monto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.monto.HeaderText = "MONTO";
            this.monto.Name = "monto";
            this.monto.ReadOnly = true;
            this.monto.Width = 85;
            // 
            // formaPago
            // 
            this.formaPago.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.formaPago.HeaderText = "FORMA DE PAGO";
            this.formaPago.Name = "formaPago";
            this.formaPago.ReadOnly = true;
            // 
            // cajaAsociada
            // 
            this.cajaAsociada.HeaderText = "CAJA ASOCIADA";
            this.cajaAsociada.Name = "cajaAsociada";
            this.cajaAsociada.ReadOnly = true;
            // 
            // docAsociado
            // 
            this.docAsociado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.docAsociado.HeaderText = "DETALLE";
            this.docAsociado.Name = "docAsociado";
            this.docAsociado.ReadOnly = true;
            // 
            // usuarioTransaccion
            // 
            this.usuarioTransaccion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.usuarioTransaccion.HeaderText = "USUARIO TRANSACCION";
            this.usuarioTransaccion.Name = "usuarioTransaccion";
            this.usuarioTransaccion.ReadOnly = true;
            this.usuarioTransaccion.Width = 166;
            // 
            // idCompra
            // 
            this.idCompra.HeaderText = "ID COMPRA";
            this.idCompra.Name = "idCompra";
            this.idCompra.ReadOnly = true;
            this.idCompra.Visible = false;
            // 
            // idVenta
            // 
            this.idVenta.HeaderText = "ID VENTA";
            this.idVenta.Name = "idVenta";
            this.idVenta.ReadOnly = true;
            this.idVenta.Visible = false;
            // 
            // txtIndice
            // 
            this.txtIndice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtIndice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIndice.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIndice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(180)))), ((int)(((byte)(140)))));
            this.txtIndice.Location = new System.Drawing.Point(313, 37);
            this.txtIndice.Name = "txtIndice";
            this.txtIndice.Size = new System.Drawing.Size(36, 18);
            this.txtIndice.TabIndex = 90;
            this.txtIndice.Text = "-1";
            this.txtIndice.Visible = false;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.White;
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLimpiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnLimpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(216)))), ((int)(((byte)(212)))));
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.btnLimpiar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(83)))), ((int)(((byte)(150)))));
            this.btnLimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLimpiar.IconSize = 28;
            this.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiar.Location = new System.Drawing.Point(1054, 100);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(35, 26);
            this.btnLimpiar.TabIndex = 89;
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.White;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(216)))), ((int)(((byte)(212)))));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnBuscar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(83)))), ((int)(((byte)(150)))));
            this.btnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscar.IconSize = 28;
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(1013, 100);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(35, 26);
            this.btnBuscar.TabIndex = 88;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBusqueda.Location = new System.Drawing.Point(758, 106);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(239, 20);
            this.txtBusqueda.TabIndex = 87;
            this.txtBusqueda.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBusqueda_KeyDown);
            // 
            // cboBusqueda
            // 
            this.cboBusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBusqueda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboBusqueda.FormattingEnabled = true;
            this.cboBusqueda.Location = new System.Drawing.Point(595, 105);
            this.cboBusqueda.Name = "cboBusqueda";
            this.cboBusqueda.Size = new System.Drawing.Size(157, 21);
            this.cboBusqueda.TabIndex = 86;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(46)))), ((int)(((byte)(37)))));
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(511, 104);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 17);
            this.label12.TabIndex = 85;
            this.label12.Text = "Buscar por:";
            // 
            // txtIdTransaccion
            // 
            this.txtIdTransaccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtIdTransaccion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIdTransaccion.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdTransaccion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(180)))), ((int)(((byte)(140)))));
            this.txtIdTransaccion.Location = new System.Drawing.Point(341, 38);
            this.txtIdTransaccion.Name = "txtIdTransaccion";
            this.txtIdTransaccion.Size = new System.Drawing.Size(23, 18);
            this.txtIdTransaccion.TabIndex = 84;
            this.txtIdTransaccion.Text = "0";
            this.txtIdTransaccion.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(46)))), ((int)(((byte)(37)))));
            this.label11.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label11.Location = new System.Drawing.Point(508, 26);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(261, 32);
            this.label11.TabIndex = 83;
            this.label11.Text = "MOVIMIENTOS CAJA ";
            // 
            // btnCerrarCaja
            // 
            this.btnCerrarCaja.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCerrarCaja.BackColor = System.Drawing.Color.Maroon;
            this.btnCerrarCaja.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarCaja.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(216)))), ((int)(((byte)(212)))));
            this.btnCerrarCaja.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnCerrarCaja.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(216)))), ((int)(((byte)(212)))));
            this.btnCerrarCaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarCaja.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarCaja.ForeColor = System.Drawing.Color.White;
            this.btnCerrarCaja.IconChar = FontAwesome.Sharp.IconChar.CheckSquare;
            this.btnCerrarCaja.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(180)))), ((int)(((byte)(140)))));
            this.btnCerrarCaja.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCerrarCaja.IconSize = 28;
            this.btnCerrarCaja.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrarCaja.Location = new System.Drawing.Point(1149, 639);
            this.btnCerrarCaja.Name = "btnCerrarCaja";
            this.btnCerrarCaja.Size = new System.Drawing.Size(165, 31);
            this.btnCerrarCaja.TabIndex = 81;
            this.btnCerrarCaja.Text = "Cerrar Caja";
            this.btnCerrarCaja.UseVisualStyleBackColor = false;
            this.btnCerrarCaja.Click += new System.EventHandler(this.btnCerrarCaja_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(46)))), ((int)(((byte)(37)))));
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(502, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(848, 729);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 79;
            this.pictureBox1.TabStop = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(46)))), ((int)(((byte)(37)))));
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(216)))), ((int)(((byte)(212)))));
            this.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(216)))), ((int)(((byte)(212)))));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.IconChar = FontAwesome.Sharp.IconChar.FileShield;
            this.btnGuardar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(180)))), ((int)(((byte)(140)))));
            this.btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGuardar.IconSize = 28;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(3, 357);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(227, 31);
            this.btnGuardar.TabIndex = 77;
            this.btnGuardar.Text = "Registrar Movimiento";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(180)))), ((int)(((byte)(140)))));
            this.label2.Location = new System.Drawing.Point(12, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 66;
            this.label2.Text = "Hora";
            this.label2.Visible = false;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(46)))), ((int)(((byte)(37)))));
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(840, 552);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 17);
            this.label6.TabIndex = 94;
            this.label6.Text = "Saldo Efectivo:";
            // 
            // txtSaldo
            // 
            this.txtSaldo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtSaldo.Location = new System.Drawing.Point(977, 552);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.ReadOnly = true;
            this.txtSaldo.Size = new System.Drawing.Size(161, 20);
            this.txtSaldo.TabIndex = 95;
            this.txtSaldo.Text = "0";
            // 
            // txtSaldoInicial
            // 
            this.txtSaldoInicial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtSaldoInicial.Location = new System.Drawing.Point(700, 552);
            this.txtSaldoInicial.Name = "txtSaldoInicial";
            this.txtSaldoInicial.ReadOnly = true;
            this.txtSaldoInicial.Size = new System.Drawing.Size(134, 20);
            this.txtSaldoInicial.TabIndex = 97;
            this.txtSaldoInicial.Text = "0";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(46)))), ((int)(((byte)(37)))));
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(511, 552);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(157, 17);
            this.label7.TabIndex = 96;
            this.label7.Text = "Saldo  Apertura Caja   $:";
            // 
            // cboFormaPago
            // 
            this.cboFormaPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFormaPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboFormaPago.FormattingEnabled = true;
            this.cboFormaPago.Location = new System.Drawing.Point(172, 165);
            this.cboFormaPago.Name = "cboFormaPago";
            this.cboFormaPago.Size = new System.Drawing.Size(178, 21);
            this.cboFormaPago.TabIndex = 99;
            // 
            // Tipo
            // 
            this.Tipo.AutoSize = true;
            this.Tipo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Tipo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(180)))), ((int)(((byte)(140)))));
            this.Tipo.Location = new System.Drawing.Point(12, 169);
            this.Tipo.Name = "Tipo";
            this.Tipo.Size = new System.Drawing.Size(101, 17);
            this.Tipo.TabIndex = 98;
            this.Tipo.Text = "Forma de Pago";
            // 
            // txtSaldoInicialMP
            // 
            this.txtSaldoInicialMP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtSaldoInicialMP.Location = new System.Drawing.Point(700, 585);
            this.txtSaldoInicialMP.Name = "txtSaldoInicialMP";
            this.txtSaldoInicialMP.ReadOnly = true;
            this.txtSaldoInicialMP.Size = new System.Drawing.Size(134, 20);
            this.txtSaldoInicialMP.TabIndex = 103;
            this.txtSaldoInicialMP.Text = "0";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(46)))), ((int)(((byte)(37)))));
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(511, 585);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(162, 17);
            this.label8.TabIndex = 102;
            this.label8.Text = "Saldo  Apertura Caja MP:";
            // 
            // txtSaldoMP
            // 
            this.txtSaldoMP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtSaldoMP.Location = new System.Drawing.Point(977, 585);
            this.txtSaldoMP.Name = "txtSaldoMP";
            this.txtSaldoMP.ReadOnly = true;
            this.txtSaldoMP.Size = new System.Drawing.Size(161, 20);
            this.txtSaldoMP.TabIndex = 101;
            this.txtSaldoMP.Text = "0";
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(46)))), ((int)(((byte)(37)))));
            this.label13.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(840, 585);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(138, 17);
            this.label13.TabIndex = 100;
            this.label13.Text = "Saldo Mercado Pago:";
            // 
            // txtSaldoInicialUSS
            // 
            this.txtSaldoInicialUSS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtSaldoInicialUSS.Location = new System.Drawing.Point(700, 615);
            this.txtSaldoInicialUSS.Name = "txtSaldoInicialUSS";
            this.txtSaldoInicialUSS.ReadOnly = true;
            this.txtSaldoInicialUSS.Size = new System.Drawing.Size(134, 20);
            this.txtSaldoInicialUSS.TabIndex = 107;
            this.txtSaldoInicialUSS.Text = "0";
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(46)))), ((int)(((byte)(37)))));
            this.label14.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(511, 615);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(165, 17);
            this.label14.TabIndex = 106;
            this.label14.Text = "Saldo  Apertura Caja U$S:";
            // 
            // txtSaldoUSS
            // 
            this.txtSaldoUSS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtSaldoUSS.Location = new System.Drawing.Point(977, 615);
            this.txtSaldoUSS.Name = "txtSaldoUSS";
            this.txtSaldoUSS.ReadOnly = true;
            this.txtSaldoUSS.Size = new System.Drawing.Size(161, 20);
            this.txtSaldoUSS.TabIndex = 105;
            this.txtSaldoUSS.Text = "0";
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(46)))), ((int)(((byte)(37)))));
            this.label15.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(840, 615);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(97, 17);
            this.label15.TabIndex = 104;
            this.label15.Text = "Saldo Dolares:";
            // 
            // txtSaldoInicialGalicia
            // 
            this.txtSaldoInicialGalicia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtSaldoInicialGalicia.Location = new System.Drawing.Point(700, 647);
            this.txtSaldoInicialGalicia.Name = "txtSaldoInicialGalicia";
            this.txtSaldoInicialGalicia.ReadOnly = true;
            this.txtSaldoInicialGalicia.Size = new System.Drawing.Size(134, 20);
            this.txtSaldoInicialGalicia.TabIndex = 111;
            this.txtSaldoInicialGalicia.Text = "0";
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(46)))), ((int)(((byte)(37)))));
            this.label16.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(511, 647);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(183, 17);
            this.label16.TabIndex = 110;
            this.label16.Text = "Saldo  Apertura Caja Galicia:";
            // 
            // txtSaldoGalicia
            // 
            this.txtSaldoGalicia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtSaldoGalicia.Location = new System.Drawing.Point(977, 647);
            this.txtSaldoGalicia.Name = "txtSaldoGalicia";
            this.txtSaldoGalicia.ReadOnly = true;
            this.txtSaldoGalicia.Size = new System.Drawing.Size(161, 20);
            this.txtSaldoGalicia.TabIndex = 109;
            this.txtSaldoGalicia.Text = "0";
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(46)))), ((int)(((byte)(37)))));
            this.label17.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(840, 647);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(91, 17);
            this.label17.TabIndex = 108;
            this.label17.Text = "Saldo Galicia:";
            // 
            // cboCajaAsociada
            // 
            this.cboCajaAsociada.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCajaAsociada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboCajaAsociada.FormattingEnabled = true;
            this.cboCajaAsociada.Items.AddRange(new object[] {
            "GALICIA",
            "EFECTIVO",
            "MERCADO PAGO",
            "DOLARES"});
            this.cboCajaAsociada.Location = new System.Drawing.Point(172, 201);
            this.cboCajaAsociada.Name = "cboCajaAsociada";
            this.cboCajaAsociada.Size = new System.Drawing.Size(178, 21);
            this.cboCajaAsociada.TabIndex = 113;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.label18.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(180)))), ((int)(((byte)(140)))));
            this.label18.Location = new System.Drawing.Point(12, 201);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(93, 17);
            this.label18.TabIndex = 112;
            this.label18.Text = "Caja Asociada";
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Maroon;
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(216)))), ((int)(((byte)(212)))));
            this.btnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(216)))), ((int)(((byte)(212)))));
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnEliminar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(180)))), ((int)(((byte)(140)))));
            this.btnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEliminar.IconSize = 28;
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(236, 357);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(140, 31);
            this.btnEliminar.TabIndex = 114;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnLimpiarDatos
            // 
            this.btnLimpiarDatos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(83)))), ((int)(((byte)(150)))));
            this.btnLimpiarDatos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiarDatos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(216)))), ((int)(((byte)(212)))));
            this.btnLimpiarDatos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnLimpiarDatos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(216)))), ((int)(((byte)(212)))));
            this.btnLimpiarDatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarDatos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarDatos.ForeColor = System.Drawing.Color.White;
            this.btnLimpiarDatos.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.btnLimpiarDatos.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(180)))), ((int)(((byte)(140)))));
            this.btnLimpiarDatos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLimpiarDatos.IconSize = 28;
            this.btnLimpiarDatos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiarDatos.Location = new System.Drawing.Point(382, 357);
            this.btnLimpiarDatos.Name = "btnLimpiarDatos";
            this.btnLimpiarDatos.Size = new System.Drawing.Size(114, 31);
            this.btnLimpiarDatos.TabIndex = 115;
            this.btnLimpiarDatos.Text = "Limpiar";
            this.btnLimpiarDatos.UseVisualStyleBackColor = false;
            this.btnLimpiarDatos.Click += new System.EventHandler(this.btnLimpiarDatos_Click);
            // 
            // txtIdCompra
            // 
            this.txtIdCompra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtIdCompra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIdCompra.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdCompra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(180)))), ((int)(((byte)(140)))));
            this.txtIdCompra.Location = new System.Drawing.Point(404, 36);
            this.txtIdCompra.Name = "txtIdCompra";
            this.txtIdCompra.Size = new System.Drawing.Size(36, 18);
            this.txtIdCompra.TabIndex = 116;
            this.txtIdCompra.Text = "0";
            this.txtIdCompra.Visible = false;
            // 
            // txtIdVenta
            // 
            this.txtIdVenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txtIdVenta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIdVenta.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdVenta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(180)))), ((int)(((byte)(140)))));
            this.txtIdVenta.Location = new System.Drawing.Point(460, 36);
            this.txtIdVenta.Name = "txtIdVenta";
            this.txtIdVenta.Size = new System.Drawing.Size(36, 18);
            this.txtIdVenta.TabIndex = 117;
            this.txtIdVenta.Text = "0";
            this.txtIdVenta.Visible = false;
            // 
            // cboConcepto
            // 
            this.cboConcepto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboConcepto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboConcepto.FormattingEnabled = true;
            this.cboConcepto.Location = new System.Drawing.Point(171, 262);
            this.cboConcepto.Name = "cboConcepto";
            this.cboConcepto.Size = new System.Drawing.Size(178, 21);
            this.cboConcepto.TabIndex = 119;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.label19.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(180)))), ((int)(((byte)(140)))));
            this.label19.Location = new System.Drawing.Point(15, 266);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(66, 17);
            this.label19.TabIndex = 118;
            this.label19.Text = "Concepto";
            // 
            // frmCajaRegistradora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.cboConcepto);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.txtIdVenta);
            this.Controls.Add(this.txtIdCompra);
            this.Controls.Add(this.btnLimpiarDatos);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.cboCajaAsociada);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.txtSaldoInicialGalicia);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtSaldoGalicia);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtSaldoInicialUSS);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtSaldoUSS);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtSaldoInicialMP);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtSaldoMP);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.cboFormaPago);
            this.Controls.Add(this.Tipo);
            this.Controls.Add(this.txtSaldoInicial);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtSaldo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtDocAsociado);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.txtHora);
            this.Controls.Add(this.cboTipoMovimiento);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.txtIndice);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.cboBusqueda);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtIdTransaccion);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnCerrarCaja);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label1);
            this.Name = "frmCajaRegistradora";
            this.Text = "frmCajaRegistradora";
            this.Load += new System.EventHandler(this.frmCajaRegistradora_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDocAsociado;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.TextBox txtHora;
        private System.Windows.Forms.ComboBox cboTipoMovimiento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.TextBox txtIndice;
        private FontAwesome.Sharp.IconButton btnLimpiar;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.ComboBox cboBusqueda;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtIdTransaccion;
        private System.Windows.Forms.Label label11;
        private FontAwesome.Sharp.IconButton btnCerrarCaja;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.TextBox txtSaldoInicial;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboFormaPago;
        private System.Windows.Forms.Label Tipo;
        private System.Windows.Forms.TextBox txtSaldoInicialMP;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSaldoMP;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtSaldoInicialUSS;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtSaldoUSS;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtSaldoInicialGalicia;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtSaldoGalicia;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cboCajaAsociada;
        private System.Windows.Forms.Label label18;
        private FontAwesome.Sharp.IconButton btnEliminar;
        private FontAwesome.Sharp.IconButton btnLimpiarDatos;
        private System.Windows.Forms.TextBox txtIdCompra;
        private System.Windows.Forms.TextBox txtIdVenta;
        private System.Windows.Forms.ComboBox cboConcepto;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.DataGridViewButtonColumn btnSeleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCajaRegistradora;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTransaccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn hora;
        private System.Windows.Forms.DataGridViewTextBoxColumn concepto;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoTransaccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn monto;
        private System.Windows.Forms.DataGridViewTextBoxColumn formaPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn cajaAsociada;
        private System.Windows.Forms.DataGridViewTextBoxColumn docAsociado;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioTransaccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn idVenta;
    }
}