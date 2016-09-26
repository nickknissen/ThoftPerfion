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
                    string query = @"
                    <Query>
	                    <Select languages='EN,DAN'>
		                    <Feature id='**' />

	                    </Select>
	                    <From id ='Product'/>
	                    <Where>
		                    <Clause id='ID' operator='=' value='34040' />
	                    </Where>
                    </Query>
                    ";
                    Console.WriteLine("Query:");
                    Console.WriteLine();
                    Console.WriteLine(query);
                    Console.WriteLine();
                    string result = pHelper.QueryString(query);
                    Console.WriteLine("Result:");
                    Console.WriteLine();
                    Console.WriteLine(result.Substring(0,1000));
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine($"{ex.Message}\r\n{ex.InnerException?.Message}");
            }
        }
    }
}
