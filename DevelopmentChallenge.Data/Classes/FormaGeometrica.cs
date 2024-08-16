using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevelopmentChallenge.Data.Enums;
using DevelopmentChallenge.Data.Interfaces;

namespace DevelopmentChallenge.Data.Classes
{
    public static class FormaGeometrica
    {
        public static string Imprimir(List<IFormaGeometrica> formas, Idioma idioma)
        {
            var sb = new StringBuilder();

            var encabezados = new Dictionary<Idioma, string>
            {
                { Idioma.Castellano, "<h1>Reporte de Formas</h1>" },
                { Idioma.Ingles, "<h1>Shapes report</h1>" },
                { Idioma.Italiano, "<h1>Rapporto delle forme</h1>" }
            };

            var vacia = new Dictionary<Idioma, string>
            {
                { Idioma.Castellano, "<h1>Lista vacía de formas!</h1>" },
                { Idioma.Ingles, "<h1>Empty list of shapes!</h1>" },
                { Idioma.Italiano, "<h1>Elenco vuoto di forme!</h1>" }
            };

            var perimetroLabel = new Dictionary<Idioma, string>
            {
                { Idioma.Castellano, "Perimetro" },
                { Idioma.Ingles, "Perimeter" },
                { Idioma.Italiano, "Perimetro" }
            };

            var formasLabel = new Dictionary<Idioma, string>
            {
                { Idioma.Castellano, "formas" },
                { Idioma.Ingles, "shapes" },
                { Idioma.Italiano, "forme" }
            };

            if (!formas.Any())
            {
                sb.Append(vacia[idioma]);
            }
            else
            {
                sb.Append(encabezados[idioma]);

                var areaTotal = 0m;
                var perimetroTotal = 0m;

                var resumen = formas
                    .GroupBy(f => f.GetType())
                    .Select(g => new
                    {
                        Forma = g.First(),
                        Cantidad = g.Count(),
                        Area = g.Sum(f => f.CalcularArea()),
                        Perimetro = g.Sum(f => f.CalcularPerimetro())
                    });

                foreach (var forma in resumen)
                {
                    sb.Append($"{forma.Cantidad} {forma.Forma.TraducirForma(idioma)} | Area {forma.Area:#.##} | {perimetroLabel[idioma]} {forma.Perimetro:#.##} <br/>");
                    areaTotal += forma.Area;
                    perimetroTotal += forma.Perimetro;
                }

                sb.Append("TOTAL:<br/>");
                sb.Append($"{resumen.Sum(f => f.Cantidad)} {formasLabel[idioma]} ");
                sb.Append($"{perimetroLabel[idioma]} {perimetroTotal:#.##} ");
                sb.Append($"Area {areaTotal:#.##}");
            }

            return sb.ToString();
        }
    }
}
