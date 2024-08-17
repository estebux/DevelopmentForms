using DevelopmentChallenge.Data.Enums;
using DevelopmentChallenge.Data.Interfaces;
using System;
using System.Collections.Generic;

namespace DevelopmentChallenge.Data.Classes
{

    public class Circulo : IFormaGeometrica
    {
        private readonly decimal _radio;

        public Circulo(decimal radio)
        {
            _radio = radio;
        }

        public decimal CalcularArea()
        {
            return (decimal)Math.PI * (_radio * _radio);
        }

        public decimal CalcularPerimetro()
        {
            return 2 * (decimal)Math.PI * _radio;
        }

        public string TraducirForma(Idioma idioma, int cantidad)
        {
            var singular = new Dictionary<Idioma, string>
            {                
                { Idioma.Castellano, "Círculo" },
                { Idioma.Ingles, "Circle" },
                { Idioma.Italiano, "Cerchio" }
            };

            var plural = new Dictionary<Idioma, string>
            {
                { Idioma.Castellano, "Círculos" },
                { Idioma.Ingles, "Circles" },
                { Idioma.Italiano, "Cerchi" }
            };

            var traducciones = cantidad > 1 ? plural : singular;

            return traducciones.TryGetValue(idioma, out var traduccion) ? traduccion : "Forma desconocida";
        }
    }
}
