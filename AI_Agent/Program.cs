using GenerativeAI;
using NJsonSchema;
using System;
using System.ComponentModel.DataAnnotations;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

public class Program
{
    class sum
    {
        [MaxLength(10)]
        public string a { get; set; }
        public string b { get; set; }
        public string ToJsonDocument()
        {
            byte[] utf8Bytes = JsonSerializer.SerializeToUtf8Bytes(this);

            return JsonDocument.Parse(utf8Bytes).RootElement.ToString();
        }
    }
    public static async Task Main(string[] args)
    {

        var dv = new sum() { a = "ali", b = "reza" }.ToJsonDocument();
        Console.WriteLine(dv);
        return;
        var googleAI = new GoogleAi("AIzaSyAHjdKWB7D9z9NeV4vwbJwnnPruHmFQWwM");
        var model = googleAI.CreateGenerativeModel("models/gemini-2.5-flash");

        var end = File.ReadAllText("d://API_Agent//req.txt");
        var my = File.ReadAllText("d://API_Agent//prompt.txt");
        end = end.Replace("EndGoal", my);
        var result = await model.GenerateContentAsync(end);
        File.WriteAllText("d://API_Agent//result.txt", result.Text());
    }
}