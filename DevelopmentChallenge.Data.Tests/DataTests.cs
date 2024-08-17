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

        [TestMethod]
        public void TestResumenListaVaciaEnCastellano()
        {
            var formas = new List<IFormaGeometrica>
            {             
            };

            var reporte = FormaGeometrica.Imprimir(formas, Idioma.Castellano);
            Assert.IsTrue(reporte.Contains("<h1>Lista vacía de formas!</h1>"));         
        }

        [TestMethod]
        public void TestResumenListaVaciaFormasEnIngles()
        {
            var formas = new List<IFormaGeometrica>
            {
            };

            var reporte = FormaGeometrica.Imprimir(formas, Idioma.Ingles);
            Assert.IsTrue(reporte.Contains("<h1>Empty list of shapes!</h1>"));
        }

     
        [TestMethod]
        public void TestResumenListaVaciaFormasEnItaliano()
        {
            var formas = new List<IFormaGeometrica>
            {
            };

            var reporte = FormaGeometrica.Imprimir(formas, Idioma.Italiano);
            Assert.IsTrue(reporte.Contains("<h1>Elenco vuoto di forme!</h1>"));
        }

        [TestMethod]
        public void TestResumenListaConUnCuadradoEnCastellano()
        {
            var formas = new List<IFormaGeometrica>
            {
                new Cuadrado(5)
            };

            var reporte = FormaGeometrica.Imprimir(formas, Idioma.Castellano);
            Assert.IsTrue(reporte.Contains("<h1>Reporte de Formas</h1>"));
            Assert.IsTrue(reporte.Contains("1 Cuadrado | Area 25 | Perimetro 20 <br/>"));
        }

        [TestMethod]
        public void TestResumenListaConUnCuadradoEnIngles()
        {
            var formas = new List<IFormaGeometrica>
            {
                new Cuadrado(5)
            };

            var reporte = FormaGeometrica.Imprimir(formas, Idioma.Ingles);
            Assert.IsTrue(reporte.Contains("<h1>Shapes report</h1>"));
            Assert.IsTrue(reporte.Contains("1 Square | Area 25 | Perimeter 20 <br/>"));
        }

        [TestMethod]
        public void TestResumenListaConUnCuadradoEnItaliano()
        {
            var formas = new List<IFormaGeometrica>
            {
                new Cuadrado(5)
            };

            var reporte = FormaGeometrica.Imprimir(formas, Idioma.Italiano);
            Assert.IsTrue(reporte.Contains("<h1>Rapporto delle forme</h1>"));
            Assert.IsTrue(reporte.Contains("1 Quadrato | Area 25 | Perimetro 20 <br/>"));
        }


        [TestMethod]
        public void TestResumenListaConMasCuadradosEnCastellano()
        {
            var formas = new List<IFormaGeometrica>
            {
                new Cuadrado(5),
                new Cuadrado(1),
                new Cuadrado(3)
            };

            var reporte = FormaGeometrica.Imprimir(formas, Idioma.Castellano);
            Assert.IsTrue(reporte.Contains("<h1>Reporte de Formas</h1>"));
            Assert.IsTrue(reporte.Contains("3 Cuadrados | Area 35 | Perimetro 36 <br/>"));
            Assert.IsTrue(reporte.Contains("TOTAL:<br/>3 formas Perimetro 36 Area 35"));
        }


        [TestMethod]
        public void TestResumenListaConMasCuadradosEnIngles()
        {
            var formas = new List<IFormaGeometrica>
            {
                new Cuadrado(5),
                new Cuadrado(1),
                new Cuadrado(3)
            };

            var reporte = FormaGeometrica.Imprimir(formas, Idioma.Ingles);
            Assert.IsTrue(reporte.Contains("<h1>Shapes report</h1>"));
            Assert.IsTrue(reporte.Contains("3 Squares | Area 35 | Perimeter 36 <br/>"));
            Assert.IsTrue(reporte.Contains("TOTAL:<br/>3 shapes Perimeter 36 Area 35"));
        }

        [TestMethod]
        public void TestResumenListaConMasCuadradosEnItaliano()
        {
            var formas = new List<IFormaGeometrica>
            {
                new Cuadrado(5),
                new Cuadrado(1),
                new Cuadrado(3)
            };

            var reporte = FormaGeometrica.Imprimir(formas, Idioma.Italiano);
            Assert.IsTrue(reporte.Contains("<h1>Rapporto delle forme</h1>"));
            Assert.IsTrue(reporte.Contains("3 Quadratos | Area 35 | Perimetro 36 <br/>"));
            Assert.IsTrue(reporte.Contains("TOTAL:<br/>3 formes Perimetro 36 Area 35"));
        }


        [TestMethod]
        public void TestResumenListaConMasTiposEnCastellano()
        {
            var formas = new List<IFormaGeometrica>
            {
                new Cuadrado(5),
                new Circulo(3),
                new TrianguloEquilatero(4),
                new Cuadrado(2),
                new TrianguloEquilatero(9),
                new Circulo(2.75m),
                new TrianguloEquilatero(4.2m)
            };

            var reporte = FormaGeometrica.Imprimir(formas, Idioma.Castellano);
            Assert.IsTrue(reporte.Contains("<h1>Reporte de Formas</h1>"));
            Assert.IsTrue(reporte.Contains("2 Cuadrados | Area 29 | Perimetro 28 <br/>"));
            Assert.IsTrue(reporte.Contains("2 Círculos | Area 52,03 | Perimetro 36,13 <br/>"));
            Assert.IsTrue(reporte.Contains("3 Triángulos | Area 49,64 | Perimetro 51,6 <br/>"));
            Assert.IsTrue(reporte.Contains("TOTAL:<br/>7 formas Perimetro 115,73 Area 130,67"));
        }

        [TestMethod]
        public void TestResumenListaConMasTiposEnIngles()
        {
            var formas = new List<IFormaGeometrica>
            {
                new Cuadrado(5),
                new Circulo(3),
                new TrianguloEquilatero(4),
                new Cuadrado(2),
                new TrianguloEquilatero(9),
                new Circulo(2.75m),
                new TrianguloEquilatero(4.2m)
            };

            var reporte = FormaGeometrica.Imprimir(formas, Idioma.Ingles);
            Assert.IsTrue(reporte.Contains("<h1>Shapes report</h1>"));
            Assert.IsTrue(reporte.Contains("2 Squares | Area 29 | Perimeter 28 <br/>"));
            Assert.IsTrue(reporte.Contains("2 Circles | Area 52,03 | Perimeter 36,13 <br/>"));
            Assert.IsTrue(reporte.Contains("3 Triangles | Area 49,64 | Perimeter 51,6 <br/>"));
            Assert.IsTrue(reporte.Contains("TOTAL:<br/>7 shapes Perimeter 115,73 Area 130,67"));
        }

        [TestMethod]
        public void TestResumenListaConMasTiposEnItaliano()
        {
            var formas = new List<IFormaGeometrica>
            {
                new Cuadrado(5),
                new Circulo(3),
                new TrianguloEquilatero(4),
                new Cuadrado(2),
                new TrianguloEquilatero(9),
                new Circulo(2.75m),
                new TrianguloEquilatero(4.2m)
            };

            var reporte = FormaGeometrica.Imprimir(formas, Idioma.Italiano);
            Assert.IsTrue(reporte.Contains("<h1>Rapporto delle forme</h1>"));
            Assert.IsTrue(reporte.Contains("2 Quadratos | Area 29 | Perimetro 28 <br/>"));
            Assert.IsTrue(reporte.Contains("2 Cerchi | Area 52,03 | Perimetro 36,13 <br/>"));
            Assert.IsTrue(reporte.Contains("3 Triangolos | Area 49,64 | Perimetro 51,6 <br/>"));
            Assert.IsTrue(reporte.Contains("TOTAL:<br/>7 formes Perimetro 115,73 Area 130,67"));
        }


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
            Assert.IsTrue(reporte.Contains("TOTAL:<br/>4 formes Perimetro 125,22 Area 389,75"));
        }
    }
}