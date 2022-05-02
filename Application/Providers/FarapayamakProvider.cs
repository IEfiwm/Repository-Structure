using RestSharp;
using System.Threading.Tasks;

namespace Application.Providers
{
    public class FarapayamakProvider
    {
        public string Username;

        public string Password;

        public async Task SendSMS(string text, string to, string from)
        {
            var client = new RestClient("http://rest.payamak-panel.com/api/SendSMS/SendSMS");

            var request = new RestRequest();

            request.AddHeader("Content-Type", "application/x-www-form-urlencoded");

            request.AddParameter("username", Username);

            request.AddParameter("password", Password);

            request.AddParameter("to", to);

            request.AddParameter("from", from);

            request.AddParameter("text", text);

            request.AddParameter("isflash", "true");

            await client.ExecutePostAsync(request);
        }

        public async Task<double> GetCredit()
        {
            var client = new RestClient("https://rest.payamak-panel.com/api/SendSMS/GetCredit");

            var request = new RestRequest();

            request.AddHeader("Content-Type", "application/x-www-form-urlencoded");

            request.AddParameter("username", Username);

            request.AddParameter("password", Password);

            var response = await client.ExecutePostAsync(request);

            return 0;
        }
    }
}