using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Generar una clase estática llamada ParseadoraDeEnteros.

Agregar un método TryParse(string, out int) : bool cuyo funcionamiento sea exactamente igual al de Int32.TryParse.
Agregar un método Parse(string) : int cuyo funcionamiento sea exactamente igual al de Int32.Parse.

Capturar por separado las excepciones:
*-FormatException: agregará al mensaje “... por error de formato”.
*-OverflowException: agregará al mensaje “... por tamaño del dato”

En caso de falla, deberá devolver la excepción ErrorParserException generada por el alumno, con el mensaje 
“El string no podrá ser convertido”. 
Utilizar la propiedad InnerException de la clase padre.
Dentro de ambos métodos, para convertir de String a Entero, utilizar Int32.Parse. Controlar las excepciones dentro de 
los métodos y luego lanzarlas.

NOTAS:
El método Parse deberá capturar y lanzar (throw) la excepción capturada.

 * */
namespace Clase14_Entidades
{

    public static class ParseadoraDeEnteros
    {
        /// <summary>
        /// Excepciones
        /// ErrorParserException:
        ///     Error al Parsear.
        /// </summary>
        public static bool TryParse(string numero, out int objetivo)
        {
            bool resultadoBoleano = false;
            int resultadoNumerico = 0;


            try
            {
                resultadoNumerico = ParseadoraDeEnteros.Parse(numero);
                resultadoBoleano = true;
            }
            catch (ErrorParserException)
            {

            }




            objetivo = resultadoNumerico;
            return resultadoBoleano;
        }

        /// <summary>
        /// Excepciones
        /// FormatException
        ///     Error De formato.
        /// OverflowException
        ///     Supera los limites de int.    
        /// </summary>
        public static int Parse(string numero)
        {
            int resultado = 0;
            try
            {
                resultado = int.Parse(numero);
            }
            catch (FormatException e)
            {
                throw new ErrorParserException("El string no podrá ser convertido: ", e);
            }
            catch (OverflowException e)
            {
                throw new ErrorParserException("El string no podrá ser convertido: ", e);
            }
            catch (Exception e)
            {
                throw new ErrorParserException("El string no podrá ser convertido: ", e);
            }



            return resultado;
        }
    }
}
