using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_PW
{
    public class Endereco
    {
        private string Rua;
        private string Numero;
        private string Bairro;
        private string Cep;
        private string Cidade;
        private string Estado;
    
        public Endereco(string rua, string numero, string bairro, string cep, string cidade, string estado)
        {
            this.Rua = rua;
            this.Numero = numero;
            this.Bairro = bairro;
            this.Cep = cep;
            this.Cidade = cidade;
            this.Estado = estado;

        }      
        
        public string getRua()
        {
            return this.Rua;
        }
        public string getNumero() 
        {
            return this.Numero;
        }
        public string getBairro()
        {
            return this.Bairro;
        }
        public string getCep()
        {
            return this.Cep;
        }
        public string getCidade()
        {
            return this.Cidade;
        }
          public string getEstado()
        {
            return this.Estado;
        }
        public void setRua(string rua)
        {
            this.Rua= rua;
        }
        public void setNumero(string numero)
        {
            this.Numero= numero;
        }
        public void setBairro(string bairro)
        {
            this.Bairro= bairro;
        }
        public void setCep(string cep)
        {
            this.Cep= cep;
        }
        public void setCidade(string cidade)
        {
            this.Cidade = cidade;
        }
        public void setEstado(string estado)
        {
            this.Estado= estado;
        }

        public string  enderecoCompleto()
        {
            return "\nRua: " + this.Rua + "\n Número: " + this.Numero + "\n Bairro: " + this.Bairro + "\n CEP: " + this.Cep + " \nCidade " + this.Cidade + " \nEstado: " + this.Estado;
        }

    }
}
