﻿using DevelopmentChallenge.Data.Enums;
using DevelopmentChallenge.Data.Interfaces;
using System;
using System.Collections.Generic;

namespace DevelopmentChallenge.Data.Classes
{
    public class TrapecioRectangulo : IFormaGeometrica
    {
        private readonly decimal _baseMayor;
        private readonly decimal _baseMenor;
        private readonly decimal _altura;
        private readonly decimal _lado1;
        private readonly decimal _lado2;

        public TrapecioRectangulo(decimal baseMayor, decimal baseMenor, decimal altura)
        {
            _baseMayor = baseMayor;
            _baseMenor = baseMenor;
            _altura = altura;
            //_lado1 = lado1;
            //_lado2 = lado2;
        }

        public decimal CalcularArea()
        {
            return ((_baseMayor + _baseMenor) / 2) * _altura;
        }

        public decimal CalcularPerimetro()
        {            
            decimal ladoOblicuo = (decimal) Math.Sqrt((double)((_baseMayor - _baseMenor) * (_baseMayor - _baseMenor) + _altura * _altura));
            return _baseMayor + _baseMenor + _altura + (decimal)ladoOblicuo;
        }

        public string TraducirForma(Idioma idioma)
        {
            var traducciones = new Dictionary<Idioma, string>
            {
                { Idioma.Castellano, "Trapecio Rectángulo" },
                { Idioma.Ingles, "Right Trapeze" },
                { Idioma.Italiano, "Trapezio Rettangolo" }
            };

            return traducciones.TryGetValue(idioma, out var traduccion) ? traduccion : "Forma desconocida";
        }
    }
}
