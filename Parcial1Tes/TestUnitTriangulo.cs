namespace Parcial1Tes
{
    [TestClass]
    public sealed class TestUnitTriangulo
    {
        [TestMethod]
        public void TestTriangulo()
        {
            tria_gulo Triangulo = new Triangulo(3, 3, 3);

            double Area = Triangulo.area();
            double Perimetro = Triangulo.perimetro();

            Assert.IsTrue(Area + "El área del triángulo es: " );
            Assert.IsTrue(Perimetro + "El perímetro del triángulo es: " );
        }

    }
}
