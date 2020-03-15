using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace RAD_CSharp_Role_Exercise
{
    public class GetPaymentsClient
    {
        private static readonly HttpClient HttpClient;
        public string EndPoint { get; set; } = string.Empty;
        public string SavePath { get; set; } = string.Empty;
        public string Portfolio { get; set; } = string.Empty;

        static GetPaymentsClient()
        {
            HttpClient = new HttpClient();
        }

        public async Task GetPayments()
        {                   
            try
            {
               // Get payments data
                HttpResponseMessage response = await HttpClient.GetAsync(EndPoint + Portfolio);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();

                //Store response in CSV file
                SavePayments(responseBody);
            }
            catch (HttpRequestException e)
            {
                throw e;
            }
        }

        private void SavePayments(string responseBody)
        {
            using (StreamWriter sw = new StreamWriter(Properties.Settings.Default.SavePath, append: true))
            {
                sw.WriteLine(responseBody);
                sw.Close();
            }
        }
    }
}
