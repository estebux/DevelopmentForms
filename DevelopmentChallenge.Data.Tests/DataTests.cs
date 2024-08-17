using System.Collections.Generic;
using DevelopmentChallenge.Data.Classes;
using DevelopmentChallenge.Data.Enums;
using DevelopmentChallenge.Data.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DevelopmentChallenge.Tests
{
    [TestClass]
    public class DataTests
    {
        public void TestResumenListaVaciaFormasEnIngles()
        [TestMethod]
        public void TestImprimirReporteCastellano()
        {
            var formas = new List<IFormaGeometrica>
            {
                new Cuadrado(5),
                new Circulo(10),
                new TrianguloEquilatero(6),
                new TrapecioRectangulo(8, 6, 5)
            };

            var reporte = FormaGeometrica.Imprimir(formas, Idioma.Castellano);
            Assert.IsTrue(reporte.Contains("<h1>Reporte de Formas</h1>"));
            Assert.IsTrue(reporte.Contains("1 Cuadrado | Area 25 | Perimetro 20 <br/>"));
            Assert.IsTrue(reporte.Contains("1 Círculo | Area 314,16 | Perimetro 62,83 <br/>"));
            Assert.IsTrue(reporte.Contains("1 Triángulo | Area 15,59 | Perimetro 18 <br/>"));
            Assert.IsTrue(reporte.Contains("1 Trapecio Rectángulo | Area 35 | Perimetro 24,39 <br/>"));
            Assert.IsTrue(reporte.Contains("TOTAL:<br/>4 formas Perimetro 125,22 Area 389,75"));
        }

        [TestMethod]
        public void TestImprimirReporteIngles()
        {
            var formas = new List<IFormaGeometrica>
            {
                new Cuadrado(5),
                new Circulo(10),
                new TrianguloEquilatero(6),
                new TrapecioRectangulo(8, 6, 5)
            };

            var reporte = FormaGeometrica.Imprimir(formas, Idioma.Ingles);
            Assert.IsTrue(reporte.Contains("<h1>Shapes report</h1>"));
            Assert.IsTrue(reporte.Contains("1 Square | Area 25 | Perimeter 20 <br/>"));
            Assert.IsTrue(reporte.Contains("1 Circle | Area 314,16 | Perimeter 62,83 <br/>"));
            Assert.IsTrue(reporte.Contains("1 Triangle | Area 15,59 | Perimeter 18 <br/>"));
            Assert.IsTrue(reporte.Contains("1 Right Trapeze | Area 35 | Perimeter 24,39 <br/>"));
            Assert.IsTrue(reporte.Contains("TOTAL:<br/>4 shapes Perimeter 125,22 Area 389,75"));
        }

        [TestMethod]
        public void TestImprimirReporteItaliano()
        {
            var formas = new List<IFormaGeometrica>
            {
                new Cuadrado(5),
                new Circulo(10),
                new TrianguloEquilatero(6),
                new TrapecioRectangulo(8, 6, 5)
            };

            var reporte = FormaGeometrica.Imprimir(formas, Idioma.Italiano);
            Assert.IsTrue(reporte.Contains("<h1>Rapporto delle forme</h1>"));
            Assert.IsTrue(reporte.Contains("1 Quadrato | Area 25 | Perimetro 20 <br/>"));
            Assert.IsTrue(reporte.Contains("1 Cerchio | Area 314,16 | Perimetro 62,83 <br/>"));
            Assert.IsTrue(reporte.Contains("1 Triangolo | Area 15,59 | Perimetro 18 <br/>"));
            Assert.IsTrue(reporte.Contains("1 Trapezio Rettangolo | Area 35 | Perimetro 24,39 <br/>"));
            Assert.IsTrue(reporte.Contains("TOTAL:<br/>4 forme Perimetro 125,22 Area 389,75"));
        }
    }
}