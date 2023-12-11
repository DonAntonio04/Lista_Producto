using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Producto
{
    public class Lista_Producto
    {
        Nodo primero;

        public Lista_Producto()
        {
            primero = null;
        }
        public bool ListaVacia()
        {
           return primero == null;
           
        }
        public void Insertar(Producto producto)
        {
            Nodo nodoActual = new Nodo(producto);
            if (ListaVacia())
            {
                primero = nodoActual;
                return;
            }
            Nodo actual = primero;
            while(actual.Siguiente != null)
            {
                actual = actual.Siguiente;
            }
            actual.Siguiente = nodoActual;
        }
        public void BuscarPrecio(int precio)
        {
            Nodo actual = primero;
            int posiciom = 0;
            bool encontado = false;
            while( actual != null )
            {
                if( actual.Valor.Precio == precio )
                {
                    Console.WriteLine($"El precio {precio} se ha encontrado ");
                    Console.WriteLine(actual.Valor);
                    encontado = true;
                    break;
                }
                actual = actual.Siguiente;
                posiciom++;
            }
            if ( !encontado )
            {
                Console.WriteLine("No se encuentra ese precio");
            }
           
        }
        public void ordenarDecedente()
        {
            if(ListaVacia() || primero == null)
            {
                return;
            }
            bool ordenar;
            do
            {
                ordenar = false;
                Nodo actual = primero;
                Nodo siguinte = primero.Siguiente;
                while(siguinte != null)
                {
                    if(siguinte.Valor.Precio < actual.Valor.Precio )
                    {
                        Producto temp = actual.Valor;
                        actual.Valor = siguinte.Valor;
                        siguinte.Valor = temp;
                        ordenar = true;
                    }
                    actual = siguinte;
                    siguinte = siguinte.Siguiente;  
                
                }
            }while( ordenar );
        }
        public void Mostrar()
        {
            Nodo actual = primero;
            while( actual == null )
            {
                Console.WriteLine("Esta vacía");
            }
            while( actual != null )
            {
                Console.WriteLine("Lista de los productos");
            }

        }
    }
}
