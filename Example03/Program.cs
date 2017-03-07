using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example03
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string sql = @"select *
                           form  table
                           where id >1000";
            Console.WriteLine(sql);

            string xml = @"<aaa>
                          <bbb>#001</bbb>
                          <ccc>xxx</ccc>
                        </aaa>";
            Console.WriteLine(xml);

            string json = @"pokemon={aaa:'#001', bbb:xxx}";
            Console.WriteLine(json);
        }
    }
}