using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInterfaceMatskevichM.Utilities
{
    public class RandomData
    {
        public static string GenerateRandomEmail()
        {
            string[] domains = { "example.com", "example.net", "example.org" };

            Random random = new Random();
            string randomString = Path.GetRandomFileName().Replace(".", ""); // Generate a random string

            // Concatenate the random string with a domain
            string randomEmail = $"user_{randomString.Substring(0, 8)}@{domains[random.Next(0, domains.Length)]}";

            return randomEmail;
        }

    }
}
