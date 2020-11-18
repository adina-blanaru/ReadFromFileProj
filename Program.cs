using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadFromFileProj
{
    class Program
    {
        static void Main(string[] args)
        {
            ////WriteAllLines
            //string[] lines = { "Linia 1", "Linia 2", "Linia 3", "Linia 4", "Linia 5" };
            //System.IO.File.WriteAllLines(@"C:\Users\Adina\Projects\AgileHub_Testare_Automatizata\ReadFromFileProj\WriteLinesSample.txt", lines); // @ indicates this string is a path in my system; otherwise, we need to use \\
            //Console.WriteLine("Liniile au fost scrise in fisier");
            //Console.ReadKey();
            ////----------------------------------------------------------------------------------


            ////WriteAllText
            //string text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean pellentesque ornare dui, sed laoreet lacus consequat in. Phasellus accumsan sem odio, sed pharetra massa vehicula a. Fusce tortor mi, gravida hendrerit aliquet non, molestie nec nisl. Proin venenatis non nulla ut molestie. Mauris in orci eros. Donec suscipit et neque.";
            //System.IO.File.WriteAllText(@"C:\Users\Adina\Projects\AgileHub_Testare_Automatizata\ReadFromFileProj\WriteLinesSample.txt", text);
            //Console.WriteLine("Textul a fost scris in fisier");
            //Console.ReadKey();
            ////----------------------------------------------------------------------------------


            ////write in file based on conditions
            //using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\Users\Adina\Projects\AgileHub_Testare_Automatizata\ReadFromFileProj\WriteLinesSample.txt"))
            //{
            //    string[] lines = { "Linia 1", "Linia 2", "Linia 3", "Linia 4", "Linia 5" };
            //    foreach (var line in lines)
            //    {
            //        if (!line.Contains("3"))
            //        {
            //            file.WriteLine(line);
            //        }                    
            //    }
            //}
            //Console.WriteLine("Am scris in fisier");
            //Console.ReadKey();
            ////----------------------------------------------------------------------------------


            //// append text to file instead of overwrite the entire file
            //using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\Users\Adina\Projects\AgileHub_Testare_Automatizata\ReadFromFileProj\WriteLinesSample.txt", true))
            //{
            //    string[] lines = { "Linia 1", "Linia 2", "Linia 3", "Linia 4", "Linia 5" };
            //    foreach (var line in lines)
            //    {
            //        if (line.Contains("3"))
            //        {
            //            file.WriteLine(line);
            //        }

            //    }
            //}
            //Console.WriteLine("Am scris in fisier");
            //Console.ReadKey();
            ////----------------------------------------------------------------------------------


            ////ReadAllText
            //string readText = System.IO.File.ReadAllText(@"C:\Users\Adina\Projects\AgileHub_Testare_Automatizata\ReadFromFileProj\WriteLinesSample.txt");
            //System.Console.WriteLine($"Textul nostru este: {readText}");
            //Console.ReadKey();
            ////----------------------------------------------------------------------------------


            ////ReadAllLines and ReadLines
            //string[] readLines = System.IO.File.ReadAllLines(@"C:\Users\Adina\Projects\AgileHub_Testare_Automatizata\ReadFromFileProj\WriteLinesSample.txt");
            //var altReadLines = System.IO.File.ReadLines(@"C:\Users\Adina\Projects\AgileHub_Testare_Automatizata\ReadFromFileProj\WriteLinesSample.txt");

            //System.Console.WriteLine("Liniile nostre sunt: ");
            //foreach (var line in readLines)
            //{
            //    Console.WriteLine(line);
            //    Console.ReadKey();
            //}
            //Console.ReadKey();
            ////----------------------------------------------------------------------------------


            ////read line fro file based on conditions
            //string line;
            //System.IO.StreamReader file = new System.IO.StreamReader(@"C:\Users\Adina\Projects\AgileHub_Testare_Automatizata\ReadFromFileProj\ReadScenarioSample.txt");
            //Console.WriteLine("Voi citi scenariile:");
            //while ((line = file.ReadLine()) != null)
            ////while ((line = file.ReadLine()) != string.Empty)
            //{     
            //    if (line.Contains("NumeScenariu"))
            //    {
            //        Console.WriteLine(line);
            //        Console.ReadKey();
            //    }
            //}
            //file.Close(); //close file when you're done
            ////----------------------------------------------------------------------------------


            ////write xml
            //ScenarioDto.WriteXML();
            //Console.WriteLine("Fisierul xml a fost creat");
            //Console.ReadKey();
            ////----------------------------------------------------------------------------------


            ////read from xml
            //var myValue = ScenarioDto.ReadXML();
            //Console.WriteLine($"Numele scenariului este: {myValue.TestCaseName}, proprietatea2 este: {myValue.TestInput}, proprietatea3 este: {myValue.OtherInfo}");
            //Console.ReadKey();
            ////----------------------------------------------------------------------------------


            ////Json serialize
            //ScenarioDto.JsonSerialize();
            //Console.ReadKey();
            ////----------------------------------------------------------------------------------


            ////Json deserialize
            //ScenarioDto.JsonDeserialize();
            //Console.ReadKey();
            ////----------------------------------------------------------------------------------


            ////load values from json file
            var myList = ScenarioDto.LoadValuesFromJsonFile();
            foreach (var element in myList)
            {
                Console.WriteLine($"Elementul {myList.IndexOf(element)}: {element.TestCaseName}, {element.TestInput}, {element.OtherInfo}, numarul de valori in campul values: {element.Values.Count}");
            }
            Console.ReadKey();
            ////----------------------------------------------------------------------------------


        }
    }
}
