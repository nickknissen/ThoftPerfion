using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Perfion.Api;

namespace ThoftPerfion.Perfion
{
    public class PerfionHelper : IDisposable
    {
        private PerfionApi _PerfionApi;

        public PerfionHelper()
            : this(ConfigurationManager.AppSettings["Perfion.ConnectionString"])
        {
                
        }
        public PerfionHelper(string connectionString)
        {
            _PerfionApi = new PerfionApi(connectionString);
        }

        public void Dispose()
        {
            _PerfionApi = null;
        }
    }
}
