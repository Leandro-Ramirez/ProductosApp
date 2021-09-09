#region Usos
using System;
using System.Text;
using Dominio.Entidades;
using Dominio.Enumerador;
using System.Collections.Generic;
#endregion
#region Infraestructura
namespace Infraestructura.Productos
{
    public class ProductoModelo
    {
        private Producto[] productos;
        #region CRUD
        public void Añadir(Producto p)
        {
            if (p == null)
            {
                throw new ArgumentException("El Producto no puede ser null");
            }
            Añadir(p, ref productos);
        }
        public int Actualizar(Producto p)
        {
            if (p == null)
            {
                throw new ArgumentException("El Producto no puede ser null");
            }
            int indice = ObtenerIndiceId(p.Id);
            if (indice < 0)
            {
                throw new ArgumentException($"El Producto con Id:{p.Id} no exixte");
            }
            productos[indice] = p;
            return indice;
        }
        public bool Eliminar(Producto p)
        {
            if (p == null)
            {
                throw new ArgumentException("El Producto no puede ser null");
            }
            int indice = ObtenerIndiceId(p.Id);
            if (indice < 0)
            {
                throw new ArgumentException($"El Producto con Id:{p.Id} no exixte");
            }
            if (indice != (productos.Length - 1))
            {
                productos[indice] = productos[productos.Length - 1];
            }
            Producto[] tmp = new Producto[productos.Length - 1];
            Array.Copy(productos, tmp, tmp.Length);
            productos = tmp;

            return productos.Length == tmp.Length;
        }
        public Producto[] ObtenerTodo()
        {
            return productos;
        }
        #endregion
        #region Consultas
        public Producto ObtenerProductoId(int id)
        {
            int indice = ObtenerIndiceId(id);
            return indice < 0 ? null :productos[indice];
        }
        public Producto[] ObtenerProductoUnidadMedida(UnidadMedida um)
        {
            Producto[] tmp = null;
            if (productos == null)
            {
                return tmp;
            }
            foreach (Producto p in productos)
            {
                if (p.UnidadMedida == um)
                {
                    Añadir(p, ref tmp);
                }
            }
            return tmp;
        }
        public Producto[] ObtenerProductoVencimiento(DateTime dt)
        {
            Producto[] tmp = null;
            if (productos == null)
            {
                return tmp;
            }
            foreach (Producto p in productos)
            {
                if (p.FechaVencimiento.CompareTo(dt)<=0)
                {
                    Añadir(p, ref tmp);
                }
            }
            return tmp;
        }
        //public void 
        //Falta
        #endregion
        #region Metodo Privado
        private void Añadir(Producto p, ref Producto[] pds)
        {
            if (pds == null)
            {
                pds = new Producto[1];
                pds[pds.Length - 1] = p;
                return;
            }
            Producto[] tmp = new Producto[pds.Length + 1];
            Array.Copy(pds, tmp, pds.Length);
            tmp[tmp.Length - 1] = p;
            pds = tmp;
        }
        private int ObtenerIndiceId(int id)
        {
            int indice = int.MinValue, i = 0;
            if (id <= 0)
            {
                throw new ArgumentException($"El Id:{id} no puede ser menor o igual que cero");
            }
            if (productos == null)
            {
                return indice;
            }
            foreach (Producto p in productos)
            {
                if (p.Id == id)
                {
                    indice = i;
                    break;
                }
                i++;
            }
            return indice;
        }
        #endregion
    }
}
#endregion