using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextmagicRest;
using TextmagicRest.Model;

namespace Notifier_test
{
    class TextMessage
    {
        public static void sendMessage()
        {
            var client = new Client("test", "my-api-key");
            var link = client.SendMessage("Hello from TextMagic API", "48667977867");
            if (link.Success)
            {
                Console.WriteLine("Message ID {0} has been successfully sent", link.Id);
            }
            else
            {
                Console.WriteLine("Message was not sent due to following exception: {0}", link.ClientException.Message);
          }
        }

    }
}
