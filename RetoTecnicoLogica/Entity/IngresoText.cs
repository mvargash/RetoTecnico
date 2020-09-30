using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RetoTecnicoLogica.Interface;

namespace RetoTecnicoLogica.Entity
{
    public class IngresoText: IStrategy
    {

        public Object AlgoritmoContador(string data)
        {

            string[] dataArray = data.Split(' ');

            List<string> lstCountText = new List<string>();

            foreach (string element in dataArray)
            {
                lstCountText.Add(element);
            }

            return lstCountText;

        }


        public string GetRepeticiones(List<string> data, string filter) {


            int lenght = filter.Length;
            int countFilter = 0;

            if (lenght == 1)
            {
                foreach (string item in data) {

                    int itemlenght = item.Length;
                    string[] _letra = new string[itemlenght];

                    for (int i = 0; i < itemlenght; i++ )
                    {
                        string aux = item.Substring(i, 1);
                            _letra[i] = aux; 
                    }

                    int count = _letra.Where(x => x.Contains(filter)).Count();

                    countFilter = countFilter + count;
                }
            }
            else {

               countFilter = data.Where(x => x == filter).Count();
            }

        string response = string.Format("{0}", countFilter);

        return response;
        }
    }
}
