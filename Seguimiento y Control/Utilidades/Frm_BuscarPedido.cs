using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Seguimiento_y_Control.Entity;
using Seguimiento_y_Control.Clases.Topos;
using Seguimiento_y_Control.Clases.Produccion;

namespace Seguimiento_y_Control.Utilidades
{
    public partial class Frm_BuscarPedido : Form
    {
        public pedidos_internos Pedido;
        private int id_usuario;
        private pedidos_internos oPedido;
        private List<pedidos_internos> SourcePedidos;
 
        public Frm_BuscarPedido(int pID_Usuario)
        {
            InitializeComponent();
            id_usuario = pID_Usuario;
        }

        private void Frm_BuscarPedido_Load(object sender, EventArgs e)
        {
            CerrarPedidos();
            cargarComboPedidos();            
            btnAceptar.Focus();
        }

        private void cargarComboPedidos()
        {
            try
            {
                SourcePedidos = new List<pedidos_internos>();
                Seguimiento_ACC_Entities Contexto = new Seguimiento_ACC_Entities();
                /***************** Mostrar los pedidos a usuarios del mismo departamento *******************/
                usuarios _user = Contexto.usuarios.FirstOrDefault(o => o.id_usuario == id_usuario);
                List<usuarios> _lstUsuarios = Contexto.usuarios.Where(o => o.id_area == _user.id_area).ToList();
                List<pedidos_internos> _pedidos = new List<pedidos_internos>();

                foreach (usuarios usr in _lstUsuarios)
                {
                    _pedidos = Contexto.pedidos_internos.Where(o => o.estatus == "A" && o.id_usuario == usr.id_usuario).ToList();
                    SourcePedidos.AddRange(_pedidos);
                }
                /*******************************************************************************************/

                /*if (id_usuario != 0)
                    SourcePedidos = Contexto.pedidos_internos.Where(o => o.estatus == "A" && o.id_usuario == id_usuario).ToList();
                else
                    SourcePedidos = Contexto.pedidos_internos.Where(o => o.estatus == "A").ToList();*/

                cbPedidos.DataSource = SourcePedidos.OrderBy(o=>o.id_pedido).ToList();
                cbPedidos.DisplayMember = "codigo_pedido";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void CerrarPedidos()
        {
            Seguimiento_ACC_Entities Contexto = new Seguimiento_ACC_Entities();

            /***************** Mostrar los pedidos a usuarios del mismo departamento *******************/
            usuarios _user = Contexto.usuarios.FirstOrDefault(o => o.id_usuario == id_usuario);
            List<usuarios> _lstUsuarios = Contexto.usuarios.Where(o => o.id_area == _user.id_area).ToList();
            List<pedidos_internos> _pedidos = new List<pedidos_internos>();
            List<pedidos_internos> ListPedidosAbiertos = new List<pedidos_internos>();

            foreach (usuarios usr in _lstUsuarios)
            {
                _pedidos = Contexto.pedidos_internos.Where(o => o.estatus == "A" && o.id_usuario == usr.id_usuario).ToList();
                ListPedidosAbiertos.AddRange(_pedidos);
            }
            /*******************************************************************************************/
            ListPedidosAbiertos = ListPedidosAbiertos.OrderBy(o => o.id_pedido).ToList();

            foreach (pedidos_internos oPedido in ListPedidosAbiertos)
            {
                if (oPedido.dias_de_expiracion != null)
                {
                    /***** Obtener fecha de la entrega *****/
                    salidas Salida = Contexto.salidas.FirstOrDefault(o => o.id_pedido == oPedido.id_pedido);
                    /***** Encontrar fecha de expiración *****/
                    DateTime Expiracion = Salida.fecha.AddDays(Convert.ToInt32(oPedido.dias_de_expiracion));

                    if (Expiracion <= DateTime.Today)
                    {
                        //Cerrarlo
                        DialogResult dr =
                            MessageBox.Show(string.Format("El pedido: '{0}' ha expirado. ¿Desea cerrarlo?",
                                                           oPedido.codigo_pedido), "Buscar Pedido", 
                                                           MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (dr == System.Windows.Forms.DialogResult.Yes)
                        {
                            Contexto.pedidos_internos.FirstOrDefault(o => o.id_pedido == oPedido.id_pedido).estatus = "C";
                        }
                    }
                }
            }

            Contexto.SaveChanges();
        }

        private List<ArticuloRequerir> getArticulosRequeridos(int id_pedido)
        {
            Seguimiento_ACC_Entities Contexto = new Seguimiento_ACC_Entities();
            List<ArticuloRequerir> lstArticulosRequeridos = new List<ArticuloRequerir>();
            List<pedidos_internos_det> lstDetallesPedido = Contexto.pedidos_internos_det.Where(o => o.id_pedido == id_pedido).ToList();

            ArticuloRequerir ArticuloRequerido;
            foreach (pedidos_internos_det detalle in lstDetallesPedido)
            {
                ArticuloRequerido = new ArticuloRequerir();
                ArticuloRequerido.articulo_a_requerir = Contexto.articulos.FirstOrDefault(o => o.clave == detalle.clave_articulo);
                ArticuloRequerido.cantidad_a_requrir = detalle.cantidad;
                ArticuloRequerido.unidad = detalle.unidad;
                lstArticulosRequeridos.Add(ArticuloRequerido);
            }

            return lstArticulosRequeridos;
        }

        private void cbPedidos_SelectedIndexChanged(object sender, EventArgs e)
        {
            oPedido = cbPedidos.SelectedItem as pedidos_internos;
            gridArticulosRequerir.DataSource = getArticulosRequeridos(oPedido.id_pedido);
            gvArticulosRequerir.BestFitColumns();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Pedido = oPedido;
            this.Close();
        }

        private void cbPedidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                Pedido = oPedido;
                this.Close();
            }
        }

    }
}
