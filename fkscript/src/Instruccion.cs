using System;
using System.Collections.Generic;
using System.Text;

namespace FKVM
{
    class Instruccion
    {
        public string nombre;   //Nombre de la instrucci�n
        public int opcode;      //C�digo de instrucci�n
        public int numpar;      //N�mero de par�metros

        public Instruccion(string nombre, int opcode, int numpar)
        {
            this.nombre = nombre;
            this.opcode = opcode;
            this.numpar = numpar;
        }
    }
}
