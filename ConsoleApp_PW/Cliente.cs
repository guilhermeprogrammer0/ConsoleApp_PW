using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_PW
{
    public class Cliente
    {
        private int Id;
        private string Nome;
        private string Telefone;

        public Cliente(int id, string nome, string telefone)
        {
            Id = id;
            Nome = nome;
            Telefone = telefone;
        }

        public int getId()
        {
            return Id;
        }
        public string getNome()
        {
            return Nome;
        }
        public string getTelefone()
        {
            return Telefone;
        }
        public void setId( int id)
        {
            Id = id;
        }
        public void setNome(string nome)
        {
            Nome = nome;
        }
        public void setTelefone(string telefone)
        {
            Telefone = telefone;
        }
    }
}
