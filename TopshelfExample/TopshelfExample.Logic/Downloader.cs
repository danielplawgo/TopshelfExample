using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace TopshelfExample.Logic
{
    public class Downloader : IDownloader
    {
        public void Download(string url)
        {
            var client = new WebClient();

            var content = client.DownloadString(url);
        }
    }

    public interface IDownloader
    {
        void Download(string url);
    }
}
