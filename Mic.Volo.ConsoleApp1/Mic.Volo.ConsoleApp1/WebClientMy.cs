using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Mic.Volo.ConsoleApp1
{
    class WebClientMy:IDisposable
    {
        private WebClient _client;

        public WebClientMy()
        {
            _client = new WebClient();
        }

        public void Dispose()
        {
            _client.Dispose();
        }

        public string DownloadHTML(string  s)
        {
            return _client.DownloadString(s);
        }


    }
}
