using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//COPIA
namespace _Formulario
{
    class Producto
    {
        private Producto _siguiente;
        public Producto siguiente
        {
            get
            {
                return _siguiente;
            }

            set
            {
                _siguiente = value;
            }
        }
        private Producto _anterior;
        public Producto anterior
        {
            get
            {
                return _anterior;
            }
            set
            {
                _anterior = value;
            }
        }

        private int _codigoDeBarras;
        public int codigoDeBarras
        {
            get
            {
                return _codigoDeBarras;
            }
        }

        private string _nombre;
        public string nombre
        {
            get
            {
                return _nombre;
            }
        }

        private int _cantidad;
        public int cantidad
        {
            get
            {
                return _cantidad;
            }
        }

        private double _precio;
        public double precio
        {
            get
            {
                return _precio;
            }
        }

        public Producto(int codigoDeBarras, string nombre, int cantidad, double precio)
        {
            _codigoDeBarras = codigoDeBarras;
            _nombre = nombre;
            _cantidad = cantidad;
            _precio = precio;
        }

        public override string ToString()
        {
            string mostrar = "";

            mostrar += "Codigo de barras: " + _codigoDeBarras + Environment.NewLine;
            mostrar += "Nombre del producto: " + _nombre + Environment.NewLine;
            mostrar += "Cantidad de producto: " + _cantidad + Environment.NewLine;
            mostrar += "Precio del producto: " + _precio + Environment.NewLine;

            return mostrar;
        }


    }
}
