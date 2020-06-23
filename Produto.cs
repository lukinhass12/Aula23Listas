using System;
using System.Collections.Generic;

namespace Aula23Listas
{
    public class Produto
    {
        private float _Preco;

        public int Codigo { get; set;}
        public string Nome {get; set;}
        public float Preco {get; set;}
        public Produto(){

        }
         public Produto( int _codigo, string _Nome, float Preco){
             this.Codigo = _codigo;
             this.Nome = _Nome;
             this.Preco = _Preco;
         }

        internal void Add(Produto produto)
        {
            throw new NotImplementedException();
        }

        internal void Add(List<Produto> produto1)
        {
            throw new NotImplementedException();
        }

        internal Produto Find(Func<object, bool> p)
        {
            throw new NotImplementedException();
        }

        internal void RemoveAt(int v)
        {
            throw new NotImplementedException();
        }

        internal void RemoveAll(Func<object, bool> p)
        {
            throw new NotImplementedException();
        }

        internal void Remove(object produtos1)
        {
            throw new NotImplementedException();
        }
    }
}