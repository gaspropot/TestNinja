using System.Net;

namespace TestNinja.Mocking
{
    public class InstallerHelper
    {
        private IWebClientHelper _webClientHelper;

        public InstallerHelper(IWebClientHelper webClientHelper = null)
        {
            _webClientHelper = webClientHelper ?? new WebClientHelper();
        }

        private string _setupDestinationFile;

        public bool DownloadInstaller(string customerName, string installerName)
        {
            try
            {
                _webClientHelper.Download(customerName, installerName, _setupDestinationFile);

                return true;
            }
            catch (WebException)
            {
                return false; 
            }
        }
    }
}