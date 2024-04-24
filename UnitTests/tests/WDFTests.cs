namespace UnitTests.tests
{
    public class WDFTests
    {
        public static void WorldsDumbestFunction_ReturnsPikachuIfZeroTest_ReturnsString()
        {
            try
            {
                //arrange
                WorldsDumbestFunction wdf = new WorldsDumbestFunction();
                //act
                string result = wdf.ReturnsPikachuIfZero(0);
                //assert
                if (result == "Pikachu")
                {
                    Console.WriteLine("Test Passed");
                }
                else
                {
                    Console.WriteLine("Test Failed");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }



        }
    }
}
