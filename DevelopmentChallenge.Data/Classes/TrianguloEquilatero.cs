﻿using DevelopmentChallenge.Data.Enums;
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


        public string TraducirForma(Idioma idioma, int cantidad)
        {
            TraduccionesFormas traduccionesFormas = new TraduccionesFormas();

            if (traduccionesFormas.TrianguloTraducciones.TryGetValue(idioma, out var traduccion))
            {
                return cantidad > 1 ? traduccion.Plural : traduccion.Singular;
            }
            return "Forma desconocida";
        }
    }
}
