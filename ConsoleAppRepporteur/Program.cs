// See https://aka.ms/new-console-template for more information
using ConsoleAppRepporteur.Model;
using Newtonsoft.Json;

namespace ConsoleAppRepporteur
{
    public class Program
    {
        static void Main(string[] args)
        {
            //File path
            var binaryPath = Environment.CurrentDirectory;

            //correction in path to point it in Root directory
            var filePath = binaryPath.Replace("\\bin\\Debug\\net6.0", "\\Content\\Recipe.json");

            //Json file path
            var jsonString = File.ReadAllText(filePath);

            //Deserialize data
            RapporteurBase customerList = JsonConvert.DeserializeObject<RapporteurBase>(jsonString);

            if (customerList != null)
            {
                // Create a string to store the information to be saved to the text file
                string output = "{\n";
                output += "\"name\"" + ": \"" + customerList.Name + "\",\n";
                output += "\"displayName\"" + ": \"" + customerList.DisplayName + "\",\n";
                output += "\"description\"" + ": \"" + customerList.Description + "\",\n";
                output += "\"author\"" + ": \"" + customerList.Author + "\",\n";
                output += "\"website\"" + ": \"" + customerList.Website + "\",\n";
                output += "\"version\"" + ": \"" + customerList.Version + "\",\n";
                output += "\"issetuprecipe\"" + ": " + customerList.IsSetupRecipe + "\",\n";
                output += "\"categories\"" + ": [],\n";
                output += "\"tags\"" + ": [],\n";
                output += "\"steps\"" + ":[\n{\n";
                foreach (Steps_Model steps in customerList.Steps)
                {
                    output += "\"name\"" + ": \"" + steps.Steps_Name + "\",\n";
                    output += "\"data\"" + ":[\n{\n";
                    foreach (Data_Model data in steps.Data)
                    {
                        output += "\"ContentItemId\"" + ": \"" + data.ContentItemId + "\",\n";
                        output += "\"ContentItemVersionId\"" + ": \"" + data.ContentItemVersionId + "\",\n";
                        output += "\"ContentType\"" + ": \"" + data.ContentType + "\",\n";
                        output += "\"DisplayText\"" + ": \"" + data.DisplayText + "\",\n";
                        output += "\"Latest\"" + ": \"" + data.Latest + "\",\n";
                        output += "\"Published\"" + ": \"" + data.Published + "\",\n";
                        output += "\"ModifiedUtc\"" + ": \"" + data.ModifiedUtc + "\",\n";
                        output += "\"PublishedUtc\"" + ": \"" + data.PublishedUtc + "\",\n";
                        output += "\"CreatedUtc\"" + ": \"" + data.CreatedUtc + "\",\n";
                        output += "\"Owner\"" + ": \"" + data.Owner + "\",\n";
                        output += "\"Author\"" + ": \"" + data.Author + "\",\n";
                        output += "\"Rapporteur\"" + ":{\n";
                        output += "\"Name\"" + ":{\n";
                        output += "\"Text\"" + ": \"" + data.Rapporteur.Name.Text + "\"\n},\n";
                        output += "\"Url\"" + ":{\n";
                        output += "\"Text\"" + ": \"" + data.Rapporteur.Url.Text + "\"\n},\n";
                        output += "\"PoliticalParty\"" + ":{\n";
                        output += "\"Text\"" + ": \"" + data.Rapporteur.PoliticalParty.Text + "\"\n},\n";
                        output += "\"NationalParty\"" + ":{\n";
                        output += "\"Text\"" + ": \"" + data.Rapporteur.NationalParty.Text + "\"\n},\n";
                        output += "\"Nation\"" + ":{\n";
                        output += "\"Text\"" + ": \"" + data.Rapporteur.Nation.Text + "\"\n},\n";
                        output += "\"PublishedDate\"" + ":{\n";
                        output += "\"Value\"" + ": \"" + data.Rapporteur.PublishedDate.Value + "\"\n}\n},\n";
                        output += "\"TitlePart\"" + ":{\n";
                        output += "\"Title\"" + ": \"" + data.TitlePart.Title + "\"\n}\n},\n";
                    }
                }

                //Path to store the json file
                var startupPath = binaryPath.Replace("\\bin\\Debug\\net6.0", "\\Content\\");

                File.WriteAllText(@"" + startupPath + "CustomerData.txt", output);

                //Serialize data
                var customerJson = JsonConvert.SerializeObject(customerList, Formatting.Indented);

                //write string to file
                File.WriteAllText(@"" + startupPath + "CustomerData.json", customerJson);

                Console.WriteLine("Stored");

                Console.ReadKey();
            }
        }
    }
}



