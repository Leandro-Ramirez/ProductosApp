#region Usos
using System;
using System.Data;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using System.Threading.Tasks;
using Infraestructura.Productos;
using System.Collections.Generic;
#endregion

namespace ProductoApp.Formularios
{
    public partial class FormProducto : Form
    {
        public ProductoModelo ProductoModel { get; set; }
        public FormProducto()
        {
            InitializeComponent();
        }
    }
}
