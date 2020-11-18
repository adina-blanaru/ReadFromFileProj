using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;

namespace ReadFromFileProj
{
    public class ScenarioDto
    {
        public string TestCaseName { get; set; }
        public string TestInput { get; set; }
        public string OtherInfo { get; set; }
        public List<string> Values { get; set; }

        public static void WriteXML()
        {
            //ScenarioDto myScenario = new ScenarioDto();
            //myScenario.TestCaseName = "Scenariul1";
            //myScenario.TestInput = "test.user@test.com";
            //myScenario.OtherInfo = "password123";
            ScenarioDto myScenario = new ScenarioDto { TestCaseName = "Scenariul1", TestInput = "test.user@test.com", OtherInfo = "password123" };

            //System.Xml.Serialization.XmlSerializer writer = new System.Xml.Serialization.XmlSerializer(typeof(ScenarioDto));
            //var path = @"C:\Users\Adina\Projects\AgileHub_Testare_Automatizata\ReadFromFileProj\WriteInXML.xml";
            //System.IO.FileStream file = System.IO.File.Create(path);
            //writer.Serialize(file, myScenario);
            //file.Close();

            var writer = new System.Xml.Serialization.XmlSerializer(typeof(ScenarioDto));
            var writeFile = new System.IO.StreamWriter(@"C:\Users\Adina\Projects\AgileHub_Testare_Automatizata\ReadFromFileProj\WriteInXML.xml");
            writer.Serialize(writeFile, myScenario);
            writeFile.Close();
        }

        public static ScenarioDto ReadXML()
        {
            System.Xml.Serialization.XmlSerializer reader = new System.Xml.Serialization.XmlSerializer(typeof(ScenarioDto));
            System.IO.StreamReader file = new System.IO.StreamReader(@"C:\Users\Adina\Projects\AgileHub_Testare_Automatizata\ReadFromFileProj\WriteInXML.xml");
            ScenarioDto myScenarioDto = (ScenarioDto)reader.Deserialize(file);
            file.Close();
            return myScenarioDto;
        }

        public static void JsonSerialize()
        {
            ScenarioDto myObject = new ScenarioDto
            {
                TestCaseName = "TestCase1",
                TestInput = "Inputul meu",
                OtherInfo = "Alte informatii",
                Values = new List<string> { "value1", "value2", "value3" }
            };

            ////convert json to string
            //string myJson = JsonConvert.SerializeObject(myObject, Formatting.Indented);
            //Console.WriteLine(myJson);
            ////------------------------------------------------------------------------------------


            ////write json in file
            //File.WriteAllText(@"C:\Users\Adina\Projects\AgileHub_Testare_Automatizata\ReadFromFileProj\MyJsonExample.json", 
            //    JsonConvert.SerializeObject(myObject, Formatting.Indented));
            //Console.WriteLine("Fisierul a fost creat");
            ////------------------------------------------------------------------------------------


            using (StreamWriter file = File.CreateText(@"C:\Users\Adina\Projects\AgileHub_Testare_Automatizata\ReadFromFileProj\MyJsonExample2.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, myObject);
            }
            Console.WriteLine("Fisierul a fost creat");
            ////------------------------------------------------------------------------------------       
        }

        public static void JsonDeserialize()
        {
            string myJson = "{'TestCaseName': 'TestCase1', 'TestInput': 'Inputul meu', 'OtherInfo': 'Alte informatii'}";
            ScenarioDto myObject = JsonConvert.DeserializeObject<ScenarioDto>(myJson);
            Console.WriteLine($"TestCaseName este: {myObject.TestCaseName}");
        }

        public static List<ScenarioDto> LoadValuesFromJsonFile()
        {
            var myFile = @"C:\Users\Adina\Projects\AgileHub_Testare_Automatizata\ReadFromFileProj\MyTestDataJson.json";

            try {
                using (var reader = new StreamReader(myFile))
                {
                    var json = reader.ReadToEnd();
                    var config = JObject.Parse(json).SelectToken("ScenarioDto").ToString();
                    var myTestDataList = JsonConvert.DeserializeObject<List<ScenarioDto>>(config);
                    
                    return myTestDataList;
                }             
            
            }
            catch (Exception)
            {
                throw new Exception($"There's a problem with file {myFile}");
            }

        }


    }
}
