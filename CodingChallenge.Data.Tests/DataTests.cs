using System;
using System.Collections.Generic;
using CodingChallenge.Data.Classes;
using NUnit.Framework;

namespace CodingChallenge.Data.Tests
{
    [TestFixture]
    public class DataTests
    {
        ImpresoraTraductoraFormas impresora;
        Traductor traductor;
        [SetUp]
        public void Init()
        {
            impresora = new ImpresoraTraductoraFormas();
            //agregar palabras al dic
            traductor = new Traductor();
            traductor.agregarTraduccion("List", "Lista", "spanish");
            traductor.agregarTraduccion("empty", "vacía", "spanish");
            traductor.agregarTraduccion("of", "de", "spanish");
            traductor.agregarTraduccion("shapes", "formas", "spanish");
            traductor.agregarTraduccion("Report", "Reporte", "spanish");
            traductor.agregarTraduccion("Report", "Reporte", "spanish");
            traductor.agregarTraduccion("Shapes", "Formas", "spanish");
            traductor.agregarTraduccion("Square", "Cuadrado", "spanish");
            traductor.agregarTraduccion("Squares", "Cuadrados", "spanish");
            traductor.agregarTraduccion("Circle", "Círculo", "spanish");
            traductor.agregarTraduccion("Circles", "Círculos", "spanish");
            traductor.agregarTraduccion("Rectangle", "Rectangulo", "spanish");
            traductor.agregarTraduccion("Rectangles", "Rectangulos", "spanish");
            traductor.agregarTraduccion("Perimeter", "Perimetro", "spanish");
            traductor.agregarTraduccion("Area", "Area", "spanish");
            traductor.agregarTraduccion("TOTAL", "TOTAL", "spanish");
        }

        [TestCase]
        public void TestResumenListaVacia()
        {
            Assert.AreEqual("<h1>Lista vacía de formas!</h1>", impresora.imprimir(traductor,"spanish"));
        }

        [TestCase]
        public void TestResumenListaVaciaFormasEnIngles()
        {
            Assert.AreEqual("<h1>Empty list of shapes!</h1>",
                impresora.imprimir(traductor, "spanish"));
        }

        [TestCase]
        public void TestResumenListaConUnCuadrado()
        {
            impresora.agregarForma(new Cuadrado(5));
            string resumen = impresora.imprimir(traductor, "spanish");
            Assert.AreEqual("<h1>Reporte de Formas</h1>1 Cuadrado | Area 25 | Perimetro 20 <br/>TOTAL:<br/>1 formas Perimetro 20 Area 25", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasCuadrados()
        {
            impresora.agregarForma(new Cuadrado(5));
            impresora.agregarForma(new Cuadrado(1));
            impresora.agregarForma(new Cuadrado(3));
            string resumen = impresora.imprimir(traductor, "english");

            Assert.AreEqual("<h1>Shapes report</h1>3 Squares | Area 35 | Perimeter 36 <br/>TOTAL:<br/>3 shapes Perimeter 36 Area 35", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTipos()
        {
            impresora.agregarForma(new Cuadrado(5));
            impresora.agregarForma(new Circulo(3));
            impresora.agregarForma(new TrianguloEquilatero(4));
            impresora.agregarForma(new Cuadrado(2));
            impresora.agregarForma(new TrianguloEquilatero(9));
            impresora.agregarForma(new Circulo(2.75m));
            impresora.agregarForma(new TrianguloEquilatero(4.2m));


            string resumen = impresora.imprimir(traductor, "english");

            Assert.AreEqual(
                "<h1>Shapes report</h1>2 Squares | Area 29 | Perimeter 28 <br/>2 Circles | Area 13,01 | Perimeter 18,06 <br/>3 Triangles | Area 49,64 | Perimeter 51,6 <br/>TOTAL:<br/>7 shapes Perimeter 97,66 Area 91,65",
                resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTiposEnCastellano()
        {
            impresora.agregarForma(new Cuadrado(5));
            impresora.agregarForma(new Circulo(3));
            impresora.agregarForma(new TrianguloEquilatero(4));
            impresora.agregarForma(new Cuadrado(2));
            impresora.agregarForma(new TrianguloEquilatero(9));
            impresora.agregarForma(new Circulo(2.75m));
            impresora.agregarForma(new TrianguloEquilatero(4.2m));


            string resumen = impresora.imprimir(traductor, "spanish");

            Assert.AreEqual(
                "<h1>Reporte de Formas</h1>2 Cuadrados | Area 29 | Perimetro 28 <br/>2 Círculos | Area 13,01 | Perimetro 18,06 <br/>3 Triángulos | Area 49,64 | Perimetro 51,6 <br/>TOTAL:<br/>7 formas Perimetro 97,66 Area 91,65",
                resumen);
        }
    }
}
