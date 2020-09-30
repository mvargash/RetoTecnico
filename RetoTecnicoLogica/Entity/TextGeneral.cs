using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RetoTecnicoLogica.Interface;

namespace RetoTecnicoLogica.Entity
{
    public class TextGeneral
    {
        private string _Text;
        private IStrategy _strategy;

        public TextGeneral() {

            this._Text = "Cu@lquier lugar de Miraflores hace que uno se sienta en casa y cómodo, seguro y sin apremios. De todas maneras, es mejor tener los ojos abierto por seguridad y para disfrutar el paisaje, especialmente en Larcomar. Miraflores es un lugar muy bonito muy turístico, hay muchas actividades que se pueden hacer al aire libre, hay restaurantes, bares, discotec@s, Malls, y mucha vida nocturna. Realmente el distrito más hermoso de Lima con sus playas, su arquitectura moderna, todos los centros comerciales, bancos, restaurantes, bares, clubes son de excelente calidad, super seguro, mucha vigilancia. Me encanta es un lindo lugar para caminar, hacer deporte y las plazas están muy bien cuidadas y limpias. El parque del Amor y la costanera es un buen lugar para tomar un café y mirar el mar. Hay restaurantes muy ricos y atención excelente. El domingo hay actividades libres en los parques. @cceso cercano a todo. Miraflores es uno de los distritos más progresista y moderno de Lima. Se concentran aquí edificios de negocios e industrias, pero también áreas de esparcimiento, parques, lugares turísticos y muchos hoteles y restaurantes. Realmente uno de los mejores lugares para alojar y vacacionar. Fuimos el año pasado con unos amigos a participar de los Juegos Panamericanos, como voluntarios. Nos hospedamos en 2 departamentos en Miraflores. La verdad la zona muy linda y tranquila. Lo único para criticar es el transporte público, sucio, descuidado y horrible. La comida muy rica y la gente muy amable. Hemos estado por varios lugares de Lima pero!! nos ha sorprendido mucho el cambio que hay de un barrió a otro. Miraflores hay hasta carril bicicleta, pero en el distrito de la victoria no se respeta ni los semáforos, mucha basura por las calles y desorganización.";
        }

        public TextGeneral(IStrategy strategy)
        {
            this._strategy = strategy;
        }

        public void SetStrategy(IStrategy strategy)
        {
            this._strategy = strategy;
        }


        public List<string> ContarRepeticiones()
        {

            List<string> result = (List<string>)this._strategy.AlgoritmoContador(this._Text);

            return result;
        }

    }
}
