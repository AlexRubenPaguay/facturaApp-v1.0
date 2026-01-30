using FACTURA_TEST1.Formularios;
using FACTURA_TEST1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FACTURA_TEST1
{
    public partial class frm_factura : Form
    {
        DbContextVentas _context;
        public frm_factura()
        {
            InitializeComponent();
            _context = new DbContextVentas();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cargar();
            textBox3.Text = calcularNumFactura();
            verBoton();
        }

        private void verBoton()
        {
            if (dgvw_productos.Rows.Count <= 1)
            {
                btn_eliminarProducto.Visible = false;
            }
            else
            {
                btn_eliminarProducto.Visible = true;
            }
        }

        private string calcularNumFactura()
        {
            var ultimoNumero = _context.Factura
                .OrderByDescending(x => x.cod_fac).
                Select(x => x.cod_fac).
                FirstOrDefault();
            var siguienteNumero = ultimoNumero + 1;
            return $"FAC-{siguienteNumero:0000000}";
        }

        private void cargar()
        {
            var productos = _context.Producto.Where(x => x.cod_pro != 4).ToList();
            cb_productoRegistrado.DataSource = productos;
            cb_productoRegistrado.DisplayMember = "nombre";
            cb_ivaRegistrado.ValueMember = "cod_pro";

            var iva = _context.Parametro.ToList();
            cb_ivaRegistrado.DataSource = iva;
            cb_ivaRegistrado.DisplayMember = "descripcion";
            cb_ivaRegistrado.ValueMember = "valor";

            cb_ivaSinRegistro.DataSource = iva;
            cb_ivaSinRegistro.DisplayMember = "descripcion";
            cb_ivaSinRegistro.ValueMember = "valor";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_productoRegistrado.SelectedItem is Producto productoSeleccionado)
            {
                txt_precioRegistrado.Text = productoSeleccionado.precio.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_cantidadRegistrado.Text != "" && Convert.ToInt32(txt_cantidadRegistrado.Text) > 0)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dgvw_productos);
                row.Cells[0].Value = cb_productoRegistrado.Text;
                row.Cells[1].Value = txt_precioRegistrado.Text;
                row.Cells[2].Value = txt_cantidadRegistrado.Text;
                row.Cells[3].Value = cb_ivaRegistrado.SelectedValue;
                row.Cells[4].Value = float.Parse(txt_precioRegistrado.Text) * float.Parse(txt_cantidadRegistrado.Text);
                dgvw_productos.Rows.Add(row);
                calcularValores();
                verBoton();
                limpiarProductosRegistrados();
            }
            else
            {
                MessageBox.Show("La cantidad es obligatoria y debe ser mayor a cero.");
            }
        }

        private void calcularValores()
        {
            var base0 = 0.00;
            var base15 = 0.00;
            foreach (DataGridViewRow row in dgvw_productos.Rows)
            {
                if (Convert.ToInt32(row.Cells[3].Value) == 0)
                {
                    base0 += Convert.ToInt32(row.Cells[4].Value);
                }
                else
                {
                    base15 += Convert.ToInt32(row.Cells[4].Value);
                }
            }
            txt_baseCero.Text = base0.ToString();
            txt_base15.Text = base15.ToString();
            txt_subtotal.Text = Convert.ToString(base0 + base15);
            txt_iva15.Text = Convert.ToString(base15 * 0.15);
            txt_total.Text = Convert.ToString((base0 + base15) + (base15 * 0.15));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dgvw_productos.CurrentRow.IsNewRow)
                return;

            if (dgvw_productos.CurrentRow != null)
            {
                var respuesta = MessageBox.Show("Eliminar Registro", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (respuesta == DialogResult.Yes)
                {
                    dgvw_productos.Rows.Remove(dgvw_productos.CurrentRow);
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un registro", "Mensaje", MessageBoxButtons.OK);
            }
            calcularValores();
            verBoton();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvw_productos.Rows.Count <= 1)
                {
                    MessageBox.Show("Debe cargar productos antes de guardar", "Mensaje", MessageBoxButtons.OK);
                    return;
                }

                var factura = new Factura
                {
                    Fecha = DateTime.Now,
                    BaseIVA0 = Convert.ToDecimal(txt_baseCero.Text),
                    BaseIVA12 = Convert.ToDecimal(txt_base15.Text),
                    IVA = Convert.ToDecimal(txt_iva15.Text),
                    Total = Convert.ToDecimal(txt_total.Text)
                };
                _context.Factura.Add(factura);
                _context.SaveChanges();

                var productos = _context.Producto.ToList();
                var detalles = new List<Detalle_Factura>();
                foreach (DataGridViewRow item in dgvw_productos.Rows)
                {
                    if (item.IsNewRow)
                        continue;
                    if (item.Cells[0].Value == null || item.Cells[1].Value == null)
                        continue;

                    var idPro = productos.Where(x => x.nombre.Equals(item.Cells[0].Value.ToString())).FirstOrDefault();
                    var detalle = new Detalle_Factura
                    {
                        Cantidad = Convert.ToDecimal(item.Cells[2].Value),
                        PrecioUnitario = Convert.ToDecimal(item.Cells[1].Value),
                        PorcentajeIVA = Convert.ToInt32(item.Cells[3].Value),
                        Subtotal = Convert.ToDecimal(item.Cells[4].Value),
                        cod_factura = factura.cod_fac,
                        cod_producto = idPro?.cod_pro != null ? idPro.cod_pro : 4
                    };
                    detalles.Add(detalle);
                }

                _context.Detalle_Factura.AddRange(detalles);
                _context.SaveChanges();
                limpiar();
                textBox3.Text = calcularNumFactura();
                MessageBox.Show("Factura ingresada correctamente...", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                //MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        private void limpiar()
        {
            limpiarProductosRegistrados();
            dgvw_productos.Rows.Clear();
            txt_baseCero.Text = "0.00";
            txt_base15.Text = "0.00";
            txt_iva15.Text = "0.00";
            txt_total.Text = "0.00";
            txt_subtotal.Text = "0.00";
            limpiarProductosNoRegistrados();
        }
        private void limpiarProductosRegistrados()
        {
            cb_productoRegistrado.SelectedIndex = 0;
            cb_ivaRegistrado.SelectedIndex = 0;
            txt_precioRegistrado.Text = "0.00";
            txt_cantidadRegistrado.Text = "0.00";
        }
        private void limpiarProductosNoRegistrados()
        {
            txt_cantidadSinRegistro.Text = "0.00";
            txt_precioSinRegistro.Text = "0.00";
            txt_productosSinRegisro.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frm_reportes reportes = new frm_reportes();
            reportes.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txt_productosSinRegisro.Text) || String.IsNullOrWhiteSpace(txt_precioSinRegistro.Text) || String.IsNullOrWhiteSpace(txt_cantidadSinRegistro.Text))
            {
                MessageBox.Show("Los campos(producto,precio,cantidad e iva) deben ingresarse obligatoriamente", "Mensaje", MessageBoxButtons.OK);
                return;
            }
            if (float.TryParse(txt_precioSinRegistro.Text, out float precio) && precio > 0 &&
                int.TryParse(txt_cantidadSinRegistro.Text, out int cantidad) && cantidad > 0)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dgvw_productos);
                row.Cells[0].Value = txt_productosSinRegisro.Text;
                row.Cells[1].Value = txt_precioSinRegistro.Text;
                row.Cells[2].Value = txt_cantidadSinRegistro.Text;
                row.Cells[3].Value = cb_ivaSinRegistro.SelectedValue.ToString();
                row.Cells[4].Value = float.Parse(txt_precioSinRegistro.Text) * float.Parse(txt_cantidadSinRegistro.Text);
                dgvw_productos.Rows.Add(row);
                calcularValores();
                verBoton();
                limpiarProductosNoRegistrados();
            }
            else
            {
                MessageBox.Show("Los campos (precio y cantidad ) deben ser mayores a cero", "Mensaje", MessageBoxButtons.OK);
                return;
            }
        }
    }
}
