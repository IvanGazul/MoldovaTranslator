using System;
using System.Net;
using System.Threading.Tasks;

namespace NewDesignedTranslator.Internet
{
    public class InternetCheck
    {
        public static bool OK()
        {
            try
            {
                Dns.GetHostEntry("google.com");
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
