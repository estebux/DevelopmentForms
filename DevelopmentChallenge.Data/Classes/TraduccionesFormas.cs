using DevelopmentChallenge.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Classes
{
    public class TraduccionesFormas
    {
        public readonly Dictionary<Idioma, (string Singular, string Plural)> TrapecioRectanguloTraducciones =
                        new Dictionary<Idioma, (string Singular, string Plural)>
                        {
                              { Idioma.Castellano, ("Trapecio Rectángulo", "Trapecios Rectángulos") },
                              { Idioma.Ingles, ("Right Trapeze", "Right Trapezes") },
                              { Idioma.Italiano, ("Trapezio Rettangolo", "Trapezi Rettangoli") }
                        };

        public readonly Dictionary<Idioma, (string Singular, string Plural)> CirculoTraducciones =
                    new Dictionary<Idioma, (string Singular, string Plural)>
                    {
                              { Idioma.Castellano, ("Círculo", "Círculos") },
                              { Idioma.Ingles, ("Circle", "Circles") },
                              { Idioma.Italiano, ("Cerchio", "Cerchi") }
                    };

        public readonly Dictionary<Idioma, (string Singular, string Plural)> CuadradoTraducciones =
                new Dictionary<Idioma, (string Singular, string Plural)>
                {
                              { Idioma.Castellano, ("Cuadrado", "Cuadrados") },
                              { Idioma.Ingles, ("Square", "Squares") },
                              { Idioma.Italiano, ("Piazza", "Piazze") }
                };

        public readonly Dictionary<Idioma, (string Singular, string Plural)> TrianguloTraducciones =
           new Dictionary<Idioma, (string Singular, string Plural)>
           {
                              { Idioma.Castellano, ("Triángulo", "Triángulos") },
                              { Idioma.Ingles, ("Triangle", "Triangles") },
                              { Idioma.Italiano, ("Triangolo", "Triangoli") }
           };
    }
}
