using DevelopmentChallenge.Data.Enums;
using DevelopmentChallenge.Data.Interfaces;
using System;
using System.Collections.Generic;

namespace DevelopmentChallenge.Data.Classes
{
    public class TrianguloEquilatero : IFormaGeometrica
    {
        private readonly decimal _lado;

        public TrianguloEquilatero(decimal lado)
        {
            _lado = lado;
        }

        public decimal CalcularArea()
        {
            return ((decimal)Math.Sqrt(3) / 4) * _lado * _lado;
        }

        public decimal CalcularPerimetro()
        {
            return _lado * 3;
        }    

        public string TraducirForma(Idioma idioma)
        {
            var traducciones = new Dictionary<Idioma, string>
            {
                { Idioma.Castellano, "Triángulo" },
                { Idioma.Ingles, "Triangle" },
                { Idioma.Italiano, "Triangolo" }
            };

            return traducciones.TryGetValue(idioma, out var traduccion) ? traduccion : "Forma desconocida";
        }
    }
}
