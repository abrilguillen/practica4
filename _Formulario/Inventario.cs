using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _Formulario
{
    ////////////////////////LISTAS DOBLES////////////////////////////////////
    class Inventario
    {
        private Producto inicio;

        //almacena el indice que tienen los productos (numero de productos)
        private int _indiceProducto;
        
        public Inventario()
        {
            _indiceProducto = 0;
        }

        public override string ToString()
        {
            return "Total de productos: " + _indiceProducto;
        }

        public void agregarProducto(Producto producto)
        {
            
            if (inicio == null)
            {
                inicio = producto;
            }
            else
            {
                //el anterior del iniicio no tiene nada, El puntero anterior del primer elemento debe apuntar hacia NULL
                Producto temporal = inicio;

                while (temporal.siguiente != null)
                {
                    temporal = temporal.siguiente;
                }

                producto.anterior = temporal;
                temporal.siguiente = producto;
            }
            _indiceProducto++;
            
        }

        public void agregarProductoInicio(Producto producto)
        {
            //validar que inicio sea diferente a null
            if (inicio != null)
            {
                //teniendo A.B.C y queremos agregar G al principio
                //El anterior de A = G
                inicio.anterior = producto;
                //El siguiente de G es A
                producto.siguiente = inicio;
                inicio = producto;
            }
            _indiceProducto++;
        }

        // RECURSIVIDAD
        //public void agregarProducto( Producto nuevo)
        //{
        //    if (inicio == null)
        //    {
        //        inicio = nuevo;
        //        _indiceProducto++;
        //    }
        //    else
        //        agregarProducto(nuevo, inicio);
        //}

        //private void agregarProducto(Producto nuevo, Producto ultimo)
        //{
        //    if(ultimo.siguiente == null)
        //    {
        //        ultimo.siguiente = nuevo;
        //        _indiceProducto++;
        //    }

        //    else
        //    {
        //        agregarProducto(nuevo, ultimo.siguiente);
        //    }
        //}

        public Producto buscar(int codigo)
        {
            Producto temporal = inicio;

            while (temporal != null)
            {
                if(temporal.codigoDeBarras == codigo)
                {
                    return temporal;
                }

                else
                {
                    temporal = temporal.siguiente;
                }
            }
            return null;
        }

        public void eliminarInicio()
        {
            if (inicio != null)
            {
                if (inicio.siguiente != null)
                {
                    inicio.siguiente.anterior = null;
                }

                inicio = inicio.siguiente;
                //
                _indiceProducto--;
            }
        }

        public void eliminarUltimo()
        {
            Producto temporal = inicio;

            while(temporal.siguiente != null)
            {
                temporal = temporal.siguiente;
                
            }
            temporal.anterior.siguiente = null;
        }

        public void eliminar(int codigo)
        {
            if(inicio != null)
            {
                if(inicio.codigoDeBarras == codigo)
                {
                    // A.B
                    //para eliminar la coneccion de B a A
                    if(inicio.siguiente != null)
                    {
                        inicio.siguiente.anterior = null;
                    }

                    inicio = inicio.siguiente;
                    //A = B
                    _indiceProducto--;
                }
                else
                {
                    //uso del método buscar, busca el código que se quiere eliminar
                    Producto temporal = buscar(codigo);
                    //eliminar el producto de en medio y eliminar un producto al ultimo
                    //no es necesario romper el enlace anterior en el ultimo producto para eliminarlo

                    if(temporal != null)
                    {
                        if(temporal.siguiente != null)
                        {
                            
                            temporal.siguiente.anterior = temporal.anterior;
                        }

                        temporal.anterior.siguiente = temporal.siguiente;

                        _indiceProducto--;
                    }

                }
            }

        }


        public void insertar(Producto producto, int posicion)
            //se inserta un producto dandole la posicion en la que quieres que se inserte
            //el ultimo elemento no se pierde, solo se recorre
            //el indice empieza desde 0, 0=A, 1=C...
            //si tienes A.C.D y quieres insertar B en la posicion 1 queda asi: 0,1,2,3
            //                                                                 A.B.C.D
        {   
            if(inicio != null && posicion >= 0 && posicion < _indiceProducto)
            {
                //si quiero insertar en a posicion 0
                if (posicion == 0)
                {
                    producto.siguiente = inicio;
                    inicio.anterior = producto;
                    inicio = producto;
                }
                //si quiero insertar en una posicion despues de 0 que se encuentre en medio (pos 5)
                //o para insertar en la ultima posicion
                else
                {
                    Producto temporal = inicio;
                    int indice = 0;
                    //ciclo que va hasta la posicion que le pongo para insertar 
                    //insertar en posicion 5 (teniendo 8 objetos, asi ya no se recorren todos, solo hasta 5)
                    while (indice != posicion)
                    {
                        temporal = temporal.siguiente;
                        indice++;
                    }
                    //tengo A.C.D y quiero insertar B
                    //quedaría A.B.C.D
                    //temporal debe tener el valor de la posicion que quiero insertar = B

                    // mi producto es B (porque es el producto que se inserta) apunta a C    = C
                    //B.C
                    producto.siguiente = temporal;
                    // A      = B
                    producto.anterior = temporal.anterior;
                    temporal.anterior.siguiente = producto;
                    temporal.anterior = producto;
                }
                _indiceProducto++;
            }
        }

        public string reporte()
        { 
            string mostrar = ToString() + Environment.NewLine;
            Producto temporal = inicio;

            while( temporal != null)
            {
                mostrar += "--------------------------------" + Environment.NewLine;
                mostrar += temporal.ToString();
                temporal = temporal.siguiente;
            }

            return mostrar;
        }

        public string reporteInverso()
        {
            string mostrar = "";
            Producto temporal = inicio;
            while (temporal != null)
            {
                //
                mostrar = temporal.ToString() + Environment.NewLine + mostrar;
                temporal = temporal.siguiente;

            }
            //1,2,3,4 ahora que lo muestre 4,3,2,1
            return mostrar;
        }
    }
}
