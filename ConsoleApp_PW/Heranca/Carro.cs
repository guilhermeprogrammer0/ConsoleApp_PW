using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_PW.Heranca
{
    public class Carro : Veiculo//Dois pontos e o nome da classe representa heranca
    {
        public bool cintoSeguranca;
        public bool arCondicionado;
        public string marcaRadio;
        public string fabricante;

        public string exibirMarca()
        {
            return "\n O fabricante deste veículo é: " + fabricante;
        }




    }
}
