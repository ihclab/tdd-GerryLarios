using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ordenamiento.pruebas
{
    [TestClass]
    public class PruebasOrdenamiento
    {
        private int[] salidaEsperada = new int[] { 1,2,3,4,5 };
        private int[] salidaEsperada2 = new int[] { 1,1,1,1,1 };
        private int[] salidaEsperada3 = new int[] { 1,3,4,4,5 };

        private ordenamiento.Burbuja ordenar = new ordenamiento.Burbuja();

        [TestMethod]
        public void TestInvertido()
        {
            int[] entrada = new int[] { 5,4,3,2,1 };
            ordenar.Ordenar(entrada);
            CollectionAssert.AreEqual(salidaEsperada, entrada);
        }

        [TestMethod]
        public void TestOrdenado()
        {
            int[] entrada = new int[] { 1,2,3,4,5 };
            ordenar.Ordenar(entrada);
            CollectionAssert.AreEqual(salidaEsperada, entrada);
        }

    }
}
