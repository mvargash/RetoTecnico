using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using RetoTecnicoLogica.Interface;

namespace RetoTecnicoLogica
{
    public class ContadorText: IStrategy
    {
        public Object AlgoritmoContador(string data)
        {

            string[] dataArray = data.Split(new char[] { '.', '?', '!', ' ', ';', ':', ',' }, StringSplitOptions.RemoveEmptyEntries);

            string[] dataDistinct = dataArray.Distinct().ToArray();

            List<string> lstCountText = new List<string>();


            lstCountText.Add("REPETICIONES POR PALABRAS");
            lstCountText.Add("=========================");

            foreach (string element in dataDistinct)
            {

                var repeticiones = from word in dataArray
                                   where word == element
                                   select word;

                int wordCount = repeticiones.Count();

                   if (wordCount > 1) {
                       string respuesta = string.Format("{0} => {1}", element, wordCount);
                       lstCountText.Add(respuesta);
                   }
            }

            //para cada letra 
            int count = data.Length;
            string[] _letra = new string[count];
            int j = 0;
            for (var i = 0; i < count; i++)
            {
                string aux = data.Substring(i, 1);
                if (aux.Trim() != "")
                {
                    _letra[j] = aux;
                    j++;
                }

            }

            string[] letraDistinct = _letra.Distinct().ToArray();

            string[] sortLetra = letraDistinct.OrderBy(x => x).ToArray();



            lstCountText.Add("REPETICIONES POR  SIMBOLOS - NÚMEROS - LETRAS");
            lstCountText.Add("==============================================");


            //contamos letras, numeros y simbolos, signos
            foreach (string item in sortLetra)
            {
                if (item != null) {
                    var repeticionLetra = from letra in _letra
                                          where letra == item
                                          select letra;


                    int letraCount = repeticionLetra.Count();

                    if (letraCount > 1)
                    {
                        string response = string.Format("{0} => {1}", item, letraCount);
                        lstCountText.Add(response);
                    }
                }

            }
            return lstCountText;
        }
    }
}
