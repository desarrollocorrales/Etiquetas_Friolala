using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Seguimiento_y_Control.Clases.Administracion;
using Seguimiento_y_Control.Entity;

namespace Seguimiento_y_Control.Administracion
{
    public partial class Frm_AdmImpresoras : Form
    {
        private Seguimiento_ACC_Entities Contexto;
        List<catalog_basculas> lstB;
        public Frm_AdmImpresoras()
        {
            InitializeComponent();
        }

        private void Frm_AdmImpresoras_Load(object sender, EventArgs e)
        {
            int i = 1;
            Impresora oImpresora = new Impresora();
            List<Impresora> lstImpresoras = new List<Impresora>();
            foreach (string printer in System.Drawing.Printing.PrinterSettings.InstalledPrinters)
            {
                oImpresora = new Impresora();
                oImpresora.ID = i;
                oImpresora.NombreImpresora = printer;
                lstImpresoras.Add(oImpresora);
                i++;
            }

            
            Exportador oExportador = new Exportador();
            List<Exportador> lstExp = new List<Exportador>();

            for (int exp = 1; exp <= 2; exp++)
            {
                oExportador = new Exportador();
                oExportador.Id = exp;
                if(exp == 1)
                    oExportador.tipo = "MICROSOFT OFFICE";
                else
                    oExportador.tipo = "OPEN OFFICE";

                lstExp.Add(oExportador);
            }

            cbEtiquetaProd.ValueMember = "Id";
            cbEtiquetaProd.DisplayMember = "tipo";
            cbEtiquetaProd.DataSource = lstExp;
            cbEtiquetaProd.SelectedIndex = -1;

            int x = 0;
            foreach (Exportador elemento in ((List<Exportador>)cbEtiquetaProd.DataSource))
            {
                if (elemento.tipo == Properties.Settings.Default.Exportador)
                {
                    cbEtiquetaProd.SelectedIndex = x;
                    break;
                }
                x++;
            }

            Contexto = new Seguimiento_ACC_Entities();
            lstB = new List<catalog_basculas>();
            lstB = Contexto.catalog_basculas.ToList();
            if(lstB.Count > 0)
            {
                cmbBasculas.ValueMember = "id_bascula";
                cmbBasculas.DisplayMember = "marca";
                cmbBasculas.DataSource = lstB;
                cmbBasculas.SelectedIndex = -1;
            }


            gridImpresoras.DataSource = lstImpresoras;
            gvImpresoras.BestFitColumns();
            gridImpresoras.Refresh();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
        }
        private void Guardar()
        {
            if (cbEtiquetaProd.SelectedIndex == -1)
            {
                MessageBox.Show("No ha seleccionado el Exportador", string.Empty,
                                 MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (lstB.Count > 0 && cmbBasculas.SelectedIndex == -1)
            {
                MessageBox.Show("No ha selecionado la Báscula", string.Empty,
                                 MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            //**** Obtener impresora seleccionada
            Impresora oImpresora = (Impresora)gvImpresoras.GetRow(gvImpresoras.GetSelectedRows()[0]);

            StringBuilder sb = new StringBuilder();
            sb.Append(string.Format("¿Desea configurar la impresora '{0}' ", oImpresora.NombreImpresora));
            sb.AppendLine(string.Format("como impresora predeterminada para etiquetas?"));
            DialogResult dr = MessageBox.Show(sb.ToString(), string.Empty, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            

            if (dr == DialogResult.Yes)
            {
                Properties.Settings.Default.Impresora = oImpresora.NombreImpresora;
                Properties.Settings.Default.Exportador = ((List<Exportador>)cbEtiquetaProd.DataSource)[cbEtiquetaProd.SelectedIndex].tipo;
                Properties.Settings.Default.bascula = ((List<catalog_basculas>)cmbBasculas.DataSource)[cmbBasculas.SelectedIndex].id_bascula;
                Properties.Settings.Default.Save();

                MessageBox.Show("La impresora se ha configurado correctamente", string.Empty, 
                                 MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
    }
}
