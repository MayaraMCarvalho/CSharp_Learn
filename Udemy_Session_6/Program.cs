using System;
using System.Globalization;

namespace Udemy_Session_6
{
    class Program
    {
        static void Main( string[] args )
        {
            //Pensionato pensionato = new Pensionato();

            //pensionato.Alugar();

            Empresa empresa = new Empresa();

            empresa.Cadastro();
            empresa.Aumento();
            empresa.Listar();
        }
    }
}