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

        public string TraducirForma(Idioma idioma, int cantidad)
        {
            var singular = new Dictionary<Idioma, string>
            {
                { Idioma.Castellano, "Cuadrado" },
                { Idioma.Ingles, "Square" },
                { Idioma.Italiano, "Quadrato" }
            };          

            var plural = new Dictionary<Idioma, string>
            {
                { Idioma.Castellano, "Cuadrados" },
                { Idioma.Ingles, "Squares" },
                { Idioma.Italiano, "Quadratos" }
            };

            var traducciones = cantidad > 1 ? plural : singular;

            return traducciones.TryGetValue(idioma, out var traduccion) ? traduccion : "Forma desconocida";
        }
    }
}
