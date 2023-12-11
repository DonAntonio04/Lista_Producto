using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Producto
{
    public class Nodo
    {
        private Producto _valor;
        private Nodo _siguiente;

        public Producto Valor
        {
            get { return _valor; }
            set { _valor = value; }
        } 
        public Nodo Siguiente
        {
            get { return _siguiente;}
            set { _siguiente = value; }
        }
        public Nodo(Producto Valor)
        {
            _valor = Valor;
            _siguiente = null;
        }
        public Nodo(Nodo Siguiente,Producto Valor)
        {
            this._siguiente = Siguiente;
            this._valor = Valor;
        }
    }
}
