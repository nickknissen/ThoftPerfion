using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThoftPerfion.Perfion;

namespace ThoftPerfion
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                using (PerfionHelper pHelper = new PerfionHelper())
                {
                    
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine($"{ex.Message}\r\n{ex.InnerException?.Message}");
            }
        }
    }
}
