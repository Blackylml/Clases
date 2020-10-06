 //bibliotecas
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 //proyecto
namespace Clases
{
    //clase
    class Program
    {
        //metodo
        //static = global
        //void = sin registro de valores
        //main = nombre del metodo
        //(argumentos que hara uso el meyodo)
        static void Main(string[] args)
        {
            Metodos m = new Metodos(); //Construyendo objeto

            m.mensaje();

            Console.ReadKey();


        }
    }
}
