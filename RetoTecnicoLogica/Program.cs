using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RetoTecnicoLogica.Entity;
using RetoTecnicoLogica;

namespace RetoTecnicoLogica
{
    public class Program
    {

        public void ObtenerRepeticiones() {

            TextGeneral contadorText = new TextGeneral();
            contadorText.SetStrategy(new ContadorText());
            List<string> resultado = contadorText.ContarRepeticiones();
            foreach (string element in resultado)
            {

                Console.WriteLine("{0}", element);
            }
        }

        public void ObtenerRepeticiones(string filter) {

            TextGeneral contadorText = new TextGeneral();
            contadorText.SetStrategy(new IngresoText());
            List<string> lstRepeticiones = contadorText.ContarRepeticiones();

            IngresoText ingreso = new IngresoText();

            string respuesta = ingreso.GetRepeticiones(lstRepeticiones, filter);

            Console.WriteLine("{0}:: Repetición Encontrada => {1}", filter, respuesta);

        }
    }
}
