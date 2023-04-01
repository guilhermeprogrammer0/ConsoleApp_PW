using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_PW
{
    public  class Vendas
    {
	private Cliente Cliente;
	private string  Data;
        public Vendas(Cliente cliente, string data)
        {
            Cliente = cliente;
            Data = data;
        }
        public Cliente getCliente()
        {
            return Cliente;
        }
        public string getData()
        {
            return Data;
        }
        public void setCliente(Cliente cliente)
        {
            Cliente = cliente;
        }
        public void setData(string data)
        {
            Data = data;
        }
    }
}
