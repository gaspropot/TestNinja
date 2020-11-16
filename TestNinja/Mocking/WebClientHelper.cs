using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace TestNinja.Mocking
{
    public interface IWebClientHelper
    {
        void Download(string customerName, string installerName, string setupDestinationFile);
    }


    public class WebClientHelper : IWebClientHelper
    {
        public void Download(string customerName, string installerName, string setupDestinationFile)
        {
            var client = new WebClient();

            client.DownloadFile(
                       string.Format("http://example.com/{0}/{1}",
                           customerName,
                           installerName),
                        setupDestinationFile);
        }
        
    }
}
