namespace Seguimiento_y_Control.Produccion
{
    partial class Frm_BuscarEtiquetas
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
            this.cbEtiquetaProd = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pbEtiquetaProd = new System.Windows.Forms.PictureBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbEtiquetaTarima = new System.Windows.Forms.ComboBox();
            this.pbEtiquetaTarima = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbEtiquetaProd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEtiquetaTarima)).BeginInit();
            this.SuspendLayout();
            // 
            // cbEtiquetaProd
            // 
            this.cbEtiquetaProd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEtiquetaProd.FormattingEnabled = true;
            this.cbEtiquetaProd.Location = new System.Drawing.Point(292, 12);
            this.cbEtiquetaProd.Name = "cbEtiquetaProd";
            this.cbEtiquetaProd.Size = new System.Drawing.Size(260, 26);
            this.cbEtiquetaProd.TabIndex = 0;
            this.cbEtiquetaProd.SelectedIndexChanged += new System.EventHandler(this.cbEtiquetaProd_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(132, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Etiqueta de Producción:";
            // 
            // pbEtiquetaProd
            // 
            this.pbEtiquetaProd.Location = new System.Drawing.Point(12, 44);
            this.pbEtiquetaProd.Name = "pbEtiquetaProd";
            this.pbEtiquetaProd.Size = new System.Drawing.Size(660, 229);
            this.pbEtiquetaProd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbEtiquetaProd.TabIndex = 2;
            this.pbEtiquetaProd.TabStop = false;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Image = global::Seguimiento_y_Control.Properties.Resources.Ok_icon30;
            this.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAceptar.Location = new System.Drawing.Point(572, 546);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(100, 40);
            this.btnAceptar.TabIndex = 6;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(177, 282);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "Etiqueta Master:";
            // 
            // cbEtiquetaTarima
            // 
            this.cbEtiquetaTarima.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEtiquetaTarima.FormattingEnabled = true;
            this.cbEtiquetaTarima.Location = new System.Drawing.Point(292, 279);
            this.cbEtiquetaTarima.Name = "cbEtiquetaTarima";
            this.cbEtiquetaTarima.Size = new System.Drawing.Size(260, 26);
            this.cbEtiquetaTarima.TabIndex = 8;
            this.cbEtiquetaTarima.SelectedIndexChanged += new System.EventHandler(this.cbEtiquetaTarima_SelectedIndexChanged);
            // 
            // pbEtiquetaTarima
            // 
            this.pbEtiquetaTarima.Location = new System.Drawing.Point(12, 311);
            this.pbEtiquetaTarima.Name = "pbEtiquetaTarima";
            this.pbEtiquetaTarima.Size = new System.Drawing.Size(660, 229);
            this.pbEtiquetaTarima.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbEtiquetaTarima.TabIndex = 10;
            this.pbEtiquetaTarima.TabStop = false;
            // 
            // Frm_BuscarEtiquetas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 597);
            this.Controls.Add(this.pbEtiquetaTarima);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbEtiquetaTarima);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.pbEtiquetaProd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbEtiquetaProd);
            this.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(700, 420);
            this.Name = "Frm_BuscarEtiquetas";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Seleccionar Etiqueta";
            this.Load += new System.EventHandler(this.Frm_BuscarEtiquetas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbEtiquetaProd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEtiquetaTarima)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbEtiquetaProd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbEtiquetaProd;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbEtiquetaTarima;
        private System.Windows.Forms.PictureBox pbEtiquetaTarima;
    }
}