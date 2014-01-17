﻿namespace Seguimiento_y_Control.Produccion
{
    partial class Frm_ImpPesoVariado
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
            this.panelPreview = new System.Windows.Forms.Panel();
            this.dtpEmpaque = new System.Windows.Forms.DateTimePicker();
            this.lblPara = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblLote = new System.Windows.Forms.Label();
            this.lblLeyenda = new System.Windows.Forms.Label();
            this.lblCaducidad = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblDomicilio = new System.Windows.Forms.Label();
            this.lblNombreEmpresa = new System.Windows.Forms.Label();
            this.lblArticulo = new System.Windows.Forms.Label();
            this.lblClave = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.numUpDnPiezas = new System.Windows.Forms.NumericUpDown();
            this.lblPiezas = new System.Windows.Forms.Label();
            this.txbCantidad = new System.Windows.Forms.TextBox();
            this.lblUnidad = new System.Windows.Forms.Label();
            this.lblCantidadPeso = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.pbLogoEtiqueta = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblRazon = new System.Windows.Forms.Label();
            this.lblNumeroEtiqueta = new System.Windows.Forms.Label();
            this.objBascula = new System.IO.Ports.SerialPort(this.components);
            this.btnEtiqueta = new System.Windows.Forms.Button();
            this.txbEtiqueta = new System.Windows.Forms.TextBox();
            this.btnTerminar = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbTarima = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbLoteMaquila = new System.Windows.Forms.TextBox();
            this.panelPreview.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDnPiezas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoEtiqueta)).BeginInit();
            this.SuspendLayout();
            // 
            // panelPreview
            // 
            this.panelPreview.BackColor = System.Drawing.Color.White;
            this.panelPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPreview.Controls.Add(this.dtpEmpaque);
            this.panelPreview.Controls.Add(this.lblPara);
            this.panelPreview.Controls.Add(this.label8);
            this.panelPreview.Controls.Add(this.lblLote);
            this.panelPreview.Controls.Add(this.lblLeyenda);
            this.panelPreview.Controls.Add(this.lblCaducidad);
            this.panelPreview.Controls.Add(this.label13);
            this.panelPreview.Controls.Add(this.label11);
            this.panelPreview.Controls.Add(this.lblDomicilio);
            this.panelPreview.Controls.Add(this.lblNombreEmpresa);
            this.panelPreview.Controls.Add(this.lblArticulo);
            this.panelPreview.Controls.Add(this.lblClave);
            this.panelPreview.Controls.Add(this.panel2);
            this.panelPreview.Controls.Add(this.lbl);
            this.panelPreview.Controls.Add(this.pbLogoEtiqueta);
            this.panelPreview.Controls.Add(this.label6);
            this.panelPreview.Controls.Add(this.lblRazon);
            this.panelPreview.Controls.Add(this.lblNumeroEtiqueta);
            this.panelPreview.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPreview.Enabled = false;
            this.panelPreview.Location = new System.Drawing.Point(0, 0);
            this.panelPreview.Name = "panelPreview";
            this.panelPreview.Size = new System.Drawing.Size(664, 330);
            this.panelPreview.TabIndex = 13;
            // 
            // dtpEmpaque
            // 
            this.dtpEmpaque.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpEmpaque.CustomFormat = "dd/MM/yyyy";
            this.dtpEmpaque.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEmpaque.Location = new System.Drawing.Point(365, 83);
            this.dtpEmpaque.Name = "dtpEmpaque";
            this.dtpEmpaque.Size = new System.Drawing.Size(92, 26);
            this.dtpEmpaque.TabIndex = 39;
            // 
            // lblPara
            // 
            this.lblPara.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPara.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPara.Location = new System.Drawing.Point(90, 130);
            this.lblPara.Name = "lblPara";
            this.lblPara.Size = new System.Drawing.Size(532, 20);
            this.lblPara.TabIndex = 38;
            this.lblPara.Text = "-----";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.Location = new System.Drawing.Point(29, 130);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 22);
            this.label8.TabIndex = 37;
            this.label8.Text = "PARA:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblLote
            // 
            this.lblLote.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLote.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLote.Location = new System.Drawing.Point(90, 150);
            this.lblLote.Name = "lblLote";
            this.lblLote.Size = new System.Drawing.Size(80, 20);
            this.lblLote.TabIndex = 36;
            this.lblLote.Text = "9999999";
            // 
            // lblLeyenda
            // 
            this.lblLeyenda.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLeyenda.Location = new System.Drawing.Point(263, 110);
            this.lblLeyenda.Name = "lblLeyenda";
            this.lblLeyenda.Size = new System.Drawing.Size(371, 20);
            this.lblLeyenda.TabIndex = 34;
            this.lblLeyenda.Text = "MANTENGASE EN CONGELACION";
            this.lblLeyenda.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCaducidad
            // 
            this.lblCaducidad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCaducidad.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaducidad.Location = new System.Drawing.Point(554, 90);
            this.lblCaducidad.Name = "lblCaducidad";
            this.lblCaducidad.Size = new System.Drawing.Size(80, 20);
            this.lblCaducidad.TabIndex = 33;
            this.lblCaducidad.Text = "01/01/0001";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.Location = new System.Drawing.Point(464, 90);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(84, 20);
            this.label13.TabIndex = 32;
            this.label13.Text = "Caducidad:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.Location = new System.Drawing.Point(263, 90);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(97, 20);
            this.label11.TabIndex = 30;
            this.label11.Text = "Empacado el:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblDomicilio
            // 
            this.lblDomicilio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDomicilio.Location = new System.Drawing.Point(263, 44);
            this.lblDomicilio.Name = "lblDomicilio";
            this.lblDomicilio.Size = new System.Drawing.Size(371, 36);
            this.lblDomicilio.TabIndex = 29;
            this.lblDomicilio.Text = "Segunda de Selenio y Estaño s/n Cd. Industrial cp 34208 Durango, Dgo. Tel: 01 618" +
    " 8 14 15 15";
            this.lblDomicilio.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblNombreEmpresa
            // 
            this.lblNombreEmpresa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNombreEmpresa.Location = new System.Drawing.Point(263, 2);
            this.lblNombreEmpresa.Name = "lblNombreEmpresa";
            this.lblNombreEmpresa.Size = new System.Drawing.Size(371, 39);
            this.lblNombreEmpresa.TabIndex = 28;
            this.lblNombreEmpresa.Text = "ABASTECEDORA DE CARNES LOS CORRALES S.A. DE C.V.";
            this.lblNombreEmpresa.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblArticulo
            // 
            this.lblArticulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblArticulo.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArticulo.Location = new System.Drawing.Point(32, 174);
            this.lblArticulo.Name = "lblArticulo";
            this.lblArticulo.Size = new System.Drawing.Size(602, 26);
            this.lblArticulo.TabIndex = 27;
            this.lblArticulo.Text = "Articulo";
            this.lblArticulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblClave
            // 
            this.lblClave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblClave.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClave.Location = new System.Drawing.Point(263, 148);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(371, 26);
            this.lblClave.TabIndex = 26;
            this.lblClave.Text = "000000";
            this.lblClave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.numUpDnPiezas);
            this.panel2.Controls.Add(this.lblPiezas);
            this.panel2.Controls.Add(this.txbCantidad);
            this.panel2.Controls.Add(this.lblUnidad);
            this.panel2.Controls.Add(this.lblCantidadPeso);
            this.panel2.Location = new System.Drawing.Point(263, 204);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(371, 116);
            this.panel2.TabIndex = 25;
            // 
            // numUpDnPiezas
            // 
            this.numUpDnPiezas.Enabled = false;
            this.numUpDnPiezas.Location = new System.Drawing.Point(317, 9);
            this.numUpDnPiezas.Name = "numUpDnPiezas";
            this.numUpDnPiezas.Size = new System.Drawing.Size(40, 26);
            this.numUpDnPiezas.TabIndex = 40;
            // 
            // lblPiezas
            // 
            this.lblPiezas.AutoSize = true;
            this.lblPiezas.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPiezas.Location = new System.Drawing.Point(260, 11);
            this.lblPiezas.Name = "lblPiezas";
            this.lblPiezas.Size = new System.Drawing.Size(51, 18);
            this.lblPiezas.TabIndex = 16;
            this.lblPiezas.Text = "Piezas:";
            this.lblPiezas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txbCantidad
            // 
            this.txbCantidad.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCantidad.Location = new System.Drawing.Point(16, 40);
            this.txbCantidad.MaxLength = 9;
            this.txbCantidad.Name = "txbCantidad";
            this.txbCantidad.Size = new System.Drawing.Size(243, 66);
            this.txbCantidad.TabIndex = 14;
            this.txbCantidad.Text = "0000.0000";
            this.txbCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblUnidad
            // 
            this.lblUnidad.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnidad.Location = new System.Drawing.Point(265, 77);
            this.lblUnidad.Name = "lblUnidad";
            this.lblUnidad.Size = new System.Drawing.Size(92, 29);
            this.lblUnidad.TabIndex = 15;
            this.lblUnidad.Text = "unidad";
            this.lblUnidad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCantidadPeso
            // 
            this.lblCantidadPeso.AutoSize = true;
            this.lblCantidadPeso.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadPeso.Location = new System.Drawing.Point(12, 14);
            this.lblCantidadPeso.Name = "lblCantidadPeso";
            this.lblCantidadPeso.Size = new System.Drawing.Size(93, 23);
            this.lblCantidadPeso.TabIndex = 12;
            this.lblCantidadPeso.Text = "Peso Neto:";
            // 
            // lbl
            // 
            this.lbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl.Location = new System.Drawing.Point(29, 148);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(55, 22);
            this.lbl.TabIndex = 24;
            this.lbl.Text = "LOTE: ";
            this.lbl.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // pbLogoEtiqueta
            // 
            this.pbLogoEtiqueta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbLogoEtiqueta.Image = global::Seguimiento_y_Control.Properties.Resources.logoEtq;
            this.pbLogoEtiqueta.Location = new System.Drawing.Point(29, 24);
            this.pbLogoEtiqueta.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbLogoEtiqueta.Name = "pbLogoEtiqueta";
            this.pbLogoEtiqueta.Size = new System.Drawing.Size(170, 70);
            this.pbLogoEtiqueta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogoEtiqueta.TabIndex = 20;
            this.pbLogoEtiqueta.TabStop = false;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(29, 2);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(170, 18);
            this.label6.TabIndex = 19;
            this.label6.Text = "ELABORADO POR:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRazon
            // 
            this.lblRazon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRazon.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRazon.Location = new System.Drawing.Point(29, 98);
            this.lblRazon.Name = "lblRazon";
            this.lblRazon.Size = new System.Drawing.Size(170, 22);
            this.lblRazon.TabIndex = 21;
            this.lblRazon.Text = "LOS CORRALES SA DE SV";
            this.lblRazon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNumeroEtiqueta
            // 
            this.lblNumeroEtiqueta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNumeroEtiqueta.Font = new System.Drawing.Font("EAN-13", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroEtiqueta.Location = new System.Drawing.Point(29, 204);
            this.lblNumeroEtiqueta.Name = "lblNumeroEtiqueta";
            this.lblNumeroEtiqueta.Size = new System.Drawing.Size(192, 116);
            this.lblNumeroEtiqueta.TabIndex = 35;
            this.lblNumeroEtiqueta.Text = "0000000000000";
            this.lblNumeroEtiqueta.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // objBascula
            // 
            this.objBascula.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.objBascula_DataReceived);
            // 
            // btnEtiqueta
            // 
            this.btnEtiqueta.AutoSize = true;
            this.btnEtiqueta.Location = new System.Drawing.Point(196, 374);
            this.btnEtiqueta.Name = "btnEtiqueta";
            this.btnEtiqueta.Size = new System.Drawing.Size(30, 28);
            this.btnEtiqueta.TabIndex = 20;
            this.btnEtiqueta.Text = "...";
            this.btnEtiqueta.UseVisualStyleBackColor = true;
            this.btnEtiqueta.Click += new System.EventHandler(this.btnEtiqueta_Click);
            // 
            // txbEtiqueta
            // 
            this.txbEtiqueta.BackColor = System.Drawing.Color.White;
            this.txbEtiqueta.ForeColor = System.Drawing.Color.Black;
            this.txbEtiqueta.Location = new System.Drawing.Point(12, 374);
            this.txbEtiqueta.Name = "txbEtiqueta";
            this.txbEtiqueta.ReadOnly = true;
            this.txbEtiqueta.Size = new System.Drawing.Size(178, 26);
            this.txbEtiqueta.TabIndex = 21;
            // 
            // btnTerminar
            // 
            this.btnTerminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTerminar.Image = global::Seguimiento_y_Control.Properties.Resources.close_icon30;
            this.btnTerminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTerminar.Location = new System.Drawing.Point(550, 419);
            this.btnTerminar.Name = "btnTerminar";
            this.btnTerminar.Size = new System.Drawing.Size(102, 35);
            this.btnTerminar.TabIndex = 19;
            this.btnTerminar.Text = "Terminar";
            this.btnTerminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTerminar.UseVisualStyleBackColor = true;
            this.btnTerminar.Click += new System.EventHandler(this.btnTerminar_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnImprimir.Image = global::Seguimiento_y_Control.Properties.Resources.Printer30;
            this.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImprimir.Location = new System.Drawing.Point(441, 419);
            this.btnImprimir.Margin = new System.Windows.Forms.Padding(4);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(102, 35);
            this.btnImprimir.TabIndex = 18;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 353);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 18);
            this.label1.TabIndex = 22;
            this.label1.Text = "Etiqueta a Utilizar:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 403);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 18);
            this.label2.TabIndex = 24;
            this.label2.Text = "Etiqueta Master:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txbTarima
            // 
            this.txbTarima.BackColor = System.Drawing.Color.White;
            this.txbTarima.ForeColor = System.Drawing.Color.Black;
            this.txbTarima.Location = new System.Drawing.Point(12, 424);
            this.txbTarima.Name = "txbTarima";
            this.txbTarima.ReadOnly = true;
            this.txbTarima.Size = new System.Drawing.Size(178, 26);
            this.txbTarima.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(376, 385);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 18);
            this.label3.TabIndex = 26;
            this.label3.Text = "Lote Maquila:";
            // 
            // txbLoteMaquila
            // 
            this.txbLoteMaquila.BackColor = System.Drawing.Color.White;
            this.txbLoteMaquila.ForeColor = System.Drawing.Color.Black;
            this.txbLoteMaquila.Location = new System.Drawing.Point(474, 382);
            this.txbLoteMaquila.Name = "txbLoteMaquila";
            this.txbLoteMaquila.Size = new System.Drawing.Size(178, 26);
            this.txbLoteMaquila.TabIndex = 25;
            this.txbLoteMaquila.Text = "0";
            this.txbLoteMaquila.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Frm_ImpPesoVariado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 462);
            this.ControlBox = false;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbLoteMaquila);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbTarima);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbEtiqueta);
            this.Controls.Add(this.btnEtiqueta);
            this.Controls.Add(this.btnTerminar);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.panelPreview);
            this.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(680, 500);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(680, 500);
            this.Name = "Frm_ImpPesoVariado";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Imprimir Peso Variado";
            this.Load += new System.EventHandler(this.Frm_ImpPesoVariado_Load);
            this.panelPreview.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDnPiezas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoEtiqueta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelPreview;
        private System.Windows.Forms.Label lblPara;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblLote;
        private System.Windows.Forms.Label lblLeyenda;
        private System.Windows.Forms.Label lblCaducidad;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblDomicilio;
        private System.Windows.Forms.Label lblNombreEmpresa;
        private System.Windows.Forms.Label lblArticulo;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.NumericUpDown numUpDnPiezas;
        private System.Windows.Forms.Label lblPiezas;
        private System.Windows.Forms.TextBox txbCantidad;
        private System.Windows.Forms.Label lblUnidad;
        private System.Windows.Forms.Label lblCantidadPeso;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.PictureBox pbLogoEtiqueta;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblRazon;
        private System.Windows.Forms.Label lblNumeroEtiqueta;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnTerminar;
        private System.Windows.Forms.DateTimePicker dtpEmpaque;
        public System.IO.Ports.SerialPort objBascula;
        private System.Windows.Forms.Button btnEtiqueta;
        private System.Windows.Forms.TextBox txbEtiqueta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbTarima;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbLoteMaquila;
    }
}