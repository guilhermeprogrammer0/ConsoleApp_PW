using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_PW.Heranca
{
    public class Veiculo
    {
        public int numeroAssentos;
        public int numeroPortas;
        public bool temMotor;

        public string exibirDados()
        {
            if(temMotor == true)
            {
                return  "\n Com motor, N° de Assentos: " + this.numeroAssentos + " \n N° de Portas: " + this.numeroPortas;
            }
            else
            {
                return "N° de Assentos:  " + this.numeroAssentos + " \n N° de Portas: " + this.numeroPortas;
            }

           
        }





    }

}
