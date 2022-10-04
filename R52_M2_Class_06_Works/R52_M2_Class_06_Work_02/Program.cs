using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace R52_M2_Class_06_Work_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
         
            try
            {
                //throw new DivideByZeroException("Divide by zero");
                //throw new FormatException("Input wrong");
                //throw new FileNotFoundException("Wrong file");
                throw new ArgumentNullException("Oooooooooooo");
            }
            catch (DivideByZeroException dex)
            {
                Console.WriteLine($"DEX:{dex.Message}");
            }
            catch(FormatException fex)
            {
                Console.WriteLine($"FEX:{fex.Message}");
            }
            catch(FileNotFoundException fnfex)
            {
                Console.WriteLine($"FNFEX:{fnfex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"EX:{ex.Message}");
            }
            finally
            {
                Console.ReadLine();
            }
        }//Main
    }//Program
}
