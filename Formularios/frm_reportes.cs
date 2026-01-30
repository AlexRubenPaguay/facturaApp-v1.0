using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FACTURA_APP.Models;
using Microsoft.Reporting.WinForms;

namespace FACTURA_APP.Formularios
{
    public partial class frm_reportes : Form
    {
        DbContextVentas _context;       
        public frm_reportes()
        {
            InitializeComponent();            
            _context =new DbContextVentas();
        }

        private void Reportes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'ds_Ventas.visualizar_factura' Puede moverla o quitarla según sea necesario.
            this.visualizar_facturaTableAdapter.Fill(this.ds_Ventas.visualizar_factura,txt_buscarFactura.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_buscarFactura.Text == "" || String.IsNullOrWhiteSpace(txt_buscarFactura.Text))
                {
                    MessageBox.Show("Ingrese un número de factura", "Mensaje", MessageBoxButtons.OK);
                    return;
                }
                var facturaIngresada=_context.Factura.Where(numFac=>numFac.NumeroFactura==txt_buscarFactura.Text).FirstOrDefault();
                if (facturaIngresada != null)
                {
                    this.visualizar_facturaTableAdapter.Fill(ds_Ventas.visualizar_factura, txt_buscarFactura.Text);
                    this.reportviewer_factura.RefreshReport();
                    txt_buscarFactura.Text = "";
                }
                else
                {
                    MessageBox.Show("La factura ingresada no existe...", "Mensaje", MessageBoxButtons.OK);
                    return;
                }                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Error",MessageBoxButtons.YesNo,MessageBoxIcon.Error);
                throw new Exception("Error: "+ex.Message);
            }
            
        }
    }
}
