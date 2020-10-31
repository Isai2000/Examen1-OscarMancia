using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Repaso2.Formularios
{
    public partial class FrmSalarioV1 : Form
    {
        Clases.Helpers h = new Clases.Helpers();
        public FrmSalarioV1()
        {
            InitializeComponent();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (TxtCodigo .Text .Trim ().Length == 0)
            {

                h.MsgWarnig("EL CAMPO CODIGO ES REQUERIDO");
                TxtCodigo.Focus();
                return;
            }
            if (TxtNombre .Text .Trim ().Length == 0)
            {
                h.MsgWarnig("EL CAMPO NOMBRE ES REQUERIO");
                TxtNombre.Focus();
                return;
            }
            if (TxtRuta .Text .Trim ().Length == 0)
            {
                h.MsgWarnig("EL CAMPO RUTA ES REQUEDIRO ");
                TxtRuta.Focus();
                return;
            }
            if (DtpFecha .Value >DateTime .Today )
            {
                h.MsgWarnig("LA FEHCA NO PUEDE SER MAYOR QUE EL SISTEMA");
                DtpFecha.Focus();
                return;
            }
            if (h.CheckIfIsNumber (TxtVenta .Text .Trim ())=="N")
            {
                h.MsgWarnig("CAMPO REQUERIDO");
                TxtVenta.Focus();
                return;
            }

            string cod, vendedor, ruta, fehca, venta;
            cod = TxtCodigo.Text.Trim();
            vendedor = TxtNombre.Text.Trim();
            ruta = TxtRuta.Text.Trim();
            fehca = DtpFecha.Text;
            venta = TxtVenta.Text.Trim();
            DgvVentas.Rows.Add(cod, vendedor, ruta, fehca, venta);
            ClearFomr();

            TxtTotal.Text = (h.ReturnsNumber(TxtTotal.Text) + h.ReturnsNumber(venta)).ToString();


        }

        private void ClearFomr()
        {
            foreach (TextBox txt in this .Controls .OfType <TextBox>())
            {
                txt.Clear();
            }

            DtpFecha.Text = "";
            TxtCodigo.Focus();
        }

        private void TxtVenta_TextChanged(object sender, EventArgs e)
        {
            if (TxtVenta .Text .Trim ().Length>0)
            {
                h.AlertNotNumber(TxtVenta .Text .Trim ());
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            ClearFomr();
        }

        private void TxtTotal_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
