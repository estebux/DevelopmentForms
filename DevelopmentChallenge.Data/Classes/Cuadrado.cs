using DevelopmentChallenge.Data.Enums;
using DevelopmentChallenge.Data.Interfaces;
using System.Collections.Generic;

namespace DevelopmentChallenge.Data.Classes
{
    public class Cuadrado : IFormaGeometrica
    {
        private readonly decimal _lado;

        public Cuadrado(decimal lado)
        {
            _lado = lado;
        }

        public decimal CalcularArea()
        {
            return _lado * _lado;
        }

        public decimal CalcularPerimetro()
        {
            return _lado * 4;
        }    

        public string TraducirForma(Idioma idioma)
        {
            var traducciones = new Dictionary<Idioma, string>
            {
                { Idioma.Castellano, "Cuadrado" },
                { Idioma.Ingles, "Square" },
                { Idioma.Italiano, "Quadrato" }
            };

            return traducciones.TryGetValue(idioma, out var traduccion) ? traduccion : "Forma desconocida";
        }
    }
}
