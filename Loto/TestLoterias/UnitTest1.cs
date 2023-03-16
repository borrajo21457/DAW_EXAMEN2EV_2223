using LotoClassNS;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestLoterias
{
    [TestClass]
    public class UnitTest1
    {
       // int[] misnums1 = new int[6] { 4, 6, 8, 10, 12, -500 };
        int[] misnums2 = new int[6] { 4, 6, 8, 10, 12, 21 };
        int[] misnum3 = new int[6] { 4, 6, 8, 10, 12, 500 };

        [TestMethod]
       // [ExpectedException(typeof(ArgumentNullException))]
        public void NumeroNegativo()
        {
            int[] misnums= new int[6] {4,6,8,10,12,-500};

            loto lototest= new loto(misnums);
            try
            {
                for (int i = 0; i < misnums.Length; i++)
                {
                    if (misnums[i] == 4)
                    {
                        Assert.AreEqual(i, lototest.Comprobar(misnums), 0.001, "Excepcion Numero no valido");
                    }
                }
            }
            catch (Exception Error)
            {
                throw new Exception(Error.Message);
               
            }
               
        }
        [TestMethod]
        // [ExpectedException(typeof(ArgumentNullException))]
        public void NumeroValido(int[] misnums2)
        {
            loto lototest = new loto(misnums2);
            try
            {
                for (int i = 0; i < misnums2.Length; i++)
                {
                    if (misnums2[i] == 4)
                    {
                        Assert.AreEqual(i, lototest.Comprobar(misnums2), 0.001, "Excepcion Numero no valido");
                    }

                }
            }
            catch (Exception Error)
            {

                throw new Exception(Error.Message);
            }
            
        }
        [TestMethod]
        // [ExpectedException(typeof(ArgumentNullException))]
        public void NumeroSuperior(int[] misnums3)
        {
            loto lototest = new loto(misnums3);
            try
            {
                for (int i = 0; i < misnums3.Length; i++)
                {
                    if (misnum3[i] == 4)
                    {
                        Assert.AreEqual(i, lototest.Comprobar(misnums3), 0.001, "Excepcion Numero no valido");
                    }

                }
            }
            catch (Exception Error)
            {


                throw new Exception(Error.Message);
            }
            
        }

    }
}
