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
        private Endereco Endereco;

        public Cliente(int id, string nome, string telefone,Endereco endereco)
        {
            Id = id;
            Nome = nome;
            Telefone = telefone;
            Endereco = endereco;
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
        public void setId(int id)
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
        public Endereco getEndereco()
        {
            return Endereco;
        }
        public void setEndereco(Endereco endereco)
        {
            Endereco = endereco;
        }

        public string Dados()
        {
            return "\n Id: " + this.Id + "\nNome: " + this.Nome + "\n Telefone: " + this.Telefone;
        }
    }
}