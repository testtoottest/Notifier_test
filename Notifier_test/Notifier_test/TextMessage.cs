using System;

namespace Notifier_test
{
    class TextMessage
    {
        public static void send() {
            using (System.Net.WebClient client = new System.Net.WebClient())
            {
                string userName = "testtoottest@gmail.com";
                string password = "1f906";
                string msgSender = "48667977867";
                string msgReceiver = "48667977867";
                string message = "test";

                string url = "http://smsc.vianett.no/v3/send.ashx?" +
                "src=" + msgSender +
                "&dst=" + msgReceiver +
                "&msg=" + System.Web.HttpUtility.UrlEncode
                (message, System.Text.Encoding.GetEncoding("ISO-8859-1")) +
                "&username=" + System.Web.HttpUtility.UrlEncode(userName) +
                "&password=" + password;

                string result = client.DownloadString(url);
                if (result.Contains("OK"))
                {
                    Console.WriteLine("Sms sent successfully", "Message");
                }
                else
                {
                    Console.WriteLine("Some issue delivering", "Message");
                }
            }

            Console.ReadKey();
            }
      }
}

