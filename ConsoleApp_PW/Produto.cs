using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_PW
{
     public class Produto
    {
        private int id;
        private decimal valor;
        private string descricao;

        public Produto(int id, decimal valor, string descricao)
        {
            Id = id;
            Valor = valor;
            Descricao = descricao;
        }

        public int getId()
        {
            return id;
        }

        public decimal getValor()
        {
            return valor;
        }

        public string getDescricao()
        {
            return descricao;
        }

        public void setId(int id)
        {
            Id = id; 
        }

        public void setValor(decimal valor)
        {
            Valor = valor; 
        }

        public void setDescricao(string descricao)
        {
            Descricao = descricao;
        }



    }
}
