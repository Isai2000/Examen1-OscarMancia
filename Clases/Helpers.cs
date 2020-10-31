using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Repaso2.Clases
{
    class Helpers
    {
        public void MsgWarnig(String msg)
        {
            MessageBox.Show(msg , "ATENCION", MessageBoxButtons.OK,MessageBoxIcon.Warning);
        }

        public void AlertNotNumber(string str)
        {
            double x;
            if (!double.TryParse (str,out x))
            {
                MsgWarnig("EL VALOR DEBE SER NUMERICO");
            }
        }

        public string CheckIfIsNumber(String str)
        {
            string resp = "";
            double x;
            if (double.TryParse(str, out x))
            {
                resp = "S";
            }
            else
            {
                resp = "N";
            }

            return resp;
        }

        public double ReturnsNumber(string str)
        {
            double valio = 0;
            if (double .TryParse (str , out valio))
            {
                valio = Convert.ToDouble(str);
            }
            return valio;
        }
    }
}
