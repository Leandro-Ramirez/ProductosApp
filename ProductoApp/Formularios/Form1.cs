#region Usos
using System;
using System.Data;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Collections.Generic;
 #endregion

namespace ProductoApp.Formularios
{
    public partial class Form1 : Form
    {
        #region Iniciar Form1
        public Form1()
        {
            InitializeComponent();
        }
        #endregion
        #region Buscador
        private void CmbBuscador_SelectedIndexChanged(object sender, EventArgs e)
        {
            //switch (cmbBuscador.SelectedIndex)
            //{
            //    case 0:
            //        //Falta
            //        break;

            //}
        }
        #endregion
        #region Panel Rando de Precio
        private void PnlRangoPrecio_Paint(object sender, PaintEventArgs e)
        {

        }
        #endregion
    }
}
