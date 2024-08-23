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
            TraduccionesFormas traduccionesFormas = new TraduccionesFormas();

            if (traduccionesFormas.CuadradoTraducciones.TryGetValue(idioma, out var traduccion))
            {
                return cantidad > 1 ? traduccion.Plural : traduccion.Singular;
            }
            return "Forma desconocida";
        }
    }
}
