using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TpdDiurno.controlador;
using TpdDiurno.entidad;
using TpdDiurno.servicios;
using TpdDiurno.vista.ElementosUI;

namespace TpdDiurno.vista
{
    public partial class FormVenta : Form
    {
        private ProductoControlador cProducto;
        private VentaControlador cVenta;
        private ClienteControlador cCliente;
        private EVenta eventa;

        private List<EProducto> lista;

        public FormVenta()
        {
            InitializeComponent();
            cProducto = new ProductoControlador();
            cVenta = new VentaControlador();
            eventa = new EVenta();
            cCliente = new ClienteControlador();

            ListarProductos();

            mostarDatagrid();

            fpanel_venta.Resize += Fpanel_venta_Resize;

        }

        private void Fpanel_venta_Resize(object sender, EventArgs e)
        {
            foreach (VentaDetalleItem item in fpanel_venta.Controls)
            {
                item.Width = fpanel_venta.ClientSize.Width;
            }
        }

        private void ListarProductos()
        {
            try
            {
                lista = cProducto.GetAll();
                mostrarEnPanel(lista);
            }
            catch (Exception ex)
            {
                MessageBox.Show("error en listar productos" + ex.Message);
            }
        }

        private void mostrarEnPanel(List<EProducto> lista)
        {
            flowLayoutPanel1.Controls.Clear();
            foreach (EProducto producto in lista) {
                ItemProductoVenta cusuarioitem = new ItemProductoVenta();
                cusuarioitem.Item = producto;
                cusuarioitem.eventAddCart += agregarCartEvent;
                flowLayoutPanel1.Controls.Add(cusuarioitem);
            }
        }

        private void agregarCartEvent(EProducto data, EventArgs e)
        {
            //creando el objeto entidad detalle venta
            var detalle = new EDetalleVenta();
            detalle.Producto = data;
            detalle.Cantidad = 1;
            detalle.Precio = data.Precio;
            detalle.Producto_id = data.Id;
            detalle.Total = data.Precio;
            eventa.addItem(detalle);            
            addControl(detalle,eventa.Items.Count-1);
            mostrar_total();
            
        }

        private void mostarDatagrid()
        {
            fpanel_venta.Controls.Clear();

            Padding padding = new Padding(0);

            VentaDetalleItem vdti = new VentaDetalleItem();
            vdti.Width = fpanel_venta.ClientSize.Width;
            vdti.Padding = padding;
            vdti.Margin = padding;
            vdti.BackColor = Color.Teal; ;
            fpanel_venta.Controls.Add(vdti);
            if (eventa.Items != null)
            {
                for (int i = 0; i < eventa.Items.Count; i++)
                {
                    var item = eventa.Items[i];
                    addControl(item, i);
                }
            }
        }


        private void addControl(EDetalleVenta data,int indice)
        {
            Padding padding = new Padding(0,1,0,0);
            VentaDetalleItem detalleItem = new VentaDetalleItem();
            detalleItem.Width = fpanel_venta.ClientSize.Width;
            detalleItem.Margin = padding;
            detalleItem.setItem(data, indice);
            detalleItem.event_delete += DetalleItem_event_delete;
            detalleItem.event_change += DetalleItem_event_change;

            fpanel_venta.Controls.Add(detalleItem);
        }

        private void DetalleItem_event_change(EDetalleVenta data, int index, EventArgs e)
        {
            eventa.changeItem(data, index);
            //mostarDatagrid();
            mostrar_total();
        }

        private void DetalleItem_event_delete(EDetalleVenta data, int index, EventArgs e)
        {
            eventa.removeItem(index);
            mostarDatagrid();
            mostrar_total();
        }

        public void mostrar_total()
        {
            lbl_total.Text=eventa.Total_pagar.ToString("F2");
        }

        private void txt_buscar_TextChanged(object sender, EventArgs e)
        {
            string nrodoc = txt_buscar.Text;

            ECliente cliente = cCliente.GetByNroDoc(nrodoc);
            if (cliente != null)
            {
                //mostrar cliente
                lbl_cliente.Text = cliente.Nombres;
                lbl_direccion.Text = cliente.Direccion;
                btn_buscar.Enabled = false;
            }
            else {
                lbl_cliente.Text = "No se encontro la informacion";
                lbl_direccion.Text = "";
                btn_buscar.Enabled = true;
            }
            
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            consultar(txt_buscar.Text);

        }

        private async void consultar(string nrodoc)
        {
            ServiceApiDev servicio = new ServiceApiDev();
            //progrmacion para dni
            //-dni tiene 8 digitos
            int digitos = nrodoc.Length;
            if (digitos == 8)
            {
                DataDniApiDev persona = await servicio.getByDni(nrodoc);
                if (persona != null)
                {
                    lbl_cliente.Text = persona.Nombres + " " + persona.Apellido_paterno + " " + persona.Apellido_materno;
                }
            }

            //programacion para ruc
            //- ruc -11 digitos
            if (digitos == 11)
            {
                DataRucApiDev empresa = await servicio.getByRuc(nrodoc);
                if (empresa != null)
                {
                    lbl_cliente.Text = empresa.Nombre_o_razon_social;
                    lbl_direccion.Text = empresa.Direccion_completa;
                }
            }

        }
    }
}
