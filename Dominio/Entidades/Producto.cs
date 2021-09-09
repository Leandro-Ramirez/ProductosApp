#region Usos
using System;
using System.Text;
using Dominio.Enumerador;
using System.Collections.Generic;
#endregion
namespace Dominio.Entidades
{
    public class Producto
    {
        #region Obtener y Dar Datos
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int Exixtencia { get; set; }
        public decimal Precio { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public UnidadMedida UnidadMedida { get; set; }
        #endregion
    }
}
