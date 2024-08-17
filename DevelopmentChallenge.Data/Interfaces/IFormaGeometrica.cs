using DevelopmentChallenge.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Interfaces
{
    public interface IFormaGeometrica
    {
        decimal CalcularArea();
        decimal CalcularPerimetro();
        string TraducirForma(Idioma idioma, int cantidad);
    }
}
