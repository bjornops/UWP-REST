using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UWP_REST.DataModel
{
    class ResponseModel
    {
        public string Url { get; private set; }
        public DateTime Timestamp { get; private set; }
        public string ResponseHeaders { get; private set; }
        public string ResponseBody { get; private set; }
        public int ResponseTime { get; private set; }

        public ResponseModel(string url, string responseHeader, string responseBody)
        {
            Url = url;
            ResponseHeaders = responseHeader;
            ResponseBody = responseBody;
            Timestamp = DateTime.Now;
        }

    }
}
