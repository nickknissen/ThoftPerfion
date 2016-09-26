using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Perfion.Api;
using Pims.Api;

namespace ThoftPerfion.Perfion
{
    public class PerfionHelper : IDisposable
    {
        private PerfionApi _PerfionApi;

        /// <summary>
        /// Requires that Perfion.ConnectionString is set in the .config file
        /// </summary>
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

        public string QueryString(string query)
        {
            string result = _PerfionApi.ExecuteQueryAsXml(query);
            return result;

        }
    }
}
