using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Util.Store;
using System;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Newtonsoft.Json;
namespace Shiping.Services
{
    public class FirebaseHttpClientService
    {
        private readonly HttpClient _httpClient;
        //private const string FcmUrl = "https://fcm.googleapis.com/fcm/send";
        //private const string ServerKey = "YOUR_SERVER_KEY"; // Replace with your Firebase server key

        public FirebaseHttpClientService()
        {
            _httpClient = new HttpClient();
        }





        public static async Task<string> GetAccessTokenAsync()
        {
            GoogleCredential credential;

            // Load the service account key file
            var fileName = "shipping-c2492-55663b536b57.json";

            var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", fileName);

            using (var stream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            {
                credential = GoogleCredential.FromStream(stream)
                             .CreateScoped("https://www.googleapis.com/auth/firebase.messaging");
            }

            // Get access token
            var token = await credential.UnderlyingCredential.GetAccessTokenForRequestAsync();
            return token;
        }

        public async Task SendNotificationToTopicAsync(string topic, string title, string body)
        {
            var accessToken = await GetAccessTokenAsync();

            // Define the message payload
            var message = new
            {
                message = new
                {
                    topic = topic,
                    notification = new
                    {
                        title = title,
                        body = body
                    }
                }
            };

            // Serialize the message to JSON
            var jsonMessage = JsonConvert.SerializeObject(message);

            // Define the FCM v1 API URL
            var projectId = "moonlight-8c8e9";  // Replace with your Firebase project ID
            var url = $"https://fcm.googleapis.com/v1/projects/{projectId}/messages:send";

            // Create the HttpClient and make the POST request
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var content = new StringContent(jsonMessage, System.Text.Encoding.UTF8, "application/json");
                var response = await client.PostAsync(url, content);

                var responseContent = await response.Content.ReadAsStringAsync();
                Console.WriteLine($"Response Status Code: {response.StatusCode}");
                Console.WriteLine($"Response Content: {responseContent}");
            }
        }

        public async Task SendNotificationToTokensAsync(List<string> fcmTokens, string title, string body)
        {
            var accessToken = await GetAccessTokenAsync();

            // Define the FCM v1 API URL
        //    var projectId = "shipping-c2492";  // Replace with your Firebase project ID
            var projectId = "moonlight-8c8e9";  // Replace with your Firebase project ID
            var url = $"https://fcm.googleapis.com/v1/projects/{projectId}/messages:send";

            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                foreach (var token in fcmTokens)
                {
                    // Define the message payload for each token
                    var message = new
                    {
                        message = new
                        {
                            token = token, // Target individual token
                            notification = new
                            {
                                title = title,
                                body = body
                            }
                        }
                    };

                    // Serialize the message to JSON
                    var jsonMessage = JsonConvert.SerializeObject(message);

                    // Create the content for the HTTP request
                    var content = new StringContent(jsonMessage, System.Text.Encoding.UTF8, "application/json");

                    // Send the POST request
                    var response = await client.PostAsync(url, content);
                    var responseContent = await response.Content.ReadAsStringAsync();

                    // Log the response for each token
                    Console.WriteLine($"Response Status Code for token {token}: {response.StatusCode}");
                    Console.WriteLine($"Response Content for token {token}: {responseContent}");
                }
            }
        }
    }
}


