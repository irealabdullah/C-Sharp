//----------------------------
// Try with Multiple Catch
//----------------------------

/*
1. With One try{Block} we can make multiple Catch{Blocks}
2. Keep In Mind:
    + At a time only one exception is occoured and at a time only one catch block execute 
    + All catch blocks must be ordered from most specific to most general 
*/

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Myproject
{
    class program
    {
        static void Main(string[] args)
        {
			try //Below we have three Exceptions 
			{
                //Concept yeh hai ke try block main at a time aik he exception ati hai aur at a time aik he catch block work karta hai chahe hum ne jitne marzi catch block banaye hoon 

                int a = 10;
                int b = 0;
                int c = a / b;

                string name = null;
                Console.WriteLine(name.Length);

                int[] arr = new int[2];
                arr[0] = 1;
                arr[1] = 2;
                arr[2] = 3;
			}

			catch (DivideByZeroException DZE)
			{
                Console.WriteLine(DZE.Message);
            }

            catch (NullReferenceException NRE)
            {
                Console.WriteLine(NRE.Message);
            }

            catch (FormatException FEXP)
            {
                Console.WriteLine(FEXP.Message);   
            }

            catch (Exception EXc) // Isko hum End pe likhte hain kyun ke agar koi in sab se haat kar exception ati hai tu yeh chale ga aur isko sabse upper likhne se error bhi ayee ga kyun yeh parent hai 
            {
                Console.WriteLine(EXc.Message);
            }

            Console.ReadLine();
        }
    }
}