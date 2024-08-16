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

        public string TraducirForma(Idioma idioma)
        {
            var traducciones = new Dictionary<Idioma, string>
            {
                { Idioma.Castellano, "Círculo" },
                { Idioma.Ingles, "Circle" },
                { Idioma.Italiano, "Cerchio" }
            };

            return traducciones.TryGetValue(idioma, out var traduccion) ? traduccion : "Forma desconocida";
        }
    }
}
