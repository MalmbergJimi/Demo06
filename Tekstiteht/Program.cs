using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tekstiteht
{
    class Program
    {
        static void Main(string[] args)
        {
            string teksti1, teksti2, teksti3, teksti4, teksti5;

            Console.WriteLine("Give me sum text dude!: ");  //Lets ask some text from user 5 times in a row.
            teksti1 = Console.ReadLine();

            Console.WriteLine("Give me moar, dude!: ");  
            teksti2 = Console.ReadLine();

            Console.WriteLine("And moar!: ");  
            teksti3 = Console.ReadLine();

            Console.WriteLine("Still moar!: ");  
            teksti4 = Console.ReadLine();

            Console.WriteLine("This is last time!: ");  // LAST TIME
            teksti5 = Console.ReadLine();

            Console.WriteLine(); // One "Enter" to make it look better

            System.IO.StreamWriter outputFile = new System.IO.StreamWriter(@"d:\K8718\tekstiteht.txt"); //Määritetään polku tiedostolle.
            outputFile.WriteLine(teksti1);      // KIRJOITETAAN KAIKKI TEKSTIT TIEDOSTOON
            outputFile.WriteLine(teksti2);
            outputFile.WriteLine(teksti3);
            outputFile.WriteLine(teksti4);
            outputFile.WriteLine(teksti5);
            outputFile.Close();

        
            // LUETAAN TIEDOSTOSTA TEKSTI    
                string text = System.IO.File.ReadAllText(@"d:\K8718\tekstiteht.txt");
                System.Console.WriteLine("Here comes the text: \n" + text);
            
            
        }
    }
}
