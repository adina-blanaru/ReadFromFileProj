
namespace ReadFromFileProj
{
    public class ScenarioDto
    {
        public string TestCaseName { get; set; }
        public string TestInput { get; set; }
        public string OtherInfo { get; set; }

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



    }
}
