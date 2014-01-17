using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Seguimiento_y_Control.Entity;
using System.IO;

namespace Seguimiento_y_Control.Produccion
{
    public partial class Frm_BuscarEtiquetas : Form
    {
        public catalog_comandos_etiquetas EtiquetaSeleccionada;
        public catalog_comandos_etiquetas TarimaSeleccionada;

        public Frm_BuscarEtiquetas()
        {
            InitializeComponent();
        }

        private void Frm_BuscarEtiquetas_Load(object sender, EventArgs e)
        {
            cargarComboProd();
            cargarComboTarima();
            EtiquetaSeleccionada = (catalog_comandos_etiquetas)cbEtiquetaProd.SelectedItem;
            TarimaSeleccionada = (catalog_comandos_etiquetas)cbEtiquetaTarima.SelectedItem;
        }
        private void cargarComboProd()
        {
            Seguimiento_ACC_Entities SegContext = new Seguimiento_ACC_Entities();
            List<catalog_comandos_etiquetas> lstEtiquetas = SegContext.catalog_comandos_etiquetas.ToList();
            lstEtiquetas = lstEtiquetas.FindAll(o => o.etiqueta != "recepcion");
            lstEtiquetas = lstEtiquetas.FindAll(o => o.etiqueta.Contains("tarima") == false);
            cbEtiquetaProd.DataSource = lstEtiquetas;
            cbEtiquetaProd.DisplayMember = "etiqueta";
        }
        private void cargarComboTarima()
        {
            Seguimiento_ACC_Entities SegContext = new Seguimiento_ACC_Entities();
            List<catalog_comandos_etiquetas> lstEtiquetas = SegContext.catalog_comandos_etiquetas.ToList();
            lstEtiquetas = lstEtiquetas.FindAll(o => o.etiqueta.Contains("tarima"));
            cbEtiquetaTarima.DataSource = lstEtiquetas;
            cbEtiquetaTarima.DisplayMember = "etiqueta";
        }

        private void cbEtiquetaProd_SelectedIndexChanged(object sender, EventArgs e)
        {
            catalog_comandos_etiquetas oEtiqueta = (catalog_comandos_etiquetas)cbEtiquetaProd.SelectedItem;
            MemoryStream ms = new MemoryStream(oEtiqueta.imagen_etiqueta);
            Bitmap imagenEtiqueta = new Bitmap(ms);
            pbEtiquetaProd.Image = imagenEtiqueta;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            EtiquetaSeleccionada = (catalog_comandos_etiquetas)cbEtiquetaProd.SelectedItem;
            TarimaSeleccionada = (catalog_comandos_etiquetas)cbEtiquetaTarima.SelectedItem;
            this.Close();
        }

        private void cbEtiquetaTarima_SelectedIndexChanged(object sender, EventArgs e)
        {
            catalog_comandos_etiquetas oEtiqueta = (catalog_comandos_etiquetas)cbEtiquetaTarima.SelectedItem;
            MemoryStream ms = new MemoryStream(oEtiqueta.imagen_etiqueta);
            Bitmap imagenEtiqueta = new Bitmap(ms);
            pbEtiquetaTarima.Image = imagenEtiqueta;
        }
    }
}
